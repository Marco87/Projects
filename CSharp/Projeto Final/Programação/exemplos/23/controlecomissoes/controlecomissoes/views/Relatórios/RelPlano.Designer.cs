namespace ControleComissoes.Views.Relatórios
{
    partial class RelPlano
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoplanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faixainicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faixafinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewplanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_comissoesDataSet8 = new ControleComissoes.controle_comissoesDataSet8();
            this.view_planoTableAdapter = new ControleComissoes.controle_comissoesDataSet8TableAdapters.view_planoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewplanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_comissoesDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoplanoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.tipoclienteDataGridViewTextBoxColumn,
            this.comissaoDataGridViewTextBoxColumn,
            this.faixainicialDataGridViewTextBoxColumn,
            this.faixafinalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewplanoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoplanoDataGridViewTextBoxColumn
            // 
            this.codigoplanoDataGridViewTextBoxColumn.DataPropertyName = "codigo_plano";
            this.codigoplanoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoplanoDataGridViewTextBoxColumn.Name = "codigoplanoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Plano";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // tipoclienteDataGridViewTextBoxColumn
            // 
            this.tipoclienteDataGridViewTextBoxColumn.DataPropertyName = "tipo_cliente";
            this.tipoclienteDataGridViewTextBoxColumn.HeaderText = "Tipo de Cliente";
            this.tipoclienteDataGridViewTextBoxColumn.Name = "tipoclienteDataGridViewTextBoxColumn";
            // 
            // comissaoDataGridViewTextBoxColumn
            // 
            this.comissaoDataGridViewTextBoxColumn.DataPropertyName = "comissao";
            this.comissaoDataGridViewTextBoxColumn.HeaderText = "Comissão do Vendedor";
            this.comissaoDataGridViewTextBoxColumn.Name = "comissaoDataGridViewTextBoxColumn";
            // 
            // faixainicialDataGridViewTextBoxColumn
            // 
            this.faixainicialDataGridViewTextBoxColumn.DataPropertyName = "faixa_inicial";
            this.faixainicialDataGridViewTextBoxColumn.HeaderText = "Faixa Inicial";
            this.faixainicialDataGridViewTextBoxColumn.Name = "faixainicialDataGridViewTextBoxColumn";
            // 
            // faixafinalDataGridViewTextBoxColumn
            // 
            this.faixafinalDataGridViewTextBoxColumn.DataPropertyName = "faixa_final";
            this.faixafinalDataGridViewTextBoxColumn.HeaderText = "Faixa Final";
            this.faixafinalDataGridViewTextBoxColumn.Name = "faixafinalDataGridViewTextBoxColumn";
            // 
            // viewplanoBindingSource
            // 
            this.viewplanoBindingSource.DataMember = "view_plano";
            this.viewplanoBindingSource.DataSource = this.controle_comissoesDataSet8;
            // 
            // controle_comissoesDataSet8
            // 
            this.controle_comissoesDataSet8.DataSetName = "controle_comissoesDataSet8";
            this.controle_comissoesDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_planoTableAdapter
            // 
            this.view_planoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelPlano";
            this.Text = "RelPlano";
            this.Load += new System.EventHandler(this.RelPlano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewplanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_comissoesDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_comissoesDataSet8 controle_comissoesDataSet8;
        private System.Windows.Forms.BindingSource viewplanoBindingSource;
        private controle_comissoesDataSet8TableAdapters.view_planoTableAdapter view_planoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoplanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faixainicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faixafinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}