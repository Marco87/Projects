namespace Estacionamento.View.Gestao
{
    partial class AlterarVaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarVaga));
            this.buEstadoVaga = new System.Windows.Forms.Button();
            this.lblAndar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEstadoVaga2 = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoVaga = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxExcluir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buExcluir = new System.Windows.Forms.Button();
            this.buSalvar = new System.Windows.Forms.Button();
            this.comboBoxRotacionar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buRotacionar = new System.Windows.Forms.Button();
            this.buAddVaga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buVoltar = new System.Windows.Forms.Button();
            this.painelVaga = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buEstadoVaga
            // 
            this.buEstadoVaga.Location = new System.Drawing.Point(1125, 307);
            this.buEstadoVaga.Name = "buEstadoVaga";
            this.buEstadoVaga.Size = new System.Drawing.Size(47, 23);
            this.buEstadoVaga.TabIndex = 75;
            this.buEstadoVaga.Text = "OK";
            this.buEstadoVaga.UseVisualStyleBackColor = true;
            this.buEstadoVaga.Click += new System.EventHandler(this.buEstadoVaga_Click);
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndar.Location = new System.Drawing.Point(961, 12);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(113, 31);
            this.lblAndar.TabIndex = 74;
            this.lblAndar.Text = "lblAndar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1005, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "para";
            // 
            // comboBoxEstadoVaga2
            // 
            this.comboBoxEstadoVaga2.FormattingEnabled = true;
            this.comboBoxEstadoVaga2.Location = new System.Drawing.Point(1042, 309);
            this.comboBoxEstadoVaga2.Name = "comboBoxEstadoVaga2";
            this.comboBoxEstadoVaga2.Size = new System.Drawing.Size(77, 21);
            this.comboBoxEstadoVaga2.TabIndex = 72;
            this.comboBoxEstadoVaga2.Click += new System.EventHandler(this.comboBoxEstadoVaga2_Click);
            // 
            // comboBoxEstadoVaga
            // 
            this.comboBoxEstadoVaga.FormattingEnabled = true;
            this.comboBoxEstadoVaga.Location = new System.Drawing.Point(929, 309);
            this.comboBoxEstadoVaga.Name = "comboBoxEstadoVaga";
            this.comboBoxEstadoVaga.Size = new System.Drawing.Size(69, 21);
            this.comboBoxEstadoVaga.TabIndex = 71;
            this.comboBoxEstadoVaga.Click += new System.EventHandler(this.comboBoxEstadoVaga_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Mudar Vaga:";
            // 
            // comboBoxExcluir
            // 
            this.comboBoxExcluir.FormattingEnabled = true;
            this.comboBoxExcluir.Location = new System.Drawing.Point(954, 438);
            this.comboBoxExcluir.Name = "comboBoxExcluir";
            this.comboBoxExcluir.Size = new System.Drawing.Size(83, 21);
            this.comboBoxExcluir.TabIndex = 69;
            this.comboBoxExcluir.Text = "Vagas";
            this.comboBoxExcluir.Click += new System.EventHandler(this.comboBoxExcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Excluir Vaga:";
            // 
            // buExcluir
            // 
            this.buExcluir.Location = new System.Drawing.Point(1060, 431);
            this.buExcluir.Name = "buExcluir";
            this.buExcluir.Size = new System.Drawing.Size(95, 32);
            this.buExcluir.TabIndex = 67;
            this.buExcluir.Text = "Excluir Vaga";
            this.buExcluir.UseVisualStyleBackColor = true;
            this.buExcluir.Click += new System.EventHandler(this.buExcluir_Click);
            // 
            // buSalvar
            // 
            this.buSalvar.Location = new System.Drawing.Point(1022, 576);
            this.buSalvar.Name = "buSalvar";
            this.buSalvar.Size = new System.Drawing.Size(111, 32);
            this.buSalvar.TabIndex = 66;
            this.buSalvar.Text = "Salvar Alterações";
            this.buSalvar.UseVisualStyleBackColor = true;
            this.buSalvar.Click += new System.EventHandler(this.buSalvar_Click);
            // 
            // comboBoxRotacionar
            // 
            this.comboBoxRotacionar.FormattingEnabled = true;
            this.comboBoxRotacionar.Location = new System.Drawing.Point(954, 206);
            this.comboBoxRotacionar.Name = "comboBoxRotacionar";
            this.comboBoxRotacionar.Size = new System.Drawing.Size(83, 21);
            this.comboBoxRotacionar.TabIndex = 65;
            this.comboBoxRotacionar.Text = "Vagas";
            this.comboBoxRotacionar.Click += new System.EventHandler(this.comboBoxRotacionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Rotacionar Vaga:";
            // 
            // buRotacionar
            // 
            this.buRotacionar.Location = new System.Drawing.Point(1060, 192);
            this.buRotacionar.Name = "buRotacionar";
            this.buRotacionar.Size = new System.Drawing.Size(73, 47);
            this.buRotacionar.TabIndex = 63;
            this.buRotacionar.Text = "Rotacionar";
            this.buRotacionar.UseVisualStyleBackColor = true;
            this.buRotacionar.Click += new System.EventHandler(this.buRotacionar_Click);
            // 
            // buAddVaga
            // 
            this.buAddVaga.Location = new System.Drawing.Point(967, 86);
            this.buAddVaga.Name = "buAddVaga";
            this.buAddVaga.Size = new System.Drawing.Size(95, 32);
            this.buAddVaga.TabIndex = 62;
            this.buAddVaga.Text = "Adicionar Vaga";
            this.buAddVaga.UseVisualStyleBackColor = true;
            this.buAddVaga.Click += new System.EventHandler(this.buAddVaga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(892, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Reservado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(892, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ocupado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Disponível";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(855, 624);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 19);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(855, 584);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 19);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(855, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // buVoltar
            // 
            this.buVoltar.Location = new System.Drawing.Point(1097, 695);
            this.buVoltar.Name = "buVoltar";
            this.buVoltar.Size = new System.Drawing.Size(75, 23);
            this.buVoltar.TabIndex = 55;
            this.buVoltar.Text = "Voltar";
            this.buVoltar.UseVisualStyleBackColor = true;
            this.buVoltar.Click += new System.EventHandler(this.buVoltar_Click);
            // 
            // painelVaga
            // 
            this.painelVaga.BackColor = System.Drawing.Color.Gray;
            this.painelVaga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelVaga.Location = new System.Drawing.Point(11, 12);
            this.painelVaga.Name = "painelVaga";
            this.painelVaga.Size = new System.Drawing.Size(816, 706);
            this.painelVaga.TabIndex = 54;
            // 
            // AlterarVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.buEstadoVaga);
            this.Controls.Add(this.lblAndar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEstadoVaga2);
            this.Controls.Add(this.comboBoxEstadoVaga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxExcluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buExcluir);
            this.Controls.Add(this.buSalvar);
            this.Controls.Add(this.comboBoxRotacionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buRotacionar);
            this.Controls.Add(this.buAddVaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buVoltar);
            this.Controls.Add(this.painelVaga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarVaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarVaga";
            this.Load += new System.EventHandler(this.AlterarVaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buEstadoVaga;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEstadoVaga2;
        private System.Windows.Forms.ComboBox comboBoxEstadoVaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buExcluir;
        private System.Windows.Forms.Button buSalvar;
        private System.Windows.Forms.ComboBox comboBoxRotacionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buRotacionar;
        private System.Windows.Forms.Button buAddVaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buVoltar;
        private System.Windows.Forms.Panel painelVaga;

    }
}