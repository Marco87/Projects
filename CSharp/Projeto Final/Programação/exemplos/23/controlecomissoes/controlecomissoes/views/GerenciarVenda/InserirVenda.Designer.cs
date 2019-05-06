namespace ControleComissoes.Views.GerenciarVenda
{
    partial class InserirVenda
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
            this.comboInserirPF = new System.Windows.Forms.ComboBox();
            this.txtCpfPF = new System.Windows.Forms.TextBox();
            this.lblCpfPF = new System.Windows.Forms.Label();
            this.txtNomePF = new System.Windows.Forms.TextBox();
            this.lblNomePF = new System.Windows.Forms.Label();
            this.comboInserirPJ = new System.Windows.Forms.ComboBox();
            this.txtCnpjPJ = new System.Windows.Forms.TextBox();
            this.lblCnpjPJ = new System.Windows.Forms.Label();
            this.txtRazaoPJ = new System.Windows.Forms.TextBox();
            this.lblRazaoPJ = new System.Windows.Forms.Label();
            this.rbPF = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.lblListTotalItemVenda = new System.Windows.Forms.Label();
            this.lblListQtdItemVenda = new System.Windows.Forms.Label();
            this.lblListPlanoItemVenda = new System.Windows.Forms.Label();
            this.btnAdicionarItemVenda = new System.Windows.Forms.Button();
            this.listItemTotal = new System.Windows.Forms.ListBox();
            this.listItemQtd = new System.Windows.Forms.ListBox();
            this.listItemPlano = new System.Windows.Forms.ListBox();
            this.txtQtdItemVenda = new System.Windows.Forms.TextBox();
            this.lblQtdItemVenda = new System.Windows.Forms.Label();
            this.txtTotalItemPlano = new System.Windows.Forms.TextBox();
            this.lblTotalItemPlano = new System.Windows.Forms.Label();
            this.lblConsultaPlano = new System.Windows.Forms.Label();
            this.comboConsultaPlano = new System.Windows.Forms.ComboBox();
            this.txtPrecoPlano = new System.Windows.Forms.TextBox();
            this.lblPrecoPlano = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.comboConsultaVendedor = new System.Windows.Forms.ComboBox();
            this.txtCpfVendedor = new System.Windows.Forms.TextBox();
            this.lblCpfVendedor = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.gbItensVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboInserirPF
            // 
            this.comboInserirPF.FormattingEnabled = true;
            this.comboInserirPF.Location = new System.Drawing.Point(96, 139);
            this.comboInserirPF.Name = "comboInserirPF";
            this.comboInserirPF.Size = new System.Drawing.Size(127, 21);
            this.comboInserirPF.TabIndex = 49;
            this.comboInserirPF.SelectedIndexChanged += new System.EventHandler(this.comboInserirPF_SelectedIndexChanged);
            // 
            // txtCpfPF
            // 
            this.txtCpfPF.Location = new System.Drawing.Point(96, 192);
            this.txtCpfPF.Name = "txtCpfPF";
            this.txtCpfPF.Size = new System.Drawing.Size(127, 20);
            this.txtCpfPF.TabIndex = 48;
            // 
            // lblCpfPF
            // 
            this.lblCpfPF.AutoSize = true;
            this.lblCpfPF.Location = new System.Drawing.Point(35, 199);
            this.lblCpfPF.Name = "lblCpfPF";
            this.lblCpfPF.Size = new System.Drawing.Size(27, 13);
            this.lblCpfPF.TabIndex = 47;
            this.lblCpfPF.Text = "CPF";
            // 
            // txtNomePF
            // 
            this.txtNomePF.Location = new System.Drawing.Point(96, 166);
            this.txtNomePF.Name = "txtNomePF";
            this.txtNomePF.Size = new System.Drawing.Size(127, 20);
            this.txtNomePF.TabIndex = 46;
            // 
            // lblNomePF
            // 
            this.lblNomePF.AutoSize = true;
            this.lblNomePF.Location = new System.Drawing.Point(35, 173);
            this.lblNomePF.Name = "lblNomePF";
            this.lblNomePF.Size = new System.Drawing.Size(35, 13);
            this.lblNomePF.TabIndex = 45;
            this.lblNomePF.Text = "Nome";
            // 
            // comboInserirPJ
            // 
            this.comboInserirPJ.FormattingEnabled = true;
            this.comboInserirPJ.Location = new System.Drawing.Point(316, 139);
            this.comboInserirPJ.Name = "comboInserirPJ";
            this.comboInserirPJ.Size = new System.Drawing.Size(127, 21);
            this.comboInserirPJ.TabIndex = 54;
            this.comboInserirPJ.SelectedIndexChanged += new System.EventHandler(this.comboInserirPJ_SelectedIndexChanged);
            // 
            // txtCnpjPJ
            // 
            this.txtCnpjPJ.Location = new System.Drawing.Point(316, 192);
            this.txtCnpjPJ.Name = "txtCnpjPJ";
            this.txtCnpjPJ.Size = new System.Drawing.Size(127, 20);
            this.txtCnpjPJ.TabIndex = 53;
            // 
            // lblCnpjPJ
            // 
            this.lblCnpjPJ.AutoSize = true;
            this.lblCnpjPJ.Location = new System.Drawing.Point(246, 199);
            this.lblCnpjPJ.Name = "lblCnpjPJ";
            this.lblCnpjPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCnpjPJ.TabIndex = 52;
            this.lblCnpjPJ.Text = "CNPJ";
            // 
            // txtRazaoPJ
            // 
            this.txtRazaoPJ.Location = new System.Drawing.Point(316, 166);
            this.txtRazaoPJ.Name = "txtRazaoPJ";
            this.txtRazaoPJ.Size = new System.Drawing.Size(127, 20);
            this.txtRazaoPJ.TabIndex = 51;
            // 
            // lblRazaoPJ
            // 
            this.lblRazaoPJ.AutoSize = true;
            this.lblRazaoPJ.Location = new System.Drawing.Point(246, 173);
            this.lblRazaoPJ.Name = "lblRazaoPJ";
            this.lblRazaoPJ.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoPJ.TabIndex = 50;
            this.lblRazaoPJ.Text = "Razão Social";
            // 
            // rbPF
            // 
            this.rbPF.AutoSize = true;
            this.rbPF.Location = new System.Drawing.Point(96, 116);
            this.rbPF.Name = "rbPF";
            this.rbPF.Size = new System.Drawing.Size(92, 17);
            this.rbPF.TabIndex = 55;
            this.rbPF.TabStop = true;
            this.rbPF.Text = "Pessoa Física";
            this.rbPF.UseVisualStyleBackColor = true;
            this.rbPF.CheckedChanged += new System.EventHandler(this.rbPF_CheckedChanged);
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(316, 116);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(101, 17);
            this.rbPJ.TabIndex = 56;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "Pessoa Jurídica";
            this.rbPJ.UseVisualStyleBackColor = true;
            this.rbPJ.CheckedChanged += new System.EventHandler(this.rbPJ_CheckedChanged);
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.lblListTotalItemVenda);
            this.gbItensVenda.Controls.Add(this.lblListQtdItemVenda);
            this.gbItensVenda.Controls.Add(this.lblListPlanoItemVenda);
            this.gbItensVenda.Controls.Add(this.btnAdicionarItemVenda);
            this.gbItensVenda.Controls.Add(this.listItemTotal);
            this.gbItensVenda.Controls.Add(this.listItemQtd);
            this.gbItensVenda.Controls.Add(this.listItemPlano);
            this.gbItensVenda.Controls.Add(this.txtQtdItemVenda);
            this.gbItensVenda.Controls.Add(this.lblQtdItemVenda);
            this.gbItensVenda.Controls.Add(this.txtTotalItemPlano);
            this.gbItensVenda.Controls.Add(this.lblTotalItemPlano);
            this.gbItensVenda.Controls.Add(this.lblConsultaPlano);
            this.gbItensVenda.Controls.Add(this.comboConsultaPlano);
            this.gbItensVenda.Controls.Add(this.txtPrecoPlano);
            this.gbItensVenda.Controls.Add(this.lblPrecoPlano);
            this.gbItensVenda.Location = new System.Drawing.Point(38, 240);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(803, 213);
            this.gbItensVenda.TabIndex = 57;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "Itens da Venda";
            // 
            // lblListTotalItemVenda
            // 
            this.lblListTotalItemVenda.AutoSize = true;
            this.lblListTotalItemVenda.Location = new System.Drawing.Point(562, 27);
            this.lblListTotalItemVenda.Name = "lblListTotalItemVenda";
            this.lblListTotalItemVenda.Size = new System.Drawing.Size(31, 13);
            this.lblListTotalItemVenda.TabIndex = 72;
            this.lblListTotalItemVenda.Text = "Total";
            // 
            // lblListQtdItemVenda
            // 
            this.lblListQtdItemVenda.AutoSize = true;
            this.lblListQtdItemVenda.Location = new System.Drawing.Point(436, 27);
            this.lblListQtdItemVenda.Name = "lblListQtdItemVenda";
            this.lblListQtdItemVenda.Size = new System.Drawing.Size(62, 13);
            this.lblListQtdItemVenda.TabIndex = 71;
            this.lblListQtdItemVenda.Text = "Quantidade";
            // 
            // lblListPlanoItemVenda
            // 
            this.lblListPlanoItemVenda.AutoSize = true;
            this.lblListPlanoItemVenda.Location = new System.Drawing.Point(310, 27);
            this.lblListPlanoItemVenda.Name = "lblListPlanoItemVenda";
            this.lblListPlanoItemVenda.Size = new System.Drawing.Size(34, 13);
            this.lblListPlanoItemVenda.TabIndex = 70;
            this.lblListPlanoItemVenda.Text = "Plano";
            // 
            // btnAdicionarItemVenda
            // 
            this.btnAdicionarItemVenda.Location = new System.Drawing.Point(84, 151);
            this.btnAdicionarItemVenda.Name = "btnAdicionarItemVenda";
            this.btnAdicionarItemVenda.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarItemVenda.TabIndex = 69;
            this.btnAdicionarItemVenda.Text = "Adicionar";
            this.btnAdicionarItemVenda.UseVisualStyleBackColor = true;
            this.btnAdicionarItemVenda.Click += new System.EventHandler(this.btnAdicionarItemVenda_Click);
            // 
            // listItemTotal
            // 
            this.listItemTotal.FormattingEnabled = true;
            this.listItemTotal.Location = new System.Drawing.Point(565, 43);
            this.listItemTotal.Name = "listItemTotal";
            this.listItemTotal.Size = new System.Drawing.Size(120, 95);
            this.listItemTotal.TabIndex = 68;
            // 
            // listItemQtd
            // 
            this.listItemQtd.FormattingEnabled = true;
            this.listItemQtd.Location = new System.Drawing.Point(439, 43);
            this.listItemQtd.Name = "listItemQtd";
            this.listItemQtd.Size = new System.Drawing.Size(120, 95);
            this.listItemQtd.TabIndex = 67;
            // 
            // listItemPlano
            // 
            this.listItemPlano.FormattingEnabled = true;
            this.listItemPlano.Location = new System.Drawing.Point(313, 43);
            this.listItemPlano.Name = "listItemPlano";
            this.listItemPlano.Size = new System.Drawing.Size(120, 95);
            this.listItemPlano.TabIndex = 66;
            // 
            // txtQtdItemVenda
            // 
            this.txtQtdItemVenda.Location = new System.Drawing.Point(84, 99);
            this.txtQtdItemVenda.Name = "txtQtdItemVenda";
            this.txtQtdItemVenda.Size = new System.Drawing.Size(127, 20);
            this.txtQtdItemVenda.TabIndex = 65;
            // 
            // lblQtdItemVenda
            // 
            this.lblQtdItemVenda.AutoSize = true;
            this.lblQtdItemVenda.Location = new System.Drawing.Point(14, 106);
            this.lblQtdItemVenda.Name = "lblQtdItemVenda";
            this.lblQtdItemVenda.Size = new System.Drawing.Size(62, 13);
            this.lblQtdItemVenda.TabIndex = 64;
            this.lblQtdItemVenda.Text = "Quantidade";
            // 
            // txtTotalItemPlano
            // 
            this.txtTotalItemPlano.Location = new System.Drawing.Point(84, 125);
            this.txtTotalItemPlano.Name = "txtTotalItemPlano";
            this.txtTotalItemPlano.Size = new System.Drawing.Size(127, 20);
            this.txtTotalItemPlano.TabIndex = 63;
            this.txtTotalItemPlano.Click += new System.EventHandler(this.txtTotalItemPlano_Click);
            // 
            // lblTotalItemPlano
            // 
            this.lblTotalItemPlano.AutoSize = true;
            this.lblTotalItemPlano.Location = new System.Drawing.Point(14, 132);
            this.lblTotalItemPlano.Name = "lblTotalItemPlano";
            this.lblTotalItemPlano.Size = new System.Drawing.Size(31, 13);
            this.lblTotalItemPlano.TabIndex = 62;
            this.lblTotalItemPlano.Text = "Total";
            // 
            // lblConsultaPlano
            // 
            this.lblConsultaPlano.AutoSize = true;
            this.lblConsultaPlano.Location = new System.Drawing.Point(14, 51);
            this.lblConsultaPlano.Name = "lblConsultaPlano";
            this.lblConsultaPlano.Size = new System.Drawing.Size(34, 13);
            this.lblConsultaPlano.TabIndex = 61;
            this.lblConsultaPlano.Text = "Plano";
            // 
            // comboConsultaPlano
            // 
            this.comboConsultaPlano.FormattingEnabled = true;
            this.comboConsultaPlano.Location = new System.Drawing.Point(84, 43);
            this.comboConsultaPlano.Name = "comboConsultaPlano";
            this.comboConsultaPlano.Size = new System.Drawing.Size(127, 21);
            this.comboConsultaPlano.TabIndex = 60;
            this.comboConsultaPlano.SelectedIndexChanged += new System.EventHandler(this.comboConsultaPlano_SelectedIndexChanged);
            // 
            // txtPrecoPlano
            // 
            this.txtPrecoPlano.Location = new System.Drawing.Point(84, 70);
            this.txtPrecoPlano.Name = "txtPrecoPlano";
            this.txtPrecoPlano.Size = new System.Drawing.Size(127, 20);
            this.txtPrecoPlano.TabIndex = 59;
            // 
            // lblPrecoPlano
            // 
            this.lblPrecoPlano.AutoSize = true;
            this.lblPrecoPlano.Location = new System.Drawing.Point(14, 77);
            this.lblPrecoPlano.Name = "lblPrecoPlano";
            this.lblPrecoPlano.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoPlano.TabIndex = 58;
            this.lblPrecoPlano.Text = "Preço";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Location = new System.Drawing.Point(122, 468);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(127, 20);
            this.txtTotalVenda.TabIndex = 71;
            this.txtTotalVenda.Click += new System.EventHandler(this.txtTotalVenda_Click);
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(36, 475);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(80, 13);
            this.lblTotalVenda.TabIndex = 70;
            this.lblTotalVenda.Text = "Total da Venda";
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Location = new System.Drawing.Point(122, 494);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(75, 23);
            this.btnConcluirVenda.TabIndex = 70;
            this.btnConcluirVenda.Text = "Concluir";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // comboConsultaVendedor
            // 
            this.comboConsultaVendedor.FormattingEnabled = true;
            this.comboConsultaVendedor.Location = new System.Drawing.Point(96, 25);
            this.comboConsultaVendedor.Name = "comboConsultaVendedor";
            this.comboConsultaVendedor.Size = new System.Drawing.Size(127, 21);
            this.comboConsultaVendedor.TabIndex = 76;
            this.comboConsultaVendedor.SelectedIndexChanged += new System.EventHandler(this.comboConsultaVendedor_SelectedIndexChanged);
            // 
            // txtCpfVendedor
            // 
            this.txtCpfVendedor.Location = new System.Drawing.Point(96, 78);
            this.txtCpfVendedor.Name = "txtCpfVendedor";
            this.txtCpfVendedor.Size = new System.Drawing.Size(127, 20);
            this.txtCpfVendedor.TabIndex = 75;
            // 
            // lblCpfVendedor
            // 
            this.lblCpfVendedor.AutoSize = true;
            this.lblCpfVendedor.Location = new System.Drawing.Point(35, 85);
            this.lblCpfVendedor.Name = "lblCpfVendedor";
            this.lblCpfVendedor.Size = new System.Drawing.Size(27, 13);
            this.lblCpfVendedor.TabIndex = 74;
            this.lblCpfVendedor.Text = "CPF";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(96, 52);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(127, 20);
            this.txtNomeVendedor.TabIndex = 73;
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(35, 59);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(35, 13);
            this.lblNomeVendedor.TabIndex = 72;
            this.lblNomeVendedor.Text = "Nome";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(36, 33);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 77;
            this.lblVendedor.Text = "Vendedor";
            // 
            // InserirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 529);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.comboConsultaVendedor);
            this.Controls.Add(this.txtCpfVendedor);
            this.Controls.Add(this.lblCpfVendedor);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.lblNomeVendedor);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.rbPJ);
            this.Controls.Add(this.rbPF);
            this.Controls.Add(this.comboInserirPJ);
            this.Controls.Add(this.txtCnpjPJ);
            this.Controls.Add(this.lblCnpjPJ);
            this.Controls.Add(this.txtRazaoPJ);
            this.Controls.Add(this.lblRazaoPJ);
            this.Controls.Add(this.comboInserirPF);
            this.Controls.Add(this.txtCpfPF);
            this.Controls.Add(this.lblCpfPF);
            this.Controls.Add(this.txtNomePF);
            this.Controls.Add(this.lblNomePF);
            this.Name = "InserirVenda";
            this.Text = "InserirVenda";
            this.Load += new System.EventHandler(this.InserirVenda_Load);
            this.gbItensVenda.ResumeLayout(false);
            this.gbItensVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboInserirPF;
        private System.Windows.Forms.TextBox txtCpfPF;
        private System.Windows.Forms.Label lblCpfPF;
        private System.Windows.Forms.TextBox txtNomePF;
        private System.Windows.Forms.Label lblNomePF;
        private System.Windows.Forms.ComboBox comboInserirPJ;
        private System.Windows.Forms.TextBox txtCnpjPJ;
        private System.Windows.Forms.Label lblCnpjPJ;
        private System.Windows.Forms.TextBox txtRazaoPJ;
        private System.Windows.Forms.Label lblRazaoPJ;
        private System.Windows.Forms.RadioButton rbPF;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.Button btnAdicionarItemVenda;
        private System.Windows.Forms.ListBox listItemTotal;
        private System.Windows.Forms.ListBox listItemQtd;
        private System.Windows.Forms.ListBox listItemPlano;
        private System.Windows.Forms.TextBox txtQtdItemVenda;
        private System.Windows.Forms.Label lblQtdItemVenda;
        private System.Windows.Forms.TextBox txtTotalItemPlano;
        private System.Windows.Forms.Label lblTotalItemPlano;
        private System.Windows.Forms.Label lblConsultaPlano;
        private System.Windows.Forms.ComboBox comboConsultaPlano;
        private System.Windows.Forms.TextBox txtPrecoPlano;
        private System.Windows.Forms.Label lblPrecoPlano;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Label lblListTotalItemVenda;
        private System.Windows.Forms.Label lblListQtdItemVenda;
        private System.Windows.Forms.Label lblListPlanoItemVenda;
        private System.Windows.Forms.ComboBox comboConsultaVendedor;
        private System.Windows.Forms.TextBox txtCpfVendedor;
        private System.Windows.Forms.Label lblCpfVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Label lblVendedor;
    }
}