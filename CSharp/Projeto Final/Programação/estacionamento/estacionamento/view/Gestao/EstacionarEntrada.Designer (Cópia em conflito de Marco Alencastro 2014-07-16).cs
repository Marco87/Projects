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
            this.txtVaga = new System.Windows.Forms.TextBox();
            this.lblVaga = new System.Windows.Forms.Label();
            this.lblVeículo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTipoEstacionamento = new System.Windows.Forms.Label();
            this.btnConfirmarEntrada = new System.Windows.Forms.Button();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTipoEstacionamentoCliente = new System.Windows.Forms.Label();
            this.lblDataHoraEntradaCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmitirComprovante = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.mTxtConsultar = new System.Windows.Forms.MaskedTextBox();
            this.lblVeiculoCliente = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            // txtVaga
            // 
            this.txtVaga.BackColor = System.Drawing.Color.Azure;
            this.txtVaga.Location = new System.Drawing.Point(173, 46);
            this.txtVaga.Name = "txtVaga";
            this.txtVaga.Size = new System.Drawing.Size(175, 20);
            this.txtVaga.TabIndex = 5;
            // 
            // lblVaga
            // 
            this.lblVaga.AutoSize = true;
            this.lblVaga.Location = new System.Drawing.Point(12, 49);
            this.lblVaga.Name = "lblVaga";
            this.lblVaga.Size = new System.Drawing.Size(32, 13);
            this.lblVaga.TabIndex = 4;
            this.lblVaga.Text = "Vaga";
            // 
            // lblVeículo
            // 
            this.lblVeículo.AutoSize = true;
            this.lblVeículo.Location = new System.Drawing.Point(12, 74);
            this.lblVeículo.Name = "lblVeículo";
            this.lblVeículo.Size = new System.Drawing.Size(89, 13);
            this.lblVeículo.TabIndex = 6;
            this.lblVeículo.Text = "Placa do Veículo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 99);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTipoEstacionamento
            // 
            this.lblTipoEstacionamento.AutoSize = true;
            this.lblTipoEstacionamento.Location = new System.Drawing.Point(12, 124);
            this.lblTipoEstacionamento.Name = "lblTipoEstacionamento";
            this.lblTipoEstacionamento.Size = new System.Drawing.Size(122, 13);
            this.lblTipoEstacionamento.TabIndex = 10;
            this.lblTipoEstacionamento.Text = "Tipo de Estacionamento";
            // 
            // btnConfirmarEntrada
            // 
            this.btnConfirmarEntrada.Location = new System.Drawing.Point(266, 174);
            this.btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            this.btnConfirmarEntrada.Size = new System.Drawing.Size(82, 24);
            this.btnConfirmarEntrada.TabIndex = 12;
            this.btnConfirmarEntrada.Text = "Confirma";
            this.btnConfirmarEntrada.UseVisualStyleBackColor = true;
            this.btnConfirmarEntrada.Click += new System.EventHandler(this.btnConfirmarEntrada_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(185, 13);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(82, 24);
            this.btnBuscaCliente.TabIndex = 14;
            this.btnBuscaCliente.Text = "Consulta";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(179, 104);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCliente.TabIndex = 15;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // lblTipoEstacionamentoCliente
            // 
            this.lblTipoEstacionamentoCliente.AutoSize = true;
            this.lblTipoEstacionamentoCliente.Location = new System.Drawing.Point(179, 129);
            this.lblTipoEstacionamentoCliente.Name = "lblTipoEstacionamentoCliente";
            this.lblTipoEstacionamentoCliente.Size = new System.Drawing.Size(172, 13);
            this.lblTipoEstacionamentoCliente.TabIndex = 16;
            this.lblTipoEstacionamentoCliente.Text = "Tipo de Estacionamento do Cliente";
            // 
            // lblDataHoraEntradaCliente
            // 
            this.lblDataHoraEntradaCliente.AutoSize = true;
            this.lblDataHoraEntradaCliente.Location = new System.Drawing.Point(4, 1);
            this.lblDataHoraEntradaCliente.Name = "lblDataHoraEntradaCliente";
            this.lblDataHoraEntradaCliente.Size = new System.Drawing.Size(163, 13);
            this.lblDataHoraEntradaCliente.TabIndex = 17;
            this.lblDataHoraEntradaCliente.Text = "Data/Hora de Entrada do Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmitirComprovante);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.lblTipoEstacionamentoCliente);
            this.groupBox1.Controls.Add(this.lblNomeCliente);
            this.groupBox1.Controls.Add(this.lblTipoEstacionamento);
            this.groupBox1.Controls.Add(this.btnConfirmarEntrada);
            this.groupBox1.Controls.Add(this.txtVaga);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblDataHoraEntrada);
            this.groupBox1.Controls.Add(this.lblVeículo);
            this.groupBox1.Controls.Add(this.lblVaga);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 204);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnEmitirComprovante
            // 
            this.btnEmitirComprovante.Location = new System.Drawing.Point(10, 174);
            this.btnEmitirComprovante.Name = "btnEmitirComprovante";
            this.btnEmitirComprovante.Size = new System.Drawing.Size(82, 24);
            this.btnEmitirComprovante.TabIndex = 46;
            this.btnEmitirComprovante.Text = "Comprovante";
            this.btnEmitirComprovante.UseVisualStyleBackColor = true;
            this.btnEmitirComprovante.Click += new System.EventHandler(this.btnEmitirComprovante_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblDataHoraEntradaCliente);
            this.panel6.Location = new System.Drawing.Point(173, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 22);
            this.panel6.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(10, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 22);
            this.panel2.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(10, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 22);
            this.panel5.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(10, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 22);
            this.panel4.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(10, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 22);
            this.panel3.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(10, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 22);
            this.panel1.TabIndex = 56;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(281, 13);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 24);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Retorna";
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
            this.mTxtConsultar.TabIndex = 45;
            // 
            // lblVeiculoCliente
            // 
            this.lblVeiculoCliente.AutoSize = true;
            this.lblVeiculoCliente.Location = new System.Drawing.Point(3, 3);
            this.lblVeiculoCliente.Name = "lblVeiculoCliente";
            this.lblVeiculoCliente.Size = new System.Drawing.Size(94, 13);
            this.lblVeiculoCliente.TabIndex = 14;
            this.lblVeiculoCliente.Text = "Veículo do Cliente";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblVeiculoCliente);
            this.panel7.Location = new System.Drawing.Point(173, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 22);
            this.panel7.TabIndex = 61;
            // 
            // EstacionarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(392, 262);
            this.Controls.Add(this.mTxtConsultar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.lblPesquisarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EstacionarEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada no Estacionamento";
            this.Load += new System.EventHandler(this.EstacionarEntrada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisarCliente;
        private System.Windows.Forms.Label lblDataHoraEntrada;
        private System.Windows.Forms.TextBox txtVaga;
        private System.Windows.Forms.Label lblVaga;
        private System.Windows.Forms.Label lblVeículo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoEstacionamento;
        private System.Windows.Forms.Button btnConfirmarEntrada;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTipoEstacionamentoCliente;
        private System.Windows.Forms.Label lblDataHoraEntradaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mTxtConsultar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEmitirComprovante;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblVeiculoCliente;
    }
}