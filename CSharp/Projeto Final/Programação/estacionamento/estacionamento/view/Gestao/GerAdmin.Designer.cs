namespace Estacionamento.View.Gestao
{
    partial class GerAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerAdmin));
            this.mTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAltAdmin = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConsultarLogin = new System.Windows.Forms.Button();
            this.txtConsultarLogin = new System.Windows.Forms.TextBox();
            this.lblLoginConsulta = new System.Windows.Forms.Label();
            this.btnApagarAdmin = new System.Windows.Forms.Button();
            this.checkAlterarAdmin = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTxtCelular
            // 
            this.mTxtCelular.Location = new System.Drawing.Point(105, 57);
            this.mTxtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtCelular.Mask = "(99) 00000-0000";
            this.mTxtCelular.Name = "mTxtCelular";
            this.mTxtCelular.Size = new System.Drawing.Size(203, 20);
            this.mTxtCelular.TabIndex = 6;
            // 
            // mTxtTelefone
            // 
            this.mTxtTelefone.Location = new System.Drawing.Point(105, 34);
            this.mTxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtTelefone.Mask = "(99) 0000-0000";
            this.mTxtTelefone.Name = "mTxtTelefone";
            this.mTxtTelefone.Size = new System.Drawing.Size(203, 20);
            this.mTxtTelefone.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(105, 150);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(203, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(9, 155);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 53;
            this.lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(105, 127);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(9, 131);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 51;
            this.lblLogin.Text = "Login";
            // 
            // btnAltAdmin
            // 
            this.btnAltAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltAdmin.Location = new System.Drawing.Point(262, 291);
            this.btnAltAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltAdmin.Name = "btnAltAdmin";
            this.btnAltAdmin.Size = new System.Drawing.Size(63, 24);
            this.btnAltAdmin.TabIndex = 14;
            this.btnAltAdmin.Text = "Ok";
            this.btnAltAdmin.UseVisualStyleBackColor = true;
            this.btnAltAdmin.Click += new System.EventHandler(this.btnAltAdmin_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(105, 104);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(203, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(9, 107);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 48;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 81);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 84);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(9, 61);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 45;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 38);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 44;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 13);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 16);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 42;
            this.lblNome.Text = "Nome";
            // 
            // btnConsultarLogin
            // 
            this.btnConsultarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarLogin.Location = new System.Drawing.Point(262, 37);
            this.btnConsultarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarLogin.Name = "btnConsultarLogin";
            this.btnConsultarLogin.Size = new System.Drawing.Size(63, 24);
            this.btnConsultarLogin.TabIndex = 2;
            this.btnConsultarLogin.Text = "Consulta";
            this.btnConsultarLogin.UseVisualStyleBackColor = true;
            this.btnConsultarLogin.Click += new System.EventHandler(this.btnConsultarLogin_Click);
            // 
            // txtConsultarLogin
            // 
            this.txtConsultarLogin.Location = new System.Drawing.Point(169, 12);
            this.txtConsultarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultarLogin.Name = "txtConsultarLogin";
            this.txtConsultarLogin.Size = new System.Drawing.Size(78, 20);
            this.txtConsultarLogin.TabIndex = 1;
            // 
            // lblLoginConsulta
            // 
            this.lblLoginConsulta.AutoSize = true;
            this.lblLoginConsulta.Location = new System.Drawing.Point(17, 15);
            this.lblLoginConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginConsulta.Name = "lblLoginConsulta";
            this.lblLoginConsulta.Size = new System.Drawing.Size(149, 13);
            this.lblLoginConsulta.TabIndex = 59;
            this.lblLoginConsulta.Text = "Digite o login do Administrador";
            // 
            // btnApagarAdmin
            // 
            this.btnApagarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarAdmin.Location = new System.Drawing.Point(187, 291);
            this.btnApagarAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarAdmin.Name = "btnApagarAdmin";
            this.btnApagarAdmin.Size = new System.Drawing.Size(63, 24);
            this.btnApagarAdmin.TabIndex = 13;
            this.btnApagarAdmin.Text = "Apaga";
            this.btnApagarAdmin.UseVisualStyleBackColor = true;
            this.btnApagarAdmin.Click += new System.EventHandler(this.btnApagarAdmin_Click);
            // 
            // checkAlterarAdmin
            // 
            this.checkAlterarAdmin.AutoSize = true;
            this.checkAlterarAdmin.Location = new System.Drawing.Point(105, 177);
            this.checkAlterarAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.checkAlterarAdmin.Name = "checkAlterarAdmin";
            this.checkAlterarAdmin.Size = new System.Drawing.Size(169, 17);
            this.checkAlterarAdmin.TabIndex = 11;
            this.checkAlterarAdmin.Text = "Alterar dados do Administrador";
            this.checkAlterarAdmin.UseVisualStyleBackColor = true;
            this.checkAlterarAdmin.CheckedChanged += new System.EventHandler(this.checkAlterarAdmin_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(184, 37);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 24);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampos.Location = new System.Drawing.Point(10, 291);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(63, 24);
            this.btnLimparCampos.TabIndex = 12;
            this.btnLimparCampos.Text = "Limpa";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkAlterarAdmin);
            this.groupBox1.Controls.Add(this.mTxtCelular);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.mTxtTelefone);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Location = new System.Drawing.Point(10, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 198);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "*";
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(18, 269);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(104, 13);
            this.lblCamposObrigatorios.TabIndex = 69;
            this.lblCamposObrigatorios.Text = "Campos Obrigatórios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "*";
            // 
            // GerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(337, 66);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagarAdmin);
            this.Controls.Add(this.btnConsultarLogin);
            this.Controls.Add(this.txtConsultarLogin);
            this.Controls.Add(this.btnAltAdmin);
            this.Controls.Add(this.lblLoginConsulta);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Admininstrador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTxtCelular;
        private System.Windows.Forms.MaskedTextBox mTxtTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAltAdmin;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultarLogin;
        private System.Windows.Forms.TextBox txtConsultarLogin;
        private System.Windows.Forms.Label lblLoginConsulta;
        private System.Windows.Forms.Button btnApagarAdmin;
        private System.Windows.Forms.CheckBox checkAlterarAdmin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}