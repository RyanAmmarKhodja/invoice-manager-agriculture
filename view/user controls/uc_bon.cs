using StockIt_2.models;
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

namespace StockIt_2.view.user_controls
{
    public partial class uc_bon : UserControl
    {
        private GestionCoords coords = new GestionCoords();
        public uc_bon()
        {
            InitializeComponent();
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
            NavigationMaster.Navigate(new uc_achats());
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

        private void ajouter_produit_Click(object sender, EventArgs e)
        {
            AjouterProduit produitForm = new AjouterProduit();
            produitForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var maj = MessageBox.Show("Voulez-vous vraiment modifier les coordonnées de l'entreprise ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(maj == DialogResult.Yes)
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
    }
}
