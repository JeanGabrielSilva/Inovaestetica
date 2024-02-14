using Inovaestetica.Movimento.Procedimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inovaestetica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Icon = new Icon(Path.Combine(Application.StartupPath, "INOVAESTETICA-LOGO.ico"));
            this.Text = "INOVAESTETICA";
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnProcedimentos_Click(object sender, EventArgs e)
        {
            // Limpar o conteúdo atual do Panel
            panelConteudo.Controls.Clear();

            // Criar uma nova instância do formulário de procedimentos
            FormProcedimentos formProcedimentos = new FormProcedimentos();

            // Definir o formulário de procedimentos como controle filho do Panel
            formProcedimentos.TopLevel = false;
            formProcedimentos.FormBorderStyle = FormBorderStyle.None;
            formProcedimentos.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(formProcedimentos);

            // Exibir o formulário de procedimentos
            formProcedimentos.Show();
        }
    }
}
