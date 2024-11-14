namespace CRUD
{
    public partial class Employees : Form
    {
        private readonly EmployeeManager _employeeManager;
        private bool _isEditing;

        public Employees()
        {
            InitializeComponent();
            _employeeManager = new EmployeeManager();
            ConfigureInitialState();
        }

        private void ConfigureInitialState()
        {
            EnableTextBoxes(false);
            _isEditing = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            EnableTextBoxes(true);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            _isEditing = false;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields()) return;

            AssignTextBoxValuesToManager();
            bool saveSuccessful = _employeeManager.SaveOrUpdateEmployee();

            if (saveSuccessful)
            {
                string message = _isEditing ? "Registro atualizado com sucesso!" : "Registro salvo com sucesso!";
                MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFormState();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            var foundEmployee = _employeeManager.SearchEmployee(searchTerm);

            if (foundEmployee != null)
            {
                DisplayEmployeeData(foundEmployee);
                EnableTextBoxes(false);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                MessageBox.Show("Funcionário encontrado!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ResetFormState();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Selecione um funcionário para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableTextBoxes(true);
            _isEditing = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Selecione um funcionário para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmar Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            if (_employeeManager.DeleteEmployee())
            {
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFormState();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação atual?", "Confirmar Cancelamento",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetFormState();
            }
        }

        private void DisplayEmployeeData(EmployeeManager employee)
        {
           
            lblId.Text = employee.Id.ToString();
            _employeeManager.Id = employee.Id; // Atribuir o ID corretamente
            lblId.Text = employee.Id.ToString();
            txtName.Text = employee.Name;
            txtMaskPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            txtAddress.Text = employee.Address;
            txtNumber.Text = employee.Number;
            txtNeighborhood.Text = employee.Neighborhood;
            txtMaskRg.Text = employee.Rg;
            txtMaskCpf.Text = employee.Cpf;
        }

        private void EnableTextBoxes(bool enable)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBoxBase textBox)
                {
                    textBox.Enabled = textBox == txtSearch || enable;
                }
            }
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMaskCpf.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AssignTextBoxValuesToManager()
        {
            _employeeManager.Id = string.IsNullOrEmpty(lblId.Text) ? 0 : int.Parse(lblId.Text);
            _employeeManager.UpdateProperties(
                txtName.Text,
                txtMaskPhone.Text,
                txtEmail.Text,
                txtAddress.Text,
                txtNumber.Text,
                txtNeighborhood.Text,
                txtMaskRg.Text,
                txtMaskCpf.Text
            );
        }

        private void ResetFormState()
        {
            ClearAllFields();
            EnableTextBoxes(false);
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            _isEditing = false;
            lblId.Text = string.Empty;
        }

        private void ClearAllFields()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBoxBase textBox)
                {
                    textBox.Clear();
                }
            }
            lblId.Text = string.Empty;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação atual?", "Confirmar Cancelamento",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetFormState();
            }
        }
    }
}