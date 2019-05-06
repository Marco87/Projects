namespace Estacionamento.View.Gestao
{
    partial class AlterarVagaAndar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarVagaAndar));
            this.buVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAndar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buVoltar
            // 
            this.buVoltar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buVoltar.Location = new System.Drawing.Point(132, 74);
            this.buVoltar.Name = "buVoltar";
            this.buVoltar.Size = new System.Drawing.Size(63, 23);
            this.buVoltar.TabIndex = 10;
            this.buVoltar.Text = "Sair";
            this.buVoltar.UseVisualStyleBackColor = false;
            this.buVoltar.Click += new System.EventHandler(this.buVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Qual o andar que você deseja consultar?";
            // 
            // comboBoxAndar
            // 
            this.comboBoxAndar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxAndar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAndar.FormattingEnabled = true;
            this.comboBoxAndar.Location = new System.Drawing.Point(74, 30);
            this.comboBoxAndar.Name = "comboBoxAndar";
            this.comboBoxAndar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAndar.TabIndex = 8;
            this.comboBoxAndar.Click += new System.EventHandler(this.comboBoxAndar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(203, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buVoltar);
            this.panel1.Controls.Add(this.comboBoxAndar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 105);
            this.panel1.TabIndex = 11;
            // 
            // AlterarVagaAndar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(288, 123);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarVagaAndar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha o Andar";
            this.Load += new System.EventHandler(this.AlterarVagaAndar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAndar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}