using DatabaseManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing; // Adicione este namespace para trabalhar com cores
using System.Windows.Forms;

namespace CRUD
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ApplyDraculaTheme(); // Aplica o tema Dracula no DataGridView
        }

        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomersFromDatabase();
        }

        private void LoadCustomersFromDatabase()
        {
            try
            {
                using (var connection = new MySqlConnection(DatabaseConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name as Nome, cpf as CPF FROM employee";
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewCustomers.DataSource = dt;
                    }
                    connection.Close(); // Fechamento explícito da conexão
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDraculaTheme()
        {
            // Configuração do fundo
            dataGridViewCustomers.BackgroundColor = Color.FromArgb(40, 42, 54);
            dataGridViewCustomers.DefaultCellStyle.BackColor = Color.FromArgb(40, 42, 54);
            dataGridViewCustomers.DefaultCellStyle.ForeColor = Color.FromArgb(248, 248, 242);
            dataGridViewCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(68, 71, 90);
            dataGridViewCustomers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(248, 248, 242);

            // Configuração da fonte
            dataGridViewCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Configuração do cabeçalho
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(68, 71, 90);
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(248, 248, 242);
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(68, 71, 90);
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(248, 248, 242);

            // Bordas e linhas
            dataGridViewCustomers.GridColor = Color.FromArgb(68, 71, 90);
            dataGridViewCustomers.EnableHeadersVisualStyles = false; // Necessário para personalizar o cabeçalho
            dataGridViewCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCustomers.RowHeadersVisible = false; // Esconde a coluna de cabeçalho das linhas
        }
    }
}
