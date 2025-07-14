using StockIt_2.user_controls;
using StockIt_2.view.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt_2
{
    public partial class uc_achats : UserControl
    {
        public uc_achats()
        {
            InitializeComponent();
        }

        private void fournisseur_Click(object sender, EventArgs e)
        {
            NavigationMaster.Navigate(new uc_creer_fournisseur());
        }

        private void bon_reception_Click(object sender, EventArgs e)
        {
            NavigationMaster.Navigate(new uc_bon());
        }

        private void retour_Click(object sender, EventArgs e)
        {

            NavigationMaster.Navigate(new uc_accueil());

        }

        private void transporteurBtn_Click(object sender, EventArgs e)
        {
            NavigationMaster.Navigate(new uc_creer_transporteur());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigationMaster.Navigate(new uc_add());
        }
    }
}
