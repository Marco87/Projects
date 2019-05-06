namespace Estacionamento.View.Gestao
{
    partial class TelaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdmin));
            this.btnEstacionarEntrada = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnGerCliente = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCadVaga = new System.Windows.Forms.Button();
            this.btnGerVaga = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnCadAdm = new System.Windows.Forms.Button();
            this.btnGerAdm = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnCadOpe = new System.Windows.Forms.Button();
            this.btnGerOpe = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnCadTipoEst = new System.Windows.Forms.Button();
            this.btnGerTipoEst = new System.Windows.Forms.Button();
            this.btnEstacionarSaida = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstacionarEntrada
            // 
            this.btnEstacionarEntrada.BackColor = System.Drawing.SystemColors.Control;
            this.btnEstacionarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstacionarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionarEntrada.Location = new System.Drawing.Point(11, 155);
            this.btnEstacionarEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstacionarEntrada.Name = "btnEstacionarEntrada";
            this.btnEstacionarEntrada.Size = new System.Drawing.Size(360, 27);
            this.btnEstacionarEntrada.TabIndex = 14;
            this.btnEstacionarEntrada.Text = "Estacionar - Entrada";
            this.btnEstacionarEntrada.UseVisualStyleBackColor = false;
            this.btnEstacionarEntrada.Click += new System.EventHandler(this.btnEstEnt_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(11, 217);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(360, 27);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 139);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnCadCliente);
            this.tabPage3.Controls.Add(this.btnGerCliente);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(352, 111);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cliente";
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Location = new System.Drawing.Point(130, 4);
            this.btnCadCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(85, 46);
            this.btnCadCliente.TabIndex = 5;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnGerCliente
            // 
            this.btnGerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerCliente.Location = new System.Drawing.Point(130, 55);
            this.btnGerCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerCliente.Name = "btnGerCliente";
            this.btnGerCliente.Size = new System.Drawing.Size(85, 46);
            this.btnGerCliente.TabIndex = 6;
            this.btnGerCliente.Text = "Gerenciar Cliente";
            this.btnGerCliente.UseVisualStyleBackColor = true;
            this.btnGerCliente.Click += new System.EventHandler(this.btnGerCliente_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.btnCadVaga);
            this.tabPage4.Controls.Add(this.btnGerVaga);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(352, 111);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vaga";
            // 
            // btnCadVaga
            // 
            this.btnCadVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVaga.Location = new System.Drawing.Point(136, 5);
            this.btnCadVaga.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadVaga.Name = "btnCadVaga";
            this.btnCadVaga.Size = new System.Drawing.Size(84, 46);
            this.btnCadVaga.TabIndex = 3;
            this.btnCadVaga.Text = "Cadastrar Vaga";
            this.btnCadVaga.UseVisualStyleBackColor = true;
            this.btnCadVaga.Click += new System.EventHandler(this.btnCadVaga_Click);
            // 
            // btnGerVaga
            // 
            this.btnGerVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerVaga.Location = new System.Drawing.Point(136, 56);
            this.btnGerVaga.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerVaga.Name = "btnGerVaga";
            this.btnGerVaga.Size = new System.Drawing.Size(84, 46);
            this.btnGerVaga.TabIndex = 7;
            this.btnGerVaga.Text = "Gerenciar Vaga";
            this.btnGerVaga.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.btnCadAdm);
            this.tabPage5.Controls.Add(this.btnGerAdm);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(352, 111);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Administrador";
            // 
            // btnCadAdm
            // 
            this.btnCadAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadAdm.Location = new System.Drawing.Point(133, 5);
            this.btnCadAdm.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadAdm.Name = "btnCadAdm";
            this.btnCadAdm.Size = new System.Drawing.Size(102, 46);
            this.btnCadAdm.TabIndex = 8;
            this.btnCadAdm.Text = "Cadastrar Administrador";
            this.btnCadAdm.UseVisualStyleBackColor = true;
            this.btnCadAdm.Click += new System.EventHandler(this.btnCadAdm_Click);
            // 
            // btnGerAdm
            // 
            this.btnGerAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerAdm.Location = new System.Drawing.Point(133, 56);
            this.btnGerAdm.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerAdm.Name = "btnGerAdm";
            this.btnGerAdm.Size = new System.Drawing.Size(102, 46);
            this.btnGerAdm.TabIndex = 9;
            this.btnGerAdm.Text = "Gerenciar Administrador";
            this.btnGerAdm.UseVisualStyleBackColor = true;
            this.btnGerAdm.Click += new System.EventHandler(this.btnGerAdm_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.btnCadOpe);
            this.tabPage6.Controls.Add(this.btnGerOpe);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(352, 111);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Operador";
            // 
            // btnCadOpe
            // 
            this.btnCadOpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadOpe.Location = new System.Drawing.Point(136, 5);
            this.btnCadOpe.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadOpe.Name = "btnCadOpe";
            this.btnCadOpe.Size = new System.Drawing.Size(89, 46);
            this.btnCadOpe.TabIndex = 8;
            this.btnCadOpe.Text = "Cadastrar Operador";
            this.btnCadOpe.UseVisualStyleBackColor = true;
            this.btnCadOpe.Click += new System.EventHandler(this.btnCadOpe_Click);
            // 
            // btnGerOpe
            // 
            this.btnGerOpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerOpe.Location = new System.Drawing.Point(136, 56);
            this.btnGerOpe.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerOpe.Name = "btnGerOpe";
            this.btnGerOpe.Size = new System.Drawing.Size(89, 46);
            this.btnGerOpe.TabIndex = 9;
            this.btnGerOpe.Text = "Gerenciar Operador";
            this.btnGerOpe.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.btnCadTipoEst);
            this.tabPage7.Controls.Add(this.btnGerTipoEst);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(352, 111);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Planos";
            // 
            // btnCadTipoEst
            // 
            this.btnCadTipoEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadTipoEst.Location = new System.Drawing.Point(106, 4);
            this.btnCadTipoEst.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadTipoEst.Name = "btnCadTipoEst";
            this.btnCadTipoEst.Size = new System.Drawing.Size(128, 46);
            this.btnCadTipoEst.TabIndex = 6;
            this.btnCadTipoEst.Text = "Cadastrar Tipo de Estacionamento";
            this.btnCadTipoEst.UseVisualStyleBackColor = true;
            this.btnCadTipoEst.Click += new System.EventHandler(this.btnCadTipoEst_Click);
            // 
            // btnGerTipoEst
            // 
            this.btnGerTipoEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerTipoEst.Location = new System.Drawing.Point(106, 55);
            this.btnGerTipoEst.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerTipoEst.Name = "btnGerTipoEst";
            this.btnGerTipoEst.Size = new System.Drawing.Size(128, 46);
            this.btnGerTipoEst.TabIndex = 7;
            this.btnGerTipoEst.Text = "Gerenciar Tipo de Estacionamento";
            this.btnGerTipoEst.UseVisualStyleBackColor = true;
            // 
            // btnEstacionarSaida
            // 
            this.btnEstacionarSaida.BackColor = System.Drawing.SystemColors.Control;
            this.btnEstacionarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstacionarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionarSaida.Location = new System.Drawing.Point(11, 186);
            this.btnEstacionarSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstacionarSaida.Name = "btnEstacionarSaida";
            this.btnEstacionarSaida.Size = new System.Drawing.Size(360, 27);
            this.btnEstacionarSaida.TabIndex = 15;
            this.btnEstacionarSaida.Text = "Estacionar - Saída";
            this.btnEstacionarSaida.UseVisualStyleBackColor = false;
            this.btnEstacionarSaida.Click += new System.EventHandler(this.btnEstacionarSaida_Click);
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 253);
            this.Controls.Add(this.btnEstacionarSaida);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEstacionarEntrada);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAdmin";
            this.Text = "Tela do Administrador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstacionarEntrada;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCadVaga;
        private System.Windows.Forms.Button btnGerVaga;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnCadAdm;
        private System.Windows.Forms.Button btnGerAdm;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnCadOpe;
        private System.Windows.Forms.Button btnGerOpe;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnCadTipoEst;
        private System.Windows.Forms.Button btnGerTipoEst;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnGerCliente;
        private System.Windows.Forms.Button btnEstacionarSaida;
    }
}