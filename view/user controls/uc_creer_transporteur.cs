using StockIt_2.controllers;
using StockIt_2.services.GestionTransporteurs;
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
    public partial class uc_creer_transporteur : UserControl
    {
        public uc_creer_transporteur()
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
            string _adresse = adresse.Text;
            string _matricule = matricule.Text;
            string _tel = tel.Text;

            if (string.IsNullOrWhiteSpace(_nom))
            {
                MessageBox.Show("Le nom ne peut pas être vide.");
                return;
            }

            GestionTransporteurs.ajouterTransporteur(_nom, _prenom, _adresse, _matricule, _tel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retour_Click(sender, e);
        }

    }
}
