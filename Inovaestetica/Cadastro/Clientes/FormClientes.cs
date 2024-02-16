using Inovaestetica.Movimento.Procedimentos;
using System;
using System.Windows.Forms;

namespace Inovaestetica.Cadastro.Clientes
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'inovaesteticaDataSet1.Cliente'.
            this.clienteTableAdapter1.Fill(this.inovaesteticaDataSet1.Cliente);
        }

        private void closeClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para recarregar os dados na DataGridView
        public void RefreshData()
        {
            this.clienteTableAdapter1.Fill(this.inovaesteticaDataSet1.Cliente);
        }

        private void btnModalAddCliente_Click(object sender, EventArgs e)
        {
            ModalAddCliente modalAddCliente = new ModalAddCliente();

            // Exiba o modal como um diálogo modal
            modalAddCliente.ShowDialog();
        }
    }
}
