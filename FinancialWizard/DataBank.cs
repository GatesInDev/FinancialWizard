using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FinancialWizard
{
    internal class DataBank
    {
        private static string dataPath = "financialwizard.db";
        private static string stringConnection = $"Data Source={dataPath};Version=3;";

        public static void CreateBank()
        {
            if (!File.Exists(dataPath))
            {
                SQLiteConnection.CreateFile(dataPath);
                Console.WriteLine("Banco de dados criado com sucesso.");
            }

            using (SQLiteConnection conn = new SQLiteConnection(stringConnection))
            {
                conn.Open();
                string query = @"
                CREATE TABLE IF NOT EXISTS Financas (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    description TEXT,
                    value REAL,
                    data TEXT
                )";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tabela verificada/criada com sucesso.");
            }
        }
    }
}
