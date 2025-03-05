using System;
using System.IO;
using System.Data.SQLite;

namespace FinancialWizard
{
    internal class DataBank
    {
        private static string dataPath = "financialwizard.db";
        public static string stringConnection = $"Data Source={dataPath};Version=3;";

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
                CREATE TABLE IF NOT EXISTS Usuarios (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT NOT NULL,
                    email TEXT UNIQUE NOT NULL,
                    senha TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Financas (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    usuario_id INTEGER,
                    descricao TEXT NOT NULL,
                    valor REAL NOT NULL,
                    data TEXT NOT NULL,
                    categoria_id INTEGER,
                    recorrente BOOLEAN DEFAULT 0,
                    tipo TEXT CHECK(tipo IN ('Receita', 'Despesa')) NOT NULL,
                    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id),
                    FOREIGN KEY (categoria_id) REFERENCES Categorias(id)
                );

                CREATE TABLE IF NOT EXISTS Categorias (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT NOT NULL UNIQUE,
                    tipo TEXT CHECK(tipo IN ('Receita', 'Despesa')) NOT NULL
                );

                CREATE TABLE IF NOT EXISTS MetasFinanceiras (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    usuario_id INTEGER,
                    descricao TEXT NOT NULL,
                    valor REAL NOT NULL,
                    data_inicio TEXT NOT NULL,
                    data_fim TEXT NOT NULL,
                    status TEXT CHECK(status IN ('Em Andamento', 'Concluída', 'Cancelada')) NOT NULL,
                    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id)
                );
                ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Banco de dados e tabelas criadas com sucesso.");
            }
        }
    }
}
