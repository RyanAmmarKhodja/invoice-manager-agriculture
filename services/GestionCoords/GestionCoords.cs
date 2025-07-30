using Microsoft.Data.Sqlite;
using StockIt_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.services.GestionCoords
{
    public class GestionCoords
    {
        public bool editCoords(Coords updatedCoords)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE coordonnees SET tel=@tel, email=@email, rc = @rc, adresse = @adresse, ai = @ai, nif = @nif, nis = @nis WHERE id = 1";

                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@adresse", updatedCoords.adresse ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@tel", updatedCoords.tel ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", updatedCoords.email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ai", updatedCoords.ai ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nif", updatedCoords.nif ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nis", updatedCoords.nis ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@rc", updatedCoords.rc ?? (object)DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // True if one or more rows were updated
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error updating coordinates: " + e.Message);
                    return false;
                }
            }
        }


        public Coords GetCoords()
        {
            Coords coords = new Coords();

            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM coordonnees";

                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coords.id = reader.GetInt32(0); // Column index 0: id
                            coords.tel = reader.GetString(1); // Column index 0: rc
                            coords.email = reader.GetString(2); // Column index 0: rc
                            coords.rc = reader.GetString(3); // Column index 0: rc
                            coords.adresse = reader.GetString(4); // Column index 1: adresse
                            coords.ai = reader.GetString(5); // Column index 2: ai
                            coords.nif = reader.GetString(6); // Column index 3: nif
                            coords.nis = reader.GetString(7); // Column index 4: nis
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
                return coords;

            }
        }
    }
}
