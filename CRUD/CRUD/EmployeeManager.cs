using DatabaseManager;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CRUD
{
    internal class EmployeeManager
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }

        public EmployeeManager()
        {
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Number = string.Empty;
            Neighborhood = string.Empty;
            Rg = string.Empty;
            Cpf = string.Empty;
            ResetProperties();
        }

        public void UpdateProperties(string name, string phone, string email, string address,
            string number, string neighborhood, string rg, string cpf)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Number = number;
            Neighborhood = neighborhood;
            Rg = rg;
            Cpf = cpf;
        }

        private void ResetProperties()
        {
            Id = 0;
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Number = string.Empty;
            Neighborhood = string.Empty;
            Rg = string.Empty;
            Cpf = string.Empty;
        }

        private bool ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using var conn = GetMySqlConnection();
                conn.Open();
                using var sqlCommand = CreateMySqlCommand(query, conn, parameters);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro no banco de dados: {ex.Message}", "Erro de Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private MySqlConnection GetMySqlConnection() =>
            new MySqlConnection(DatabaseConnection.ConnectionString);

        private MySqlCommand CreateMySqlCommand(string query, MySqlConnection conn, params MySqlParameter[] parameters)
        {
            var command = conn.CreateCommand();
            command.CommandText = query;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            return command;
        }

        public bool SaveOrUpdateEmployee()
        {
            if (!ValidateEmployeeData())
                return false;

            return Id > 0 ? UpdateEmployee() : SaveNewEmployee();
        }

        private bool SaveNewEmployee()
        {
            const string insertQuery = @"
                INSERT INTO employee (name, phone, email, address, number, neighborhood, rg, cpf)
                VALUES (@name, @phone, @Email, @address, @number, @neighborhood, @rg, @cpf)";

            return ExecuteNonQuery(insertQuery, CreateEmployeeParameters());
        }

        private bool UpdateEmployee()
        {
            const string updateQuery = @"
                UPDATE employee 
                SET name = @name, phone = @phone, email = @Email,
                    address = @address, number = @number, neighborhood = @neighborhood,
                    rg = @rg, cpf = @cpf 
                WHERE id = @id";

            var parameters = CreateEmployeeParameters();
            Array.Resize(ref parameters, parameters.Length + 1);
            parameters[parameters.Length - 1] = new MySqlParameter("@id", Id);

            return ExecuteNonQuery(updateQuery, parameters);
        }

        private MySqlParameter[] CreateEmployeeParameters()
        {
            return new MySqlParameter[]
            {
                new("@name", Name),
                new("@phone", Phone),
                new("@Email", Email),
                new("@address", Address),
                new("@number", Number),
                new("@neighborhood", Neighborhood),
                new("@rg", Rg),
                new("@cpf", Cpf)
            };
        }

        public EmployeeManager? SearchEmployee(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Digite um termo para pesquisa!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                using var conn = GetMySqlConnection();
                conn.Open();

                const string select = @"
            SELECT Id, name, phone, email, address, number, neighborhood, rg, cpf
            FROM employee 
            WHERE name LIKE @searchName 
               OR id = @searchId 
               OR REPLACE(REPLACE(REPLACE(cpf, '.', ''), '-', ''), ' ', '') LIKE @searchCpf";

                // Verifica se o termo de busca pode ser convertido para inteiro (ID)
                int parsedId = -1;
                bool isNumeric = int.TryParse(searchTerm, out parsedId);

                // Remove os caracteres de formatação do CPF digitado pelo usuário
                string cleanedCpf = searchTerm.Replace(".", "").Replace("-", "").Replace(" ", "");

                using var sqlCommand = CreateMySqlCommand(select, conn,
                    new MySqlParameter("@searchName", $"%{searchTerm}%"),
                    new MySqlParameter("@searchId", isNumeric ? parsedId : -1),
                    new MySqlParameter("@searchCpf", $"%{cleanedCpf}%")); // Busca CPF sem formatação

                using var reader = sqlCommand.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Funcionário não encontrado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

                reader.Read();
                var employee = new EmployeeManager();
                employee.Id = Convert.ToInt32(reader["Id"]);
                employee.UpdateProperties(
                    reader["name"]?.ToString() ?? string.Empty,
                    reader["phone"]?.ToString() ?? string.Empty,
                    reader["email"]?.ToString() ?? string.Empty,
                    reader["address"]?.ToString() ?? string.Empty,
                    reader["number"]?.ToString() ?? string.Empty,
                    reader["neighborhood"]?.ToString() ?? string.Empty,
                    reader["rg"]?.ToString() ?? string.Empty,
                    reader["cpf"]?.ToString() ?? string.Empty
                );
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na busca do funcionário: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public bool DeleteEmployee()
        {
            if (Id <= 0)
            {
                MessageBox.Show("Nenhum funcionário selecionado para exclusão.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            const string deleteQuery = "DELETE FROM employee WHERE id = @id";
            return ExecuteNonQuery(deleteQuery, new MySqlParameter("@id", Id));
        }

        private bool ValidateEmployeeData()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("O nome do funcionário é obrigatório!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Cpf))
            {
                MessageBox.Show("O CPF do funcionário é obrigatório!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("O email do funcionário é obrigatório!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}