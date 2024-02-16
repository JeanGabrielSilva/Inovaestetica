using Inovaestetica.Cadastro.Clientes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inovaestetica.Movimento.Procedimentos
{
    public partial class ModalAddCliente : Form
    {
        public ModalAddCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            string nome = nomeCliente.Text;
            string sobrenome = sobrenomeCliente.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                AdicionarClienteAoBanco(nome, sobrenome);
                MessageBox.Show("Cliente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarrega os dados na DataGridView do formulário FormClientes
                FormClientes formClientes = Application.OpenForms["FormClientes"] as FormClientes;
                if (formClientes != null)
                {
                    formClientes.RefreshData();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarClienteAoBanco(string nome, string sobrenome)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Inovaestetica\Inovaestetica\Inovaestetica.mdf;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente (Nome, Sobrenome) VALUES (@Nome, @Sobrenome)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Sobrenome", sobrenome);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
