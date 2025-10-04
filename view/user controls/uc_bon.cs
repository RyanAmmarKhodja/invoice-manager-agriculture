using StockIt_2.controllers;
using StockIt_2.models;
using StockIt_2.view.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using StockIt_2.services.GestionCoords;
using StockIt_2.services.GestionBon;
using StockIt_2.services.GestionProduit;
using StockIt_2.services.GestionFournisseurs;
using StockIt_2.services.GestionIndividu;


namespace StockIt_2.view.user_controls
{
    public partial class uc_bon : UserControl
    {
        private GestionCoords coords = new GestionCoords();
        public uc_bon()
        {
            InitializeComponent();
            calculer_ttc();

        }
        private void uc_bon_Load(object sender, EventArgs e)
        {


            // Récupération des produits pour le comboBox
            GestionProduit gestion = new GestionProduit();
            var produits = gestion.GetProduits();
            combo.DataSource = produits;
            combo.DisplayMember = "Designation";
            combo.ValueMember = "Designation";

            // Récupération des coordonnées de l'entreprise

            var coordonnes = coords.GetCoords();

            crc.Text = coordonnes.rc;
            cai.Text = coordonnes.ai;
            cnif.Text = coordonnes.nif;
            cnis.Text = coordonnes.nis;
            cadresse.Text = coordonnes.adresse;
            coords_email.Text = coordonnes.email;
            coords_tel.Text = coordonnes.tel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choisir_transporteur transporteur = new choisir_transporteur();
            transporteur.OnDataSent += HandleDataFromForm1;
            transporteur.Show();


        }

        private void HandleDataFromForm1(string[] data)
        {

            try
            {
                tnom.Text = data[0];
                tprenom.Text = data[1];
                tadresse.Text = data[2];
                matricule.Text = data[3];
                ttel.Text = data[4];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //MessageBox.Show("Data received from Form1: Name:" + data[0] + "prenom: " + data[1]+"adresse: " + data[2]);

        }

        private void choisir_fournisseur_Click(object sender, EventArgs e)
        {
            choisir_fournisseur fournisseur = new choisir_fournisseur();
            fournisseur.OnDataSent += HandleDataFromForm2;
            fournisseur.Show();
        }

        private void HandleDataFromForm2(string[] data)
        {
            fnom.Text = data[1];
            fprenom.Text = data[2];
            fadresse.Text = data[3];
            rc.Text = data[4];
            ai.Text = data[5];
            nif.Text = data[6];
            nis.Text = data[7];
            ftel.Text = data[8];
            bl.Text = data[9];
            facture.Text = data[10];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //NavigationMaster.Navigate(new uc_achats());
            NavigationMaster.retour();
        }



        private void ajouter_produit_Click(object sender, EventArgs e)
        {
            AjouterProduit produitForm = new AjouterProduit();
            produitForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var maj = MessageBox.Show("Voulez-vous vraiment modifier les coordonnées de l'entreprise ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (maj == DialogResult.Yes)
            {
                var nouvellesCoordonnes = new Coords
                {
                    tel = coords_tel.Text.Trim(),
                    email = coords_email.Text.Trim(),
                    rc = crc.Text.Trim(),
                    ai = cai.Text.Trim(),
                    nif = cnif.Text.Trim(),
                    nis = cnis.Text.Trim(),
                    adresse = cadresse.Text
                };



                // Appel de la méthode pour modifier les coordonnées
                var coordonnes = coords.editCoords(nouvellesCoordonnes);
                MessageBox.Show("Coordonnées mises à jour avec succès.");
            }

        }

        private void calculer_ttc()
        {

            decimal _nombre = 0;
            decimal _poids = 0;
            decimal _prix = 0;
            decimal _tpv = 0;

            //total labels 
            decimal tpv = 0;
            decimal ttc = 0;
            decimal tg = 0;

            decimal.TryParse(nombre.Text, out _nombre);
            decimal.TryParse(poids.Text, out _poids);
            decimal.TryParse(prix_unitaire.Text, out _prix);
            decimal.TryParse(cout_transport.Text, out _tpv);


            if (_poids > 0) // Check if poids has a meaningful value (greater than 0)
            {
                ttc = _poids * _prix;
            }
            else if (_nombre > 0) // Only if poids is 0 or not entered, then use nombre
            {
                ttc = _nombre * _prix;
            }

            tpv = _tpv * _nombre;
            tg = tpv + ttc;
            total_general.Text = tg.ToString("F2") + " DZD";
            total_tpv.Text = tpv.ToString("F2") + " DZD";
            total_ttc.Text = ttc.ToString("F2") + " DZD";
        }


        private void prix_unitaire_TextChanged(object sender, EventArgs e)
        {
            calculer_ttc();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            calculer_ttc();
        }

        private void poids_TextChanged(object sender, EventArgs e)
        {
            calculer_ttc();
        }

        private void tpv_TextChanged(object sender, EventArgs e)
        {
            calculer_ttc();
        }


        private void CheckCategoryFournisseur(Bon bon, Fournisseur fournisseur)
        {
            GestionFournisseurs gestionFournisseur = new GestionFournisseurs();
            GestionParticulier gestionParticulier = new GestionParticulier();
            if (gestionFournisseur.CheckFournisseurByNif(fournisseur))
            {
                bon.category_fournisseur = "entreprise";
            }
            else
            {
                if (gestionParticulier.CheckParticulierByTel(fournisseur))
                {
                    bon.category_fournisseur = "particulier";
                }
                else
                {
                    // Si le fournisseur n'est ni une entreprise ni un particulier, on le considère comme un particulier par défaut
                    gestionParticulier.AddParticulier(fournisseur);
                    MessageBox.Show("Fournisseur ajouté en tant que particulier.");
                    bon.category_fournisseur = "particulier";
                }
            }
        }



        private void imprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre.Text))
                {
                    throw new ArgumentNullException("Veuillez écrire le nombre.");
                }

                Fournisseur fournisseur = new Fournisseur
                {
                    nom = fnom.Text,
                    prenom = fprenom.Text,
                    rc = rc.Text,
                    ai = ai.Text,
                    nif = nif.Text,
                    nis = nis.Text,
                    tel = ftel.Text,
                    adresse = fadresse.Text,
                    n_bl = bl.Text,
                    n_facture = facture.Text
                };

                Transporteur transporteur = new Transporteur
                {
                    nom = tnom.Text,
                    prenom = tprenom.Text,
                    adresse = tadresse.Text,
                    matricule = matricule.Text,
                    tel = ttel.Text
                };


                DateTime Date = DateTime.Now;


                Bon bon = new Bon
                {
                    Date = Date,
                    fournisseur = fournisseur,
                    transporteur = transporteur,
                    prix_transport_unitaire = decimal.Parse(cout_transport.Text),
                    total_amount = decimal.Parse(total_general.Text.Replace(" DZD", ""))
                };

                CheckCategoryFournisseur(bon, fournisseur);

                int bonId = GestionBon.ajouterBon(bon);
                bon.Id = bonId; // Set the Id of the bon after insertion


                if (String.IsNullOrEmpty(poids.Text))
                {
                    poids.Text = "0"; // Default to 0 if poids is not provided
                }

                Bon_item item = new Bon_item
                {
                    designation = combo.SelectedValue.ToString(),
                    nbr = int.Parse(nombre.Text),
                    poids_kg = decimal.Parse(poids.Text),
                    prix_unitaire = decimal.Parse(prix_unitaire.Text),
                    ttc = decimal.Parse(total_ttc.Text.Replace(" DZD", "")),
                    bon = bon,
                };

                bon.Items.Add(item); // Add the item to the bon's items list


                GestionBonItem.ajouterBonItem(item);

                var document = new InvoiceDocument(bon);
                document.GeneratePdfAndShow();


                MessageBox.Show("Bon imprimé avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'impression du bon: " + ex.Message);
            }
        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonGroupBox1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
