namespace ControleComissoes.Views.GerenciarPlano
{
    partial class InserirPlanoComissao
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
            this.comboInserirPlanoComis = new System.Windows.Forms.ComboBox();
            this.btnCadastroPlanoComissao = new System.Windows.Forms.Button();
            this.txtFFinalComis = new System.Windows.Forms.TextBox();
            this.lblFFinalComis = new System.Windows.Forms.Label();
            this.txtFIniComis = new System.Windows.Forms.TextBox();
            this.lblFIniComis = new System.Windows.Forms.Label();
            this.txtComissaoComis = new System.Windows.Forms.TextBox();
            this.lblComissaoComis = new System.Windows.Forms.Label();
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboInserirPlanoComis
            // 
            this.comboInserirPlanoComis.FormattingEnabled = true;
            this.comboInserirPlanoComis.Location = new System.Drawing.Point(89, 25);
            this.comboInserirPlanoComis.Name = "comboInserirPlanoComis";
            this.comboInserirPlanoComis.Size = new System.Drawing.Size(127, 21);
            this.comboInserirPlanoComis.TabIndex = 44;
            // 
            // btnCadastroPlanoComissao
            // 
            this.btnCadastroPlanoComissao.Location = new System.Drawing.Point(89, 157);
            this.btnCadastroPlanoComissao.Name = "btnCadastroPlanoComissao";
            this.btnCadastroPlanoComissao.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPlanoComissao.TabIndex = 43;
            this.btnCadastroPlanoComissao.Text = "Ok";
            this.btnCadastroPlanoComissao.UseVisualStyleBackColor = true;
            this.btnCadastroPlanoComissao.Click += new System.EventHandler(this.btnCadastroPlanoComissao_Click);
            // 
            // txtFFinalComis
            // 
            this.txtFFinalComis.Location = new System.Drawing.Point(89, 131);
            this.txtFFinalComis.Name = "txtFFinalComis";
            this.txtFFinalComis.Size = new System.Drawing.Size(127, 20);
            this.txtFFinalComis.TabIndex = 42;
            // 
            // lblFFinalComis
            // 
            this.lblFFinalComis.AutoSize = true;
            this.lblFFinalComis.Location = new System.Drawing.Point(26, 138);
            this.lblFFinalComis.Name = "lblFFinalComis";
            this.lblFFinalComis.Size = new System.Drawing.Size(54, 13);
            this.lblFFinalComis.TabIndex = 41;
            this.lblFFinalComis.Text = "Faixa final";
            // 
            // txtFIniComis
            // 
            this.txtFIniComis.Location = new System.Drawing.Point(89, 105);
            this.txtFIniComis.Name = "txtFIniComis";
            this.txtFIniComis.Size = new System.Drawing.Size(127, 20);
            this.txtFIniComis.TabIndex = 40;
            // 
            // lblFIniComis
            // 
            this.lblFIniComis.AutoSize = true;
            this.lblFIniComis.Location = new System.Drawing.Point(19, 112);
            this.lblFIniComis.Name = "lblFIniComis";
            this.lblFIniComis.Size = new System.Drawing.Size(61, 13);
            this.lblFIniComis.TabIndex = 39;
            this.lblFIniComis.Text = "Faixa inicial";
            // 
            // txtComissaoComis
            // 
            this.txtComissaoComis.Location = new System.Drawing.Point(89, 79);
            this.txtComissaoComis.Name = "txtComissaoComis";
            this.txtComissaoComis.Size = new System.Drawing.Size(127, 20);
            this.txtComissaoComis.TabIndex = 38;
            // 
            // lblComissaoComis
            // 
            this.lblComissaoComis.AutoSize = true;
            this.lblComissaoComis.Location = new System.Drawing.Point(28, 86);
            this.lblComissaoComis.Name = "lblComissaoComis";
            this.lblComissaoComis.Size = new System.Drawing.Size(52, 13);
            this.lblComissaoComis.TabIndex = 37;
            this.lblComissaoComis.Text = "Comissão";
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Location = new System.Drawing.Point(89, 52);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(127, 21);
            this.comboTipoCliente.TabIndex = 45;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(6, 60);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(77, 13);
            this.lblTipoCliente.TabIndex = 46;
            this.lblTipoCliente.Text = "Tipo de cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InserirPlanoComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.comboTipoCliente);
            this.Controls.Add(this.comboInserirPlanoComis);
            this.Controls.Add(this.btnCadastroPlanoComissao);
            this.Controls.Add(this.txtFFinalComis);
            this.Controls.Add(this.lblFFinalComis);
            this.Controls.Add(this.txtFIniComis);
            this.Controls.Add(this.lblFIniComis);
            this.Controls.Add(this.txtComissaoComis);
            this.Controls.Add(this.lblComissaoComis);
            this.Name = "InserirPlanoComissao";
            this.Text = "InserirPlanoComissao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboInserirPlanoComis;
        private System.Windows.Forms.Button btnCadastroPlanoComissao;
        private System.Windows.Forms.TextBox txtFFinalComis;
        private System.Windows.Forms.Label lblFFinalComis;
        private System.Windows.Forms.TextBox txtFIniComis;
        private System.Windows.Forms.Label lblFIniComis;
        private System.Windows.Forms.TextBox txtComissaoComis;
        private System.Windows.Forms.Label lblComissaoComis;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Button button1;
    }
}