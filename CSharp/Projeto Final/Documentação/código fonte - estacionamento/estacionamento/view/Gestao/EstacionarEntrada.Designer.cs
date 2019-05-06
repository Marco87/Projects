namespace Estacionamento.View.Gestao
{
    partial class EstacionarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstacionarEntrada));
            this.lblPesquisarCliente = new System.Windows.Forms.Label();
            this.lblDataHoraEntrada = new System.Windows.Forms.Label();
            this.lblVaga = new System.Windows.Forms.Label();
            this.lblVeículo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTipoEstacionamento = new System.Windows.Forms.Label();
            this.btnConfirmarEntrada = new System.Windows.Forms.Button();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTipoEstacionamentoCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataHoraEntradaCliente = new System.Windows.Forms.Label();
            this.lblVeiculoCliente = new System.Windows.Forms.Label();
            this.btnSelecionarVaga = new System.Windows.Forms.Button();
            this.lblVagaCliente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.mTxtConsultar = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPesquisarCliente
            // 
            this.lblPesquisarCliente.AutoSize = true;
            this.lblPesquisarCliente.Location = new System.Drawing.Point(26, 19);
            this.lblPesquisarCliente.Name = "lblPesquisarCliente";
            this.lblPesquisarCliente.Size = new System.Drawing.Size(37, 13);
            this.lblPesquisarCliente.TabIndex = 0;
            this.lblPesquisarCliente.Text = "Placa:";
            // 
            // lblDataHoraEntrada
            // 
            this.lblDataHoraEntrada.AutoSize = true;
            this.lblDataHoraEntrada.Location = new System.Drawing.Point(12, 24);
            this.lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            this.lblDataHoraEntrada.Size = new System.Drawing.Size(113, 13);
            this.lblDataHoraEntrada.TabIndex = 2;
            this.lblDataHoraEntrada.Text = "Data/Hora da Entrada";
            // 
            // lblVaga
            // 
            this.lblVaga.AutoSize = true;
            this.lblVaga.Location = new System.Drawing.Point(12, 124);
            this.lblVaga.Name = "lblVaga";
            this.lblVaga.Size = new System.Drawing.Size(32, 13);
            this.lblVaga.TabIndex = 4;
            this.lblVaga.Text = "Vaga";
            // 
            // lblVeículo
            // 
            this.lblVeículo.AutoSize = true;
            this.lblVeículo.Location = new System.Drawing.Point(12, 49);
            this.lblVeículo.Name = "lblVeículo";
            this.lblVeículo.Size = new System.Drawing.Size(89, 13);
            this.lblVeículo.TabIndex = 6;
            this.lblVeículo.Text = "Placa do Veículo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 74);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTipoEstacionamento
            // 
            this.lblTipoEstacionamento.AutoSize = true;
            this.lblTipoEstacionamento.Location = new System.Drawing.Point(12, 99);
            this.lblTipoEstacionamento.Name = "lblTipoEstacionamento";
            this.lblTipoEstacionamento.Size = new System.Drawing.Size(122, 13);
            this.lblTipoEstacionamento.TabIndex = 10;
            this.lblTipoEstacionamento.Text = "Tipo de Estacionamento";
            // 
            // btnConfirmarEntrada
            // 
            this.btnConfirmarEntrada.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConfirmarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEntrada.Location = new System.Drawing.Point(266, 153);
            this.btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            this.btnConfirmarEntrada.Size = new System.Drawing.Size(82, 24);
            this.btnConfirmarEntrada.TabIndex = 5;
            this.btnConfirmarEntrada.Text = "Confirma";
            this.btnConfirmarEntrada.UseVisualStyleBackColor = false;
            this.btnConfirmarEntrada.Click += new System.EventHandler(this.btnConfirmarEntrada_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCliente.Location = new System.Drawing.Point(185, 13);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(82, 24);
            this.btnBuscaCliente.TabIndex = 2;
            this.btnBuscaCliente.Text = "Consulta";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(177, 76);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCliente.TabIndex = 15;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // lblTipoEstacionamentoCliente
            // 
            this.lblTipoEstacionamentoCliente.AutoSize = true;
            this.lblTipoEstacionamentoCliente.Location = new System.Drawing.Point(177, 101);
            this.lblTipoEstacionamentoCliente.Name = "lblTipoEstacionamentoCliente";
            this.lblTipoEstacionamentoCliente.Size = new System.Drawing.Size(172, 13);
            this.lblTipoEstacionamentoCliente.TabIndex = 16;
            this.lblTipoEstacionamentoCliente.Text = "Tipo de Estacionamento do Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblDataHoraEntradaCliente);
            this.groupBox1.Controls.Add(this.lblVeiculoCliente);
            this.groupBox1.Controls.Add(this.btnSelecionarVaga);
            this.groupBox1.Controls.Add(this.lblVagaCliente);
            this.groupBox1.Controls.Add(this.lblTipoEstacionamentoCliente);
            this.groupBox1.Controls.Add(this.lblNomeCliente);
            this.groupBox1.Controls.Add(this.lblTipoEstacionamento);
            this.groupBox1.Controls.Add(this.btnConfirmarEntrada);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblDataHoraEntrada);
            this.groupBox1.Controls.Add(this.lblVeículo);
            this.groupBox1.Controls.Add(this.lblVaga);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 189);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblDataHoraEntradaCliente
            // 
            this.lblDataHoraEntradaCliente.AutoSize = true;
            this.lblDataHoraEntradaCliente.Location = new System.Drawing.Point(179, 24);
            this.lblDataHoraEntradaCliente.Name = "lblDataHoraEntradaCliente";
            this.lblDataHoraEntradaCliente.Size = new System.Drawing.Size(163, 13);
            this.lblDataHoraEntradaCliente.TabIndex = 17;
            this.lblDataHoraEntradaCliente.Text = "Data/Hora de Entrada do Cliente";
            // 
            // lblVeiculoCliente
            // 
            this.lblVeiculoCliente.AutoSize = true;
            this.lblVeiculoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVeiculoCliente.Location = new System.Drawing.Point(180, 49);
            this.lblVeiculoCliente.Name = "lblVeiculoCliente";
            this.lblVeiculoCliente.Size = new System.Drawing.Size(96, 15);
            this.lblVeiculoCliente.TabIndex = 14;
            this.lblVeiculoCliente.Text = "Veículo do Cliente";
            // 
            // btnSelecionarVaga
            // 
            this.btnSelecionarVaga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSelecionarVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarVaga.Location = new System.Drawing.Point(173, 153);
            this.btnSelecionarVaga.Name = "btnSelecionarVaga";
            this.btnSelecionarVaga.Size = new System.Drawing.Size(82, 24);
            this.btnSelecionarVaga.TabIndex = 4;
            this.btnSelecionarVaga.Text = "Selecionar";
            this.btnSelecionarVaga.UseVisualStyleBackColor = false;
            this.btnSelecionarVaga.Click += new System.EventHandler(this.btnSelecionarVaga_Click);
            // 
            // lblVagaCliente
            // 
            this.lblVagaCliente.AutoSize = true;
            this.lblVagaCliente.Location = new System.Drawing.Point(179, 124);
            this.lblVagaCliente.Name = "lblVagaCliente";
            this.lblVagaCliente.Size = new System.Drawing.Size(32, 13);
            this.lblVagaCliente.TabIndex = 64;
            this.lblVagaCliente.Text = "Vaga";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(281, 13);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 24);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mTxtConsultar
            // 
            this.mTxtConsultar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mTxtConsultar.Location = new System.Drawing.Point(80, 16);
            this.mTxtConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtConsultar.Mask = "???-0000";
            this.mTxtConsultar.Name = "mTxtConsultar";
            this.mTxtConsultar.PromptChar = ' ';
            this.mTxtConsultar.Size = new System.Drawing.Size(72, 20);
            this.mTxtConsultar.SkipLiterals = false;
            this.mTxtConsultar.TabIndex = 1;
            this.mTxtConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtConsultar_KeyPress);
            // 
            // EstacionarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 42);
            this.Controls.Add(this.mTxtConsultar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.lblPesquisarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstacionarEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada no Estacionamento";
            this.Load += new System.EventHandler(this.EstacionarEntrada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisarCliente;
        private System.Windows.Forms.Label lblDataHoraEntrada;
        private System.Windows.Forms.Label lblVaga;
        private System.Windows.Forms.Label lblVeículo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoEstacionamento;
        private System.Windows.Forms.Button btnConfirmarEntrada;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTipoEstacionamentoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mTxtConsultar;
        private System.Windows.Forms.Button btnSelecionarVaga;
        private System.Windows.Forms.Label lblVagaCliente;
        private System.Windows.Forms.Label lblDataHoraEntradaCliente;
        private System.Windows.Forms.Label lblVeiculoCliente;
    }
}