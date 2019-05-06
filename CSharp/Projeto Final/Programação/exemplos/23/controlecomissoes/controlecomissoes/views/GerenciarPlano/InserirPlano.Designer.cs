namespace ControleComissoes.Views.GerenciarPlano
{
    partial class InserirPlano
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
            this.btnCadastroPlano = new System.Windows.Forms.Button();
            this.txtValorPlano = new System.Windows.Forms.TextBox();
            this.lblValorPlano = new System.Windows.Forms.Label();
            this.txtTipoPlano = new System.Windows.Forms.TextBox();
            this.lblTipoPlano = new System.Windows.Forms.Label();
            this.txtDescPlano = new System.Windows.Forms.TextBox();
            this.lblDescPlano = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroPlano
            // 
            this.btnCadastroPlano.Location = new System.Drawing.Point(139, 179);
            this.btnCadastroPlano.Name = "btnCadastroPlano";
            this.btnCadastroPlano.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPlano.TabIndex = 28;
            this.btnCadastroPlano.Text = "Ok";
            this.btnCadastroPlano.UseVisualStyleBackColor = true;
            this.btnCadastroPlano.Click += new System.EventHandler(this.btnCadastroPlano_Click);
            // 
            // txtValorPlano
            // 
            this.txtValorPlano.Location = new System.Drawing.Point(139, 134);
            this.txtValorPlano.Name = "txtValorPlano";
            this.txtValorPlano.Size = new System.Drawing.Size(127, 20);
            this.txtValorPlano.TabIndex = 27;
            // 
            // lblValorPlano
            // 
            this.lblValorPlano.AutoSize = true;
            this.lblValorPlano.Location = new System.Drawing.Point(102, 141);
            this.lblValorPlano.Name = "lblValorPlano";
            this.lblValorPlano.Size = new System.Drawing.Size(31, 13);
            this.lblValorPlano.TabIndex = 26;
            this.lblValorPlano.Text = "Valor";
            // 
            // txtTipoPlano
            // 
            this.txtTipoPlano.Location = new System.Drawing.Point(139, 108);
            this.txtTipoPlano.Name = "txtTipoPlano";
            this.txtTipoPlano.Size = new System.Drawing.Size(127, 20);
            this.txtTipoPlano.TabIndex = 25;
            this.txtTipoPlano.Click += new System.EventHandler(this.txtTipoPlano_Click);
            // 
            // lblTipoPlano
            // 
            this.lblTipoPlano.AutoSize = true;
            this.lblTipoPlano.Location = new System.Drawing.Point(105, 115);
            this.lblTipoPlano.Name = "lblTipoPlano";
            this.lblTipoPlano.Size = new System.Drawing.Size(28, 13);
            this.lblTipoPlano.TabIndex = 24;
            this.lblTipoPlano.Text = "Tipo";
            // 
            // txtDescPlano
            // 
            this.txtDescPlano.Location = new System.Drawing.Point(139, 82);
            this.txtDescPlano.Name = "txtDescPlano";
            this.txtDescPlano.Size = new System.Drawing.Size(127, 20);
            this.txtDescPlano.TabIndex = 23;
            // 
            // lblDescPlano
            // 
            this.lblDescPlano.AutoSize = true;
            this.lblDescPlano.Location = new System.Drawing.Point(78, 89);
            this.lblDescPlano.Name = "lblDescPlano";
            this.lblDescPlano.Size = new System.Drawing.Size(55, 13);
            this.lblDescPlano.TabIndex = 22;
            this.lblDescPlano.Text = "Descrição";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InserirPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastroPlano);
            this.Controls.Add(this.txtValorPlano);
            this.Controls.Add(this.lblValorPlano);
            this.Controls.Add(this.txtTipoPlano);
            this.Controls.Add(this.lblTipoPlano);
            this.Controls.Add(this.txtDescPlano);
            this.Controls.Add(this.lblDescPlano);
            this.Name = "InserirPlano";
            this.Text = "InserirPlano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroPlano;
        private System.Windows.Forms.TextBox txtValorPlano;
        private System.Windows.Forms.Label lblValorPlano;
        private System.Windows.Forms.TextBox txtTipoPlano;
        private System.Windows.Forms.Label lblTipoPlano;
        private System.Windows.Forms.TextBox txtDescPlano;
        private System.Windows.Forms.Label lblDescPlano;
        private System.Windows.Forms.Button button1;
    }
}