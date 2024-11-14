namespace CRUD
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Adiciona o evento Load para verificar a conexão com o banco de dados quando o formulário é carregado
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees empWindow = new Employees();
            empWindow.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento Load do formulário principal
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Chama o método que verifica a conexão com o banco de dados quando o formulário é carregado
        }

        // Método para verificar a conexão com o banco de dados

    }
}
