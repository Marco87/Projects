namespace ControleComissoes.Views
{
    partial class TelasVendedor
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
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.lblParteAdministrativa = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInserirPF = new System.Windows.Forms.Button();
            this.btnGerPF = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnInserirPJ = new System.Windows.Forms.Button();
            this.btnGerPJ = new System.Windows.Forms.Button();
            this.btnRelVendaPF = new System.Windows.Forms.Button();
            this.btnRelVendaPJ = new System.Windows.Forms.Button();
            this.btnRelItensVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(54, 266);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(75, 13);
            this.lblVenda.TabIndex = 25;
            this.lblVenda.Text = "Efetuar Venda";
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Location = new System.Drawing.Point(397, 11);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(54, 13);
            this.lblRelatorios.TabIndex = 23;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // lblParteAdministrativa
            // 
            this.lblParteAdministrativa.AutoSize = true;
            this.lblParteAdministrativa.Location = new System.Drawing.Point(54, 11);
            this.lblParteAdministrativa.Name = "lblParteAdministrativa";
            this.lblParteAdministrativa.Size = new System.Drawing.Size(100, 13);
            this.lblParteAdministrativa.TabIndex = 21;
            this.lblParteAdministrativa.Text = "Parte Administrativa";
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(53, 282);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(172, 57);
            this.btnVenda.TabIndex = 20;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(53, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 215);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInserirPF);
            this.tabPage2.Controls.Add(this.btnGerPF);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pessoa Física";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInserirPF
            // 
            this.btnInserirPF.Location = new System.Drawing.Point(28, 34);
            this.btnInserirPF.Name = "btnInserirPF";
            this.btnInserirPF.Size = new System.Drawing.Size(172, 57);
            this.btnInserirPF.TabIndex = 2;
            this.btnInserirPF.Text = "Inserir Pessoa Física";
            this.btnInserirPF.UseVisualStyleBackColor = true;
            this.btnInserirPF.Click += new System.EventHandler(this.btnInserirPF_Click);
            // 
            // btnGerPF
            // 
            this.btnGerPF.Location = new System.Drawing.Point(28, 97);
            this.btnGerPF.Name = "btnGerPF";
            this.btnGerPF.Size = new System.Drawing.Size(172, 57);
            this.btnGerPF.TabIndex = 3;
            this.btnGerPF.Text = "Gerenciar Pessoa Física";
            this.btnGerPF.UseVisualStyleBackColor = true;
            this.btnGerPF.Click += new System.EventHandler(this.btnGerPF_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInserirPJ);
            this.tabPage3.Controls.Add(this.btnGerPJ);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(310, 189);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pessoa Jurídica";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInserirPJ
            // 
            this.btnInserirPJ.Location = new System.Drawing.Point(36, 31);
            this.btnInserirPJ.Name = "btnInserirPJ";
            this.btnInserirPJ.Size = new System.Drawing.Size(172, 57);
            this.btnInserirPJ.TabIndex = 4;
            this.btnInserirPJ.Text = "Inserir Pessoa Jurídica";
            this.btnInserirPJ.UseVisualStyleBackColor = true;
            this.btnInserirPJ.Click += new System.EventHandler(this.btnInserirPJ_Click);
            // 
            // btnGerPJ
            // 
            this.btnGerPJ.Location = new System.Drawing.Point(36, 94);
            this.btnGerPJ.Name = "btnGerPJ";
            this.btnGerPJ.Size = new System.Drawing.Size(172, 57);
            this.btnGerPJ.TabIndex = 5;
            this.btnGerPJ.Text = "Gerenciar Pessoa Jurídica";
            this.btnGerPJ.UseVisualStyleBackColor = true;
            this.btnGerPJ.Click += new System.EventHandler(this.btnGerPJ_Click);
            // 
            // btnRelVendaPF
            // 
            this.btnRelVendaPF.Location = new System.Drawing.Point(396, 55);
            this.btnRelVendaPF.Name = "btnRelVendaPF";
            this.btnRelVendaPF.Size = new System.Drawing.Size(192, 23);
            this.btnRelVendaPF.TabIndex = 7;
            this.btnRelVendaPF.Text = "Relatório de Venda (Pessoa Física)";
            this.btnRelVendaPF.UseVisualStyleBackColor = true;
            this.btnRelVendaPF.Click += new System.EventHandler(this.btnRelVendaPF_Click);
            // 
            // btnRelVendaPJ
            // 
            this.btnRelVendaPJ.Location = new System.Drawing.Point(396, 84);
            this.btnRelVendaPJ.Name = "btnRelVendaPJ";
            this.btnRelVendaPJ.Size = new System.Drawing.Size(192, 23);
            this.btnRelVendaPJ.TabIndex = 8;
            this.btnRelVendaPJ.Text = "Relatório de Venda (Pessoa Jurídica)";
            this.btnRelVendaPJ.UseVisualStyleBackColor = true;
            this.btnRelVendaPJ.Click += new System.EventHandler(this.btnRelVendaPJ_Click);
            // 
            // btnRelItensVenda
            // 
            this.btnRelItensVenda.Location = new System.Drawing.Point(396, 118);
            this.btnRelItensVenda.Name = "btnRelItensVenda";
            this.btnRelItensVenda.Size = new System.Drawing.Size(192, 23);
            this.btnRelItensVenda.TabIndex = 10;
            this.btnRelItensVenda.Text = "Relatórios dos Planos Vendidos";
            this.btnRelItensVenda.UseVisualStyleBackColor = true;
            this.btnRelItensVenda.Click += new System.EventHandler(this.btnRelItensVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(515, 282);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 57);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 372);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelItensVenda);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.btnRelVendaPJ);
            this.Controls.Add(this.btnRelVendaPF);
            this.Controls.Add(this.lblRelatorios);
            this.Controls.Add(this.lblParteAdministrativa);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelasVendedor";
            this.Text = "TelasVendedor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Label lblParteAdministrativa;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInserirPF;
        private System.Windows.Forms.Button btnGerPF;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnInserirPJ;
        private System.Windows.Forms.Button btnGerPJ;
        private System.Windows.Forms.Button btnRelVendaPF;
        private System.Windows.Forms.Button btnRelVendaPJ;
        private System.Windows.Forms.Button btnRelItensVenda;
        private System.Windows.Forms.Button btnSair;
    }
}