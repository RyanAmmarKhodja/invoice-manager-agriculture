using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models.GestionTransporteurs
{
    public class GestionTransporteurs
    {
        public static void ajouterTransporteur(string nom, string prenom, string adresse, string matricule, string tel)
        {
            using (var conn = Db.GetConnection())
            {
                string query = "INSERT INTO transporteurs (nom, prenom, adresse, matricule, tel)" +
                    " VALUES (@nom, @prenom, @adresse, @matricule, @tel)";
                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@adresse", adresse);
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rows} transporteurs(s) ajouté(s).");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }

        public List<Transporteur> GetTransporteurs()
        {
            var transporteurs = new List<Transporteur>();


            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transporteurs";


                try
                {
                    using (var cmd = new SqliteCommand(query, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transporteur = new Transporteur
                            {
                                id = reader.GetInt32(0),           // Column index 0: id
                                nom = reader.GetString(1),        // Column index 1: name
                                prenom = reader.GetString(2),
                                adresse = reader.GetString(3),
                                matricule = reader.GetString(4),
                                tel = reader.GetString(5)
                            };
                            transporteurs.Add(transporteur);
                        }
                    }
                    return transporteurs;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error : " + e.Message);
                    return new List<Transporteur>();
                }
            }
        }
    }
}
