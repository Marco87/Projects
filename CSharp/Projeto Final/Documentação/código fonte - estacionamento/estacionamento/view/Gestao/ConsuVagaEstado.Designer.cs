namespace Estacionamento.View.Gestao
{
    partial class ConsuVagaEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsuVagaEstado));
            this.lblEstadoVaga = new System.Windows.Forms.Label();
            this.comboBoxEstadoVaga = new System.Windows.Forms.ComboBox();
            this.buEstadoVaga = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstadoVaga
            // 
            this.lblEstadoVaga.AutoSize = true;
            this.lblEstadoVaga.Location = new System.Drawing.Point(58, 10);
            this.lblEstadoVaga.Name = "lblEstadoVaga";
            this.lblEstadoVaga.Size = new System.Drawing.Size(142, 13);
            this.lblEstadoVaga.TabIndex = 5;
            this.lblEstadoVaga.Text = "Mudar estado da Vaga para:";
            // 
            // comboBoxEstadoVaga
            // 
            this.comboBoxEstadoVaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoVaga.FormattingEnabled = true;
            this.comboBoxEstadoVaga.Location = new System.Drawing.Point(70, 39);
            this.comboBoxEstadoVaga.Name = "comboBoxEstadoVaga";
            this.comboBoxEstadoVaga.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstadoVaga.TabIndex = 4;
            // 
            // buEstadoVaga
            // 
            this.buEstadoVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buEstadoVaga.Location = new System.Drawing.Point(91, 89);
            this.buEstadoVaga.Name = "buEstadoVaga";
            this.buEstadoVaga.Size = new System.Drawing.Size(75, 23);
            this.buEstadoVaga.TabIndex = 3;
            this.buEstadoVaga.Text = "OK";
            this.buEstadoVaga.UseVisualStyleBackColor = true;
            this.buEstadoVaga.Click += new System.EventHandler(this.buEstadoVaga_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblEstadoVaga);
            this.panel1.Controls.Add(this.comboBoxEstadoVaga);
            this.panel1.Controls.Add(this.buEstadoVaga);
            this.panel1.Location = new System.Drawing.Point(9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 141);
            this.panel1.TabIndex = 6;
            // 
            // ConsuVagaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsuVagaEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado da Vaga";
            this.Load += new System.EventHandler(this.ConsuVagaEstado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstadoVaga;
        private System.Windows.Forms.ComboBox comboBoxEstadoVaga;
        private System.Windows.Forms.Button buEstadoVaga;
        private System.Windows.Forms.Panel panel1;
    }
}