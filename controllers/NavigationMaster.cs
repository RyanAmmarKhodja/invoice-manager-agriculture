using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.controllers
{
    public static class NavigationMaster
    {
        public static Panel MainPanel { get; set; }
        public static List<UserControl> history = new List<UserControl>();
        public static void Navigate(UserControl uc)
        {
            MainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(uc);
            if (history.Count == 0 || history[history.Count - 1] != uc)
                history.Add(uc);
        }

        public static void retour() {
            //history.RemoveAt(history.Count - 1);
            //NavigationMaster.Navigate(history[history.Count - 1]);


            if (history.Count > 1)
            {
                history.RemoveAt(history.Count - 1);
                Navigate(history[history.Count - 1]);
            }

        }
    }
}
