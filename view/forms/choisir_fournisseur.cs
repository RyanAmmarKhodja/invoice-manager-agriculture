using StockIt_2.models.GestionFournisseurs;
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
    public partial class choisir_fournisseur : Form
    {
        public delegate void DataSentHandler(string[] data);
        public event DataSentHandler OnDataSent;
        private string id;
        private string nom;
        private string prenom;
        private string adresse;
        private string rc;
        private string ai;
        private string nif;
        private string nis;
        private string tel;
        private string n_bl;
        private string n_facture;

        private void four_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0)
                {
                    DataGridViewRow row = four_grid.Rows[e.RowIndex];
                    id = row.Cells["id"].Value.ToString();
                    nom = row.Cells["nom"].Value.ToString();
                    prenom = row.Cells["prenom"].Value.ToString();
                    adresse = row.Cells["adresse"].Value.ToString();
                    rc = row.Cells["rc"].Value.ToString();
                    ai = row.Cells["ai"].Value.ToString();
                    nif = row.Cells["nif"].Value.ToString();
                    nis = row.Cells["nis"].Value.ToString();
                    tel = row.Cells["tel"].Value.ToString();
                    n_bl = row.Cells["n_bl"].Value.ToString();
                    n_facture = row.Cells["n_facture"].Value.ToString();

                    string[] dataToSend = {id, nom, prenom, adresse, rc, ai, nif, nis, tel, n_bl, n_facture };
                    OnDataSent?.Invoke(dataToSend);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public choisir_fournisseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choisir_fournisseur_Load(object sender, EventArgs e)
        {
            GestionFournisseurs gestion = new GestionFournisseurs();
            var fournisseurs = gestion.GetFournisseurs();
            four_grid.DataSource = fournisseurs;

        }

    }
}
