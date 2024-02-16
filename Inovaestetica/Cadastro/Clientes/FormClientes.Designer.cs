namespace Inovaestetica.Cadastro.Clientes
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inovaesteticaDataSet1 = new Inovaestetica.InovaesteticaDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeClientes = new System.Windows.Forms.Button();
            this.btnModalAddCliente = new System.Windows.Forms.Button();
            this.clienteTableAdapter1 = new Inovaestetica.InovaesteticaDataSet1TableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inovaesteticaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.inovaesteticaDataSet1;
            // 
            // inovaesteticaDataSet1
            // 
            this.inovaesteticaDataSet1.DataSetName = "InovaesteticaDataSet1";
            this.inovaesteticaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 539);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sobrenomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.apelidoDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            this.clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // sobrenomeDataGridViewTextBoxColumn
            // 
            this.sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            this.apelidoDataGridViewTextBoxColumn.DataPropertyName = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.inovaesteticaDataSet1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.closeClientes);
            this.panel3.Controls.Add(this.btnModalAddCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 57);
            this.panel3.TabIndex = 2;
            // 
            // closeClientes
            // 
            this.closeClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeClientes.Location = new System.Drawing.Point(0, 0);
            this.closeClientes.Name = "closeClientes";
            this.closeClientes.Size = new System.Drawing.Size(168, 57);
            this.closeClientes.TabIndex = 1;
            this.closeClientes.Text = "Fechar";
            this.closeClientes.UseVisualStyleBackColor = false;
            this.closeClientes.Click += new System.EventHandler(this.closeClientes_Click);
            // 
            // btnModalAddCliente
            // 
            this.btnModalAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModalAddCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModalAddCliente.Location = new System.Drawing.Point(924, 0);
            this.btnModalAddCliente.Name = "btnModalAddCliente";
            this.btnModalAddCliente.Size = new System.Drawing.Size(168, 57);
            this.btnModalAddCliente.TabIndex = 0;
            this.btnModalAddCliente.Text = "Adicionar Cliente";
            this.btnModalAddCliente.UseVisualStyleBackColor = false;
            this.btnModalAddCliente.Click += new System.EventHandler(this.btnModalAddCliente_Click);
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 539);
            this.Controls.Add(this.panel1);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inovaesteticaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InovaesteticaDataSet1 inovaesteticaDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private InovaesteticaDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModalAddCliente;
        private System.Windows.Forms.Button closeClientes;
    }
}