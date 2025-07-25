using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models
{
    public class Bon_item
    {
        public int Id { get; set; }
        public string designation { get; set; }
        public int nbr { get; set; }
        public double poids_kg { get; set; }
        public double prix_unitaire { get; set; }
        public double ttc { get; set; }    
        public Bon bon { get; set; }
    }
}
