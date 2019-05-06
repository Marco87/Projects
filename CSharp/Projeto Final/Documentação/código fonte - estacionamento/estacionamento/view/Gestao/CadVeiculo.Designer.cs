namespace Estacionamento.View.Gestao
{
    partial class CadVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVeiculo));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbTipoPlano = new System.Windows.Forms.ComboBox();
            this.lblTipoPlano = new System.Windows.Forms.Label();
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.mTxtAno = new System.Windows.Forms.MaskedTextBox();
            this.mTxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(95, 122);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCliente.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 127);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(6, 104);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(39, 13);
            this.lblPlaca.TabIndex = 20;
            this.lblPlaca.Text = "Placa";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(7, 84);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 18;
            this.lblAno.Text = "Ano";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 54);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(203, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(6, 60);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(95, 31);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(203, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(6, 36);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 14;
            this.lblModelo.Text = "Modelo";
            // 
            // cbTipoPlano
            // 
            this.cbTipoPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlano.FormattingEnabled = true;
            this.cbTipoPlano.Location = new System.Drawing.Point(95, 7);
            this.cbTipoPlano.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoPlano.Name = "cbTipoPlano";
            this.cbTipoPlano.Size = new System.Drawing.Size(203, 21);
            this.cbTipoPlano.TabIndex = 1;
            // 
            // lblTipoPlano
            // 
            this.lblTipoPlano.AutoSize = true;
            this.lblTipoPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlano.Location = new System.Drawing.Point(6, 11);
            this.lblTipoPlano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPlano.Name = "lblTipoPlano";
            this.lblTipoPlano.Size = new System.Drawing.Size(86, 13);
            this.lblTipoPlano.TabIndex = 12;
            this.lblTipoPlano.Text = "Tipo de Plano";
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVeiculo.Location = new System.Drawing.Point(252, 185);
            this.btnCadVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(58, 24);
            this.btnCadVeiculo.TabIndex = 9;
            this.btnCadVeiculo.Text = "Ok";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // mTxtAno
            // 
            this.mTxtAno.Location = new System.Drawing.Point(95, 77);
            this.mTxtAno.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtAno.Mask = "9999";
            this.mTxtAno.Name = "mTxtAno";
            this.mTxtAno.PromptChar = ' ';
            this.mTxtAno.Size = new System.Drawing.Size(203, 20);
            this.mTxtAno.TabIndex = 4;
            // 
            // mTxtPlaca
            // 
            this.mTxtPlaca.Location = new System.Drawing.Point(94, 99);
            this.mTxtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtPlaca.Mask = "???-0000";
            this.mTxtPlaca.Name = "mTxtPlaca";
            this.mTxtPlaca.PromptChar = ' ';
            this.mTxtPlaca.Size = new System.Drawing.Size(203, 20);
            this.mTxtPlaca.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(180, 185);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 24);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(4, 186);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(63, 24);
            this.btnLimparCampos.TabIndex = 7;
            this.btnLimparCampos.Text = "Limpa";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(16, 164);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(104, 13);
            this.lblCamposObrigatorios.TabIndex = 59;
            this.lblCamposObrigatorios.Text = "Campos Obrigatórios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mTxtPlaca);
            this.panel1.Controls.Add(this.mTxtAno);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblPlaca);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.cbTipoPlano);
            this.panel1.Controls.Add(this.lblTipoPlano);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 149);
            this.panel1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-1, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "*";
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(320, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadVeiculo";
            this.Text = "Cadastro de Veículo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbTipoPlano;
        private System.Windows.Forms.Label lblTipoPlano;
        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.MaskedTextBox mTxtAno;
        private System.Windows.Forms.MaskedTextBox mTxtPlaca;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}