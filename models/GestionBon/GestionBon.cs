using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models.GestionBon
{
    public class GestionBon
    {
        public static int ajouterBon(Bon bon)
        {
            int lastInsertedId = 0;
            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO bons (date, fournisseur_nom,fournisseur_prenom,transporteur_nom,transporteur_prenom, prix_transport_unitaire, total_amount)" +
                    " VALUES (@date, @f_nom, @f_prenom, @t_nom, @t_prenom, @prix_transport_unitaire, @total_amount)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", bon.Date);
                        cmd.Parameters.AddWithValue("@f_nom", bon.fournisseur_nom);
                        cmd.Parameters.AddWithValue("@f_prenom", bon.fournisseur_prenom);
                        cmd.Parameters.AddWithValue("@t_nom", bon.transporteur_nom);
                        cmd.Parameters.AddWithValue("@t_prenom", bon.transporteur_prenom);
                        cmd.Parameters.AddWithValue("@prix_transport_unitaire", bon.prix_transport_unitaire);
                        cmd.Parameters.AddWithValue("@total_amount", bon.total_amount);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} Bon(s) ajouté(s).");

                        using (var cmdId = new SqliteCommand("SELECT last_insert_rowid()", conn))
                        {
                            lastInsertedId = Convert.ToInt32(cmdId.ExecuteScalar());
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }

                return lastInsertedId;
            }
        }



    }
}
