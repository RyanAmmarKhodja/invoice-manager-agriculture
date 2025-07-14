using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models
{
    public class Fournisseur
    {
        public int id {  get; set; }
        public string nom { get; set; }
        public string prenom {  get; set; }
        public string adresse {  get; set; }
        public string rc { get; set; }
        public string ai { get; set; }
        public string nif { get; set; }
        public string nis { get; set; }
        public string tel { get; set; }
        public string n_bl { get; set; }
        public string n_facture { get; set; }
    }
}
