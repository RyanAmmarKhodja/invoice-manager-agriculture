using StockIt_2.controllers;
using StockIt_2.models;
using StockIt_2.models.GestionBon;
using StockIt_2.models.GestionCoords;
using StockIt_2.models.GestionProduit;
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






        private void imprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Date = DateTime.Now;


                Bon bon = new Bon
                {
                    Date = Date,
                    fournisseur_nom = fnom.Text,
                    fournisseur_prenom = fprenom.Text,
                    transporteur_nom = tnom.Text,
                    transporteur_prenom = tprenom.Text,
                    prix_transport_unitaire = double.Parse(cout_transport.Text),
                    total_amount = double.Parse(total_general.Text.Replace(" DZD", ""))
                };

                int bonId = GestionBon.ajouterBon(bon);
                bon.Id = bonId; // Set the Id of the bon after insertion


                Bon_item item = new Bon_item
                {
                    designation = combo.SelectedValue.ToString(),
                    nbr = int.Parse(nombre.Text),
                    poids_kg = double.Parse(poids.Text),
                    prix_unitaire = double.Parse(prix_unitaire.Text),
                    ttc = double.Parse(total_ttc.Text.Replace(" DZD", "")),
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

        private void total_ttc_Click(object sender, EventArgs e)
        {

        }
    }
}
