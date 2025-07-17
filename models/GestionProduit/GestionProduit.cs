using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models.GestionProduit
{
    public class GestionProduit
    {
        public static void ajouterProduit(string designation)
        {
            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO produit (designation)" +
                    " VALUES (@designation)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@designation", designation);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} produit(s) ajouté(s).");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }



        public List<Produit> GetProduits()
        {
            var produits = new List<Produit>();
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM produit";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var produit = new Produit
                            {
                                Id = reader.GetInt32(0),           // Column index 0: id
                                Designation = reader.GetString(1)  // Column index 1: designation
                            };
                            produits.Add(produit);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
            return produits;
        }
    }
}
