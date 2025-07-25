using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models.GestionBon
{
    public class GestionBonItem
    {
        public static void ajouterBonItem(Bon_item item)
        {
            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO bon_items (designation, nbr, poids_kg, prix_unitaire, total, id_bon)" +
                    " VALUES (@designation, @nbr, @poids_kg, @prix_unitaire, @total, @id_bon)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@designation", item.designation);
                        cmd.Parameters.AddWithValue("@nbr", item.nbr);
                        cmd.Parameters.AddWithValue("@poids_kg", item.poids_kg);
                        cmd.Parameters.AddWithValue("@prix_unitaire", item.prix_unitaire);
                        cmd.Parameters.AddWithValue("@total", item.ttc);
                        cmd.Parameters.AddWithValue("@id_bon", item.bon.Id);
                        int rows = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }
    }
}
