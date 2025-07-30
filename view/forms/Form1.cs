using StockIt_2.controllers;
using StockIt_2.models;
using StockIt_2.user_controls;

namespace StockIt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NavigationMaster.MainPanel = panelContainer;
            Db.Initialize();
            

            //NavigationMaster.history = new List<UserControl>();

            NavigationMaster.Navigate(new uc_accueil());
            
        }

        
    }
}
