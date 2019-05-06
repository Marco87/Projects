namespace Estacionamento.View.Gestao
{
    partial class TelaOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaOperador));
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadVaga = new System.Windows.Forms.Button();
            this.btnGerVaga = new System.Windows.Forms.Button();
            this.btnGerCliente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEstacionarEntrada = new System.Windows.Forms.Button();
            this.btnEstacionarSaida = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(59, 5);
            this.btnCadCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(80, 46);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadVaga
            // 
            this.btnCadVaga.Location = new System.Drawing.Point(60, 5);
            this.btnCadVaga.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadVaga.Name = "btnCadVaga";
            this.btnCadVaga.Size = new System.Drawing.Size(80, 46);
            this.btnCadVaga.TabIndex = 3;
            this.btnCadVaga.Text = "Cadastrar Vaga";
            this.btnCadVaga.UseVisualStyleBackColor = true;
            this.btnCadVaga.Click += new System.EventHandler(this.btnCadVaga_Click);
            // 
            // btnGerVaga
            // 
            this.btnGerVaga.Location = new System.Drawing.Point(60, 56);
            this.btnGerVaga.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerVaga.Name = "btnGerVaga";
            this.btnGerVaga.Size = new System.Drawing.Size(80, 46);
            this.btnGerVaga.TabIndex = 7;
            this.btnGerVaga.Text = "Gerenciar Vaga";
            this.btnGerVaga.UseVisualStyleBackColor = true;
            // 
            // btnGerCliente
            // 
            this.btnGerCliente.Location = new System.Drawing.Point(59, 56);
            this.btnGerCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerCliente.Name = "btnGerCliente";
            this.btnGerCliente.Size = new System.Drawing.Size(80, 46);
            this.btnGerCliente.TabIndex = 4;
            this.btnGerCliente.Text = "Gerenciar Cliente";
            this.btnGerCliente.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(27, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(195, 139);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCadCliente);
            this.tabPage1.Controls.Add(this.btnGerCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(187, 111);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCadVaga);
            this.tabPage4.Controls.Add(this.btnGerVaga);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(187, 111);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vaga";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(27, 215);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(195, 27);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEstacionarEntrada
            // 
            this.btnEstacionarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionarEntrada.Location = new System.Drawing.Point(27, 154);
            this.btnEstacionarEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstacionarEntrada.Name = "btnEstacionarEntrada";
            this.btnEstacionarEntrada.Size = new System.Drawing.Size(195, 27);
            this.btnEstacionarEntrada.TabIndex = 15;
            this.btnEstacionarEntrada.Text = "Estacionar - Entrada";
            this.btnEstacionarEntrada.UseVisualStyleBackColor = true;
            this.btnEstacionarEntrada.Click += new System.EventHandler(this.btnEstacionarEntrada_Click);
            // 
            // btnEstacionarSaida
            // 
            this.btnEstacionarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionarSaida.Location = new System.Drawing.Point(27, 184);
            this.btnEstacionarSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstacionarSaida.Name = "btnEstacionarSaida";
            this.btnEstacionarSaida.Size = new System.Drawing.Size(195, 27);
            this.btnEstacionarSaida.TabIndex = 16;
            this.btnEstacionarSaida.Text = "Estacionar - Saída";
            this.btnEstacionarSaida.UseVisualStyleBackColor = true;
            this.btnEstacionarSaida.Click += new System.EventHandler(this.btnEstacionarSaida_Click);
            // 
            // TelaOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 251);
            this.Controls.Add(this.btnEstacionarSaida);
            this.Controls.Add(this.btnEstacionarEntrada);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaOperador";
            this.Text = "Tela do Operador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadVaga;
        private System.Windows.Forms.Button btnGerVaga;
        private System.Windows.Forms.Button btnGerCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEstacionarEntrada;
        private System.Windows.Forms.Button btnEstacionarSaida;
    }
}