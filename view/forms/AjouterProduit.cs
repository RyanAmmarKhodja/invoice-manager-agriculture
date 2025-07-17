using StockIt_2.models.GestionProduit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt_2.view.forms
{
    public partial class AjouterProduit : Form
    {
        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string designation = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(designation))
                {
                    MessageBox.Show("Veuillez entrer une désignation pour le produit.");
                    return;
                }
                GestionProduit.ajouterProduit(designation);
                this.Close(); // Ferme la fenêtre après l'ajout
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du produit : " + ex.Message);
            }
        }
    }
}
