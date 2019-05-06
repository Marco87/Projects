namespace Estacionamento.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemfuncionário = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPlano = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVaga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCadastrarVaga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAlterarVaga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSaída = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGerenciamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGerAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGerFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGerCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.logofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.user = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuVaga,
            this.mnuControle,
            this.mnuGerenciamento,
            this.mnuRelatórios,
            this.mnuArquivo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAdministrador,
            this.mnuItemfuncionário,
            this.mnuItemCliente,
            this.mnuItemPlano});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "&Cadastro";
            // 
            // mnuItemAdministrador
            // 
            this.mnuItemAdministrador.Name = "mnuItemAdministrador";
            this.mnuItemAdministrador.Size = new System.Drawing.Size(150, 22);
            this.mnuItemAdministrador.Text = "&Administrador";
            this.mnuItemAdministrador.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // mnuItemfuncionário
            // 
            this.mnuItemfuncionário.Name = "mnuItemfuncionário";
            this.mnuItemfuncionário.Size = new System.Drawing.Size(150, 22);
            this.mnuItemfuncionário.Text = "&Funcionário";
            this.mnuItemfuncionário.Click += new System.EventHandler(this.mnuItemfuncionário_Click);
            // 
            // mnuItemCliente
            // 
            this.mnuItemCliente.Name = "mnuItemCliente";
            this.mnuItemCliente.Size = new System.Drawing.Size(150, 22);
            this.mnuItemCliente.Text = "&Cliente";
            this.mnuItemCliente.Click += new System.EventHandler(this.mnuItemCliente_Click);
            // 
            // mnuItemPlano
            // 
            this.mnuItemPlano.Name = "mnuItemPlano";
            this.mnuItemPlano.Size = new System.Drawing.Size(150, 22);
            this.mnuItemPlano.Text = "&Plano";
            this.mnuItemPlano.Click += new System.EventHandler(this.planoToolStripMenuItem_Click);
            // 
            // mnuVaga
            // 
            this.mnuVaga.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCadastrarVaga,
            this.mnuItemAlterarVaga});
            this.mnuVaga.Name = "mnuVaga";
            this.mnuVaga.Size = new System.Drawing.Size(45, 20);
            this.mnuVaga.Text = "&Vaga";
            // 
            // mnuItemCadastrarVaga
            // 
            this.mnuItemCadastrarVaga.Name = "mnuItemCadastrarVaga";
            this.mnuItemCadastrarVaga.Size = new System.Drawing.Size(124, 22);
            this.mnuItemCadastrarVaga.Text = "&Cadastrar";
            this.mnuItemCadastrarVaga.Click += new System.EventHandler(this.mnuItemCadastrarVaga_Click);
            // 
            // mnuItemAlterarVaga
            // 
            this.mnuItemAlterarVaga.Name = "mnuItemAlterarVaga";
            this.mnuItemAlterarVaga.Size = new System.Drawing.Size(124, 22);
            this.mnuItemAlterarVaga.Text = "&Alterar";
            this.mnuItemAlterarVaga.Click += new System.EventHandler(this.mnuItemAlterarVaga_Click);
            // 
            // mnuControle
            // 
            this.mnuControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemEntrada,
            this.mnuItemSaída,
            this.consultarVagaToolStripMenuItem});
            this.mnuControle.Name = "mnuControle";
            this.mnuControle.Size = new System.Drawing.Size(65, 20);
            this.mnuControle.Text = "C&ontrole";
            // 
            // mnuItemEntrada
            // 
            this.mnuItemEntrada.Name = "mnuItemEntrada";
            this.mnuItemEntrada.Size = new System.Drawing.Size(154, 22);
            this.mnuItemEntrada.Text = "&Entrada";
            this.mnuItemEntrada.Click += new System.EventHandler(this.mnuItemEntrada_Click);
            // 
            // mnuItemSaída
            // 
            this.mnuItemSaída.Name = "mnuItemSaída";
            this.mnuItemSaída.Size = new System.Drawing.Size(154, 22);
            this.mnuItemSaída.Text = "&Saída";
            this.mnuItemSaída.Click += new System.EventHandler(this.mnuItemSaída_Click);
            // 
            // consultarVagaToolStripMenuItem
            // 
            this.consultarVagaToolStripMenuItem.Name = "consultarVagaToolStripMenuItem";
            this.consultarVagaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.consultarVagaToolStripMenuItem.Text = "&Consultar Vaga";
            this.consultarVagaToolStripMenuItem.Click += new System.EventHandler(this.consultarVagaToolStripMenuItem_Click);
            // 
            // mnuGerenciamento
            // 
            this.mnuGerenciamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemGerAdministrador,
            this.mnuItemGerFuncionario,
            this.mnuItemGerCliente});
            this.mnuGerenciamento.Name = "mnuGerenciamento";
            this.mnuGerenciamento.Size = new System.Drawing.Size(100, 20);
            this.mnuGerenciamento.Text = "&Gerenciamento";
            // 
            // mnuItemGerAdministrador
            // 
            this.mnuItemGerAdministrador.Name = "mnuItemGerAdministrador";
            this.mnuItemGerAdministrador.Size = new System.Drawing.Size(150, 22);
            this.mnuItemGerAdministrador.Text = "&Administrador";
            this.mnuItemGerAdministrador.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click_1);
            // 
            // mnuItemGerFuncionario
            // 
            this.mnuItemGerFuncionario.Name = "mnuItemGerFuncionario";
            this.mnuItemGerFuncionario.Size = new System.Drawing.Size(150, 22);
            this.mnuItemGerFuncionario.Text = "&Funcionário";
            this.mnuItemGerFuncionario.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // mnuItemGerCliente
            // 
            this.mnuItemGerCliente.Name = "mnuItemGerCliente";
            this.mnuItemGerCliente.Size = new System.Drawing.Size(150, 22);
            this.mnuItemGerCliente.Text = "&Cliente";
            this.mnuItemGerCliente.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // mnuRelatórios
            // 
            this.mnuRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mnuRelatórios.Name = "mnuRelatórios";
            this.mnuRelatórios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatórios.Text = "&Relatórios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            this.financeiroToolStripMenuItem.Click += new System.EventHandler(this.financeiroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Diário";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSair,
            this.logofToolStripMenuItem});
            this.mnuArquivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(38, 20);
            this.mnuArquivo.Text = "&Sair";
            // 
            // mnuItemSair
            // 
            this.mnuItemSair.Name = "mnuItemSair";
            this.mnuItemSair.Size = new System.Drawing.Size(109, 22);
            this.mnuItemSair.Text = "&Sair";
            this.mnuItemSair.Click += new System.EventHandler(this.mnuItemSair_Click);
            // 
            // logofToolStripMenuItem
            // 
            this.logofToolStripMenuItem.Name = "logofToolStripMenuItem";
            this.logofToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logofToolStripMenuItem.Text = "Logoff";
            this.logofToolStripMenuItem.Click += new System.EventHandler(this.logofToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.hora,
            this.user});
            this.statusStrip.Location = new System.Drawing.Point(0, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(43, 19);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 19);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // hora
            // 
            this.hora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(122, 19);
            this.hora.Text = "toolStripStatusLabel1";
            // 
            // user
            // 
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(118, 19);
            this.user.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem mnuItemSair;
        public System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        public System.Windows.Forms.ToolStripMenuItem mnuItemAdministrador;
        public System.Windows.Forms.ToolStripMenuItem mnuItemfuncionário;
        public System.Windows.Forms.ToolStripMenuItem mnuItemCliente;
        public System.Windows.Forms.ToolStripMenuItem mnuControle;
        public System.Windows.Forms.ToolStripMenuItem mnuItemEntrada;
        public System.Windows.Forms.ToolStripMenuItem mnuItemSaída;
        public System.Windows.Forms.ToolStripMenuItem mnuRelatórios;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel user;
        public System.Windows.Forms.ToolStripMenuItem mnuVaga;
        public System.Windows.Forms.ToolStripMenuItem mnuItemCadastrarVaga;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAlterarVaga;
        public System.Windows.Forms.ToolStripMenuItem consultarVagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGerenciamento;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGerAdministrador;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGerFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGerCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPlano;
        private System.Windows.Forms.ToolStripMenuItem logofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}



