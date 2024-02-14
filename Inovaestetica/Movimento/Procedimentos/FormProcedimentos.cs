using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inovaestetica.Movimento.Procedimentos
{

    public partial class FormProcedimentos : Form
    {
        private Home formHome;

        public FormProcedimentos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Fechar o formulário de procedimentos
            this.Close();

            // Verificar se a instância do formulário home já foi criada e está visível
            if (formHome == null || formHome.IsDisposed || !formHome.Visible)
            {
                // Criar uma nova instância do formulário home
                formHome = new Home();
            }

            // Exibir o formulário home novamente
            formHome.Show();
            formHome.Focus(); // Garantir que o formulário home esteja em foco
        }
    }
}
