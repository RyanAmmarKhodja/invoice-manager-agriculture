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

namespace StockIt_2.view.user_controls
{
    public partial class uc_bon : UserControl
    {
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

        private void retour_Click(object sender, EventArgs e)
        {
            NavigationMaster.Navigate(new uc_achats());
        }
    }
}
