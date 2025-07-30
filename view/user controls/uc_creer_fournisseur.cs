using StockIt_2.controllers;
using StockIt_2.services.GestionFournisseurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt_2.user_controls
{
    public partial class uc_creer_fournisseur : UserControl
    {
        public uc_creer_fournisseur()
        {
            InitializeComponent();
        }



        private void retour_Click(object sender, EventArgs e)
        {

            //NavigationMaster.Navigate(new uc_achats());
            NavigationMaster.retour();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string _nom = nom.Text;
            string _prenom = prenom.Text;
            string _rc = rc.Text;
            string _ai = ai.Text;
            string _nif = nif.Text;
            string _nis = nis.Text;
            string _tel = tel.Text;
            string _n_bl = n_bl.Text;
            string _n_facture = facture.Text;
            string _adresse = adresse.Text;


            if (string.IsNullOrWhiteSpace(_nom))
            {
                MessageBox.Show("Le nom ne peut pas être vide.");
                return;
            }
            GestionFournisseurs.ajouterFournisseur(_nom, _prenom, _rc, _ai, _nif, _nis, _tel, _n_bl, _n_facture, _adresse);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retour_Click(sender, e);
        }

    }
}
