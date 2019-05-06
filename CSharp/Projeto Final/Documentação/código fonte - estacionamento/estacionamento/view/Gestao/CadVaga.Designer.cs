namespace Estacionamento.View.Gestao
{
    partial class CadVaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVaga));
            this.btnCadVaga = new System.Windows.Forms.Button();
            this.lblAndar = new System.Windows.Forms.Label();
            this.lblTxtAndar = new System.Windows.Forms.Label();
            this.mTxtAndar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadVaga
            // 
            this.btnCadVaga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCadVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVaga.Location = new System.Drawing.Point(155, 74);
            this.btnCadVaga.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadVaga.Name = "btnCadVaga";
            this.btnCadVaga.Size = new System.Drawing.Size(94, 26);
            this.btnCadVaga.TabIndex = 40;
            this.btnCadVaga.Text = "Confirmar";
            this.btnCadVaga.UseVisualStyleBackColor = false;
            this.btnCadVaga.Click += new System.EventHandler(this.btnCadVaga_Click);
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndar.Location = new System.Drawing.Point(60, 41);
            this.lblAndar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(35, 13);
            this.lblAndar.TabIndex = 34;
            this.lblAndar.Text = "Andar";
            // 
            // lblTxtAndar
            // 
            this.lblTxtAndar.AutoSize = true;
            this.lblTxtAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtAndar.Location = new System.Drawing.Point(15, 10);
            this.lblTxtAndar.Name = "lblTxtAndar";
            this.lblTxtAndar.Size = new System.Drawing.Size(221, 13);
            this.lblTxtAndar.TabIndex = 47;
            this.lblTxtAndar.Text = "Qual o andar desse estacionamento ?";
            // 
            // mTxtAndar
            // 
            this.mTxtAndar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtAndar.Location = new System.Drawing.Point(119, 39);
            this.mTxtAndar.Name = "mTxtAndar";
            this.mTxtAndar.Size = new System.Drawing.Size(96, 20);
            this.mTxtAndar.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.mTxtAndar);
            this.panel1.Controls.Add(this.btnCadVaga);
            this.panel1.Controls.Add(this.lblTxtAndar);
            this.panel1.Controls.Add(this.lblAndar);
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 104);
            this.panel1.TabIndex = 48;
            // 
            // CadVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(272, 128);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadVaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vaga";
            this.Load += new System.EventHandler(this.CadVaga_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadVaga;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Label lblTxtAndar;
        private System.Windows.Forms.TextBox mTxtAndar;
        private System.Windows.Forms.Panel panel1;

    }
}