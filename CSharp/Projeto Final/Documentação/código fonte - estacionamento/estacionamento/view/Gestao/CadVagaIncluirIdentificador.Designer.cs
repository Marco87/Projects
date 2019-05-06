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
            this.buIdVaga = new System.Windows.Forms.Button();
            this.textBoxIdVaga = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdVaga
            // 
            this.lblIdVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVaga.Location = new System.Drawing.Point(24, 9);
            this.lblIdVaga.Name = "lblIdVaga";
            this.lblIdVaga.Size = new System.Drawing.Size(231, 13);
            this.lblIdVaga.TabIndex = 0;
            this.lblIdVaga.Text = "Digite um Identificador para essa Vaga:";
            // 
            // buIdVaga
            // 
            this.buIdVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buIdVaga.Location = new System.Drawing.Point(106, 68);
            this.buIdVaga.Name = "buIdVaga";
            this.buIdVaga.Size = new System.Drawing.Size(67, 23);
            this.buIdVaga.TabIndex = 2;
            this.buIdVaga.Text = "OK";
            this.buIdVaga.UseVisualStyleBackColor = true;
            this.buIdVaga.Click += new System.EventHandler(this.buIdVaga_Click);
            // 
            // textBoxIdVaga
            // 
            this.textBoxIdVaga.Location = new System.Drawing.Point(89, 42);
            this.textBoxIdVaga.Name = "textBoxIdVaga";
            this.textBoxIdVaga.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdVaga.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.textBoxIdVaga);
            this.panel1.Controls.Add(this.buIdVaga);
            this.panel1.Controls.Add(this.lblIdVaga);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 105);
            this.panel1.TabIndex = 5;
            // 
            // CadVagaIncluirIdentificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(290, 129);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadVagaIncluirIdentificador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificador da Vaga";
            this.Load += new System.EventHandler(this.CadVagaIncluirIdentificador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdVaga;
        private System.Windows.Forms.Button buIdVaga;
        private System.Windows.Forms.TextBox textBoxIdVaga;
        private System.Windows.Forms.Panel panel1;
    }
}