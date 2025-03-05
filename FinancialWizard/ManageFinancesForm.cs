using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialWizard
{
    public partial class ManageFinancesForm : Form
    {
        public ManageFinancesForm()
        {
            InitializeComponent();
        }
        private void ManageFinancesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void rbtnIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void LoadFinances()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DataBank.stringConnection))
            {
                conn.Open();
                string query = "SELECT id, description AS 'Description', value AS 'Value', date AS 'Date' FROM Finances";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFinances.DataSource = dt; // Define os dados na tabela
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            double value;

            if (double.TryParse(txtValue.Text, out value))
            {
                // Se for despesa, multiplica por -1
                if (rbtnExpense.Checked)
                {
                    value *= -1;
                }

                string date = DateTime.Now.ToString("yyyy-MM-dd");

                using (SQLiteConnection conn = new SQLiteConnection(DataBank.stringConnection))
                {
                    conn.Open();
                    string query = "INSERT INTO Finances (description, value, date) VALUES (@desc, @value, @date)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@value", value);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
