using StockIt_2.models;
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
    public partial class uc_add : UserControl
    {
        public uc_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameQuery = name.Text;
            string fieldQuery = field.Text;

            //GestionFournisseurs.addFournisseur(nameQuery, fieldQuery);
        }
    }
}
