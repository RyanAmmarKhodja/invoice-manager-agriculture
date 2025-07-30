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
        public Fournisseur fournisseur { get; set; }
        public Transporteur transporteur { get; set; }
        public string category_fournisseur { get; set; }
        public decimal prix_transport_unitaire { get; set; }
        public decimal total_amount { get; set; }

        public List<Bon_item> Items { get; set; } = new List<Bon_item>();
    }
}
