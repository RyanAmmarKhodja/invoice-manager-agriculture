using Microsoft.VisualBasic;
using StockIt_2.models.GestionTransporteurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockIt_2.view.forms
{
    public partial class choisir_transporteur : Form
    {
        public delegate void DataSentHandler(string[] data);
        public event DataSentHandler OnDataSent;
        private string nom;
        private string prenom;
        private string matricule;
        private string adresse;
        private string tel;

        public choisir_transporteur()
        {
            InitializeComponent();
        }

        private void trans_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex > 0)
                {
                    DataGridViewRow row = trans_grid.Rows[e.RowIndex];
                    nom = row.Cells["nom"].Value.ToString();
                    prenom = row.Cells["prenom"].Value.ToString();
                    adresse = row.Cells["adresse"].Value.ToString();
                    matricule = row.Cells["matricule"].Value.ToString();
                    tel = row.Cells["tel"].Value.ToString();

                    string[] dataToSend = { nom, prenom, adresse, matricule, tel };
                    OnDataSent?.Invoke(dataToSend);
                }
                
            }
            catch (Exception ex)  {
                MessageBox.Show(ex.Message);
            
            }
              
        }
        private void trans_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void choisir_transporteur_Load(object sender, EventArgs e)
        {
            GestionTransporteurs gestion = new GestionTransporteurs();
            var transporteurs = gestion.GetTransporteurs();
            trans_grid.DataSource = transporteurs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
