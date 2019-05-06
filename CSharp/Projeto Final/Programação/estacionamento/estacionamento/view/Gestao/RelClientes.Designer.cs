namespace Estacionamento.View.Gestao
{
    partial class RelClientes
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
            this.button2 = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoTodos = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpfiltro = new System.Windows.Forms.GroupBox();
            this.rdoPlano = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grpfiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(581, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AllowUserToOrderColumns = true;
            this.grd.AllowUserToResizeColumns = false;
            this.grd.AllowUserToResizeRows = false;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone,
            this.Celular,
            this.Endereco,
            this.idCliente});
            this.grd.Location = new System.Drawing.Point(12, 60);
            this.grd.Name = "grd";
            this.grd.RowHeadersVisible = false;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(644, 271);
            this.grd.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 240;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // rdoTodos
            // 
            this.rdoTodos.AutoSize = true;
            this.rdoTodos.Checked = true;
            this.rdoTodos.Location = new System.Drawing.Point(24, 16);
            this.rdoTodos.Name = "rdoTodos";
            this.rdoTodos.Size = new System.Drawing.Size(104, 17);
            this.rdoTodos.TabIndex = 7;
            this.rdoTodos.TabStop = true;
            this.rdoTodos.Text = "Todos os Planos";
            this.rdoTodos.UseVisualStyleBackColor = true;
            this.rdoTodos.CheckedChanged += new System.EventHandler(this.rdoTodos_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // grpfiltro
            // 
            this.grpfiltro.Controls.Add(this.rdoPlano);
            this.grpfiltro.Controls.Add(this.button1);
            this.grpfiltro.Controls.Add(this.rdoTodos);
            this.grpfiltro.Controls.Add(this.comboBox1);
            this.grpfiltro.Location = new System.Drawing.Point(12, 12);
            this.grpfiltro.Name = "grpfiltro";
            this.grpfiltro.Size = new System.Drawing.Size(644, 42);
            this.grpfiltro.TabIndex = 10;
            this.grpfiltro.TabStop = false;
            this.grpfiltro.Text = "Filtro";
            // 
            // rdoPlano
            // 
            this.rdoPlano.AutoSize = true;
            this.rdoPlano.Location = new System.Drawing.Point(184, 16);
            this.rdoPlano.Name = "rdoPlano";
            this.rdoPlano.Size = new System.Drawing.Size(55, 17);
            this.rdoPlano.TabIndex = 11;
            this.rdoPlano.Text = "Plano:";
            this.rdoPlano.UseVisualStyleBackColor = true;
            this.rdoPlano.CheckedChanged += new System.EventHandler(this.rdoPlano_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Location = new System.Drawing.Point(12, 346);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 25);
            this.btnExibir.TabIndex = 11;
            this.btnExibir.Text = "Histórico...";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // RelClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 383);
            this.ControlBox = false;
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.grpfiltro);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RelClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.RelClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grpfiltro.ResumeLayout(false);
            this.grpfiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.RadioButton rdoTodos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpfiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoPlano;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
    }
}