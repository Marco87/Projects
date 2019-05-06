namespace Estacionamento.View.Gestao
{
    partial class CadTipoEstacionamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadTipoEstacionamento));
            this.btnCadTipoEstacionamento = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.mTxtValor = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMeses = new System.Windows.Forms.Label();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCadTipoEstacionamento
            // 
            this.btnCadTipoEstacionamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadTipoEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadTipoEstacionamento.Location = new System.Drawing.Point(232, 103);
            this.btnCadTipoEstacionamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadTipoEstacionamento.Name = "btnCadTipoEstacionamento";
            this.btnCadTipoEstacionamento.Size = new System.Drawing.Size(63, 24);
            this.btnCadTipoEstacionamento.TabIndex = 6;
            this.btnCadTipoEstacionamento.Text = "Ok";
            this.btnCadTipoEstacionamento.UseVisualStyleBackColor = true;
            this.btnCadTipoEstacionamento.Click += new System.EventHandler(this.btnCadTipoEstacionamento_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(28, 44);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 15);
            this.lblValor.TabIndex = 41;
            this.lblValor.Text = "Valor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(162, 18);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(96, 21);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(26, 21);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 15);
            this.lblDescricao.TabIndex = 39;
            this.lblDescricao.Text = "Descrição";
            // 
            // mTxtValor
            // 
            this.mTxtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtValor.Location = new System.Drawing.Point(162, 41);
            this.mTxtValor.Margin = new System.Windows.Forms.Padding(2);
            this.mTxtValor.Mask = "000000";
            this.mTxtValor.Name = "mTxtValor";
            this.mTxtValor.PromptChar = ' ';
            this.mTxtValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTxtValor.Size = new System.Drawing.Size(96, 21);
            this.mTxtValor.TabIndex = 2;
            this.mTxtValor.UseWaitCursor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(162, 103);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 24);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeses.Location = new System.Drawing.Point(25, 68);
            this.lblMeses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(110, 15);
            this.lblMeses.TabIndex = 46;
            this.lblMeses.Text = "Meses do Plano";
            // 
            // cbMeses
            // 
            this.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.Location = new System.Drawing.Point(162, 65);
            this.cbMeses.Margin = new System.Windows.Forms.Padding(2);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(96, 23);
            this.cbMeses.TabIndex = 3;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(12, 103);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(63, 24);
            this.btnLimparCampos.TabIndex = 4;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 89);
            this.panel1.TabIndex = 49;
            // 
            // CadTipoEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(307, 132);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.cbMeses);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mTxtValor);
            this.Controls.Add(this.btnCadTipoEstacionamento);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadTipoEstacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadTipoEstacionamento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.MaskedTextBox mTxtValor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Panel panel1;
    }
}