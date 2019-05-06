namespace Estacionamento.View
{
    partial class CadVagaIncluirIdentificador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVagaIncluirIdentificador));
            this.lblIdVaga = new System.Windows.Forms.Label();
            this.textBoxIdVaga = new System.Windows.Forms.TextBox();
            this.buIdVaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdVaga
            // 
            this.lblIdVaga.AutoSize = true;
            this.lblIdVaga.Location = new System.Drawing.Point(49, 24);
            this.lblIdVaga.Name = "lblIdVaga";
            this.lblIdVaga.Size = new System.Drawing.Size(192, 13);
            this.lblIdVaga.TabIndex = 0;
            this.lblIdVaga.Text = "Digite um Identificador para essa Vaga:";
            // 
            // textBoxIdVaga
            // 
            this.textBoxIdVaga.Location = new System.Drawing.Point(88, 55);
            this.textBoxIdVaga.Name = "textBoxIdVaga";
            this.textBoxIdVaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdVaga.TabIndex = 1;
            this.textBoxIdVaga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdVaga_KeyPress);
            // 
            // buIdVaga
            // 
            this.buIdVaga.Location = new System.Drawing.Point(101, 94);
            this.buIdVaga.Name = "buIdVaga";
            this.buIdVaga.Size = new System.Drawing.Size(67, 23);
            this.buIdVaga.TabIndex = 2;
            this.buIdVaga.Text = "OK";
            this.buIdVaga.UseVisualStyleBackColor = true;
            this.buIdVaga.Click += new System.EventHandler(this.buIdVaga_Click);
            // 
            // CadVagaIncluirIdentificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 129);
            this.Controls.Add(this.buIdVaga);
            this.Controls.Add(this.textBoxIdVaga);
            this.Controls.Add(this.lblIdVaga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadVagaIncluirIdentificador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificador da Vaga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdVaga;
        private System.Windows.Forms.TextBox textBoxIdVaga;
        private System.Windows.Forms.Button buIdVaga;
    }
}