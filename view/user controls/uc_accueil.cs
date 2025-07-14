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
    public partial class uc_accueil : UserControl
    {
        public uc_accueil()
        {
            InitializeComponent();
        }

        private void achatsBtn_Click(object sender, EventArgs e)
        {
            NavigationMaster.Navigate(new uc_achats());
            
        }
    }
}
