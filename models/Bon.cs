using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models
{
    public class Bon
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string fournisseur_nom { get; set; }
        public string fournisseur_prenom { get; set; }
        public string transporteur_nom { get; set; }
        public string transporteur_prenom { get; set; }
        public double prix_transport_unitaire { get; set; }
        public double total_amount { get; set; }

        public List<Bon_item> Items { get; set; } = new List<Bon_item>();
    }
}
