namespace ControleComissoes.Views.Relatórios
{
    partial class RelVendaPF
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
            this.codigovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaFisicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewvendapfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_comissoesDataSet4 = new ControleComissoes.controle_comissoesDataSet4();
            this.view_vendapfTableAdapter = new ControleComissoes.controle_comissoesDataSet4TableAdapters.view_vendapfTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewvendapfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_comissoesDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigovendaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.pessoaFisicaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewvendapfBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigovendaDataGridViewTextBoxColumn
            // 
            this.codigovendaDataGridViewTextBoxColumn.DataPropertyName = "codigo_venda";
            this.codigovendaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigovendaDataGridViewTextBoxColumn.Name = "codigovendaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // pessoaFisicaDataGridViewTextBoxColumn
            // 
            this.pessoaFisicaDataGridViewTextBoxColumn.DataPropertyName = "pessoaFisica";
            this.pessoaFisicaDataGridViewTextBoxColumn.HeaderText = "Cliente (Pessoa Física)";
            this.pessoaFisicaDataGridViewTextBoxColumn.Name = "pessoaFisicaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total da Venda";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // viewvendapfBindingSource
            // 
            this.viewvendapfBindingSource.DataMember = "view_vendapf";
            this.viewvendapfBindingSource.DataSource = this.controle_comissoesDataSet4;
            // 
            // controle_comissoesDataSet4
            // 
            this.controle_comissoesDataSet4.DataSetName = "controle_comissoesDataSet4";
            this.controle_comissoesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_vendapfTableAdapter
            // 
            this.view_vendapfTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelVendaPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelVendaPF";
            this.Text = "RelVendaPF";
            this.Load += new System.EventHandler(this.RelVendaPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewvendapfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_comissoesDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_comissoesDataSet4 controle_comissoesDataSet4;
        private System.Windows.Forms.BindingSource viewvendapfBindingSource;
        private controle_comissoesDataSet4TableAdapters.view_vendapfTableAdapter view_vendapfTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaFisicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}