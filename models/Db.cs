using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_2.models
{
    public static class Db
    {

        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "models", "data.db");

        public static SqliteConnection GetConnection()
        {
            
            var conn = new SqliteConnection($"Data Source=data.db");
            conn.Open();
            return conn;
        }

        public static void Initialize()
        {

            Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!); // Create folder if not exists
            using (var conn = GetConnection())
            {
                var command = conn.CreateCommand();
                command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS testing (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    field TEXT
                );
            ";
                command.ExecuteNonQuery();
            }
        }
    }
}
