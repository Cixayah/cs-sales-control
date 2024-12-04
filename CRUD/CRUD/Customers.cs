using DatabaseManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
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

                    string query = "SELECT name, cpf FROM employee"; // Adjust column names as needed
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewCustomers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}