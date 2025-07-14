using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2
{
    public static class NavigationMaster
    {
        public static Panel MainPanel { get; set; }
        //public static List<UserControl> history;
        public static void Navigate(UserControl uc)
        {
            MainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(uc);
            //history.Add(uc);
        }

        //public static void retour() {
        //    history.RemoveAt(history.Count - 1);
        //    NavigationMaster.Navigate(history[history.Count - 1]);

        //}
    }
}
