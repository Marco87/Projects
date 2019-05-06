namespace ControleComissoes.Views.Relatórios
{
    partial class RelComissaoVendedor
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
            this.codigovendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcomissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewcomissaovendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_comissoesDataSet6 = new ControleComissoes.controle_comissoesDataSet6();
            this.view_comissao_vendedorTableAdapter = new ControleComissoes.controle_comissoesDataSet6TableAdapters.view_comissao_vendedorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcomissaovendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_comissoesDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigovendaDataGridViewTextBoxColumn,
            this.codigovendedorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.valorcomissaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewcomissaovendedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigovendaDataGridViewTextBoxColumn
            // 
            this.codigovendaDataGridViewTextBoxColumn.DataPropertyName = "codigo_venda";
            this.codigovendaDataGridViewTextBoxColumn.HeaderText = "Código da Venda";
            this.codigovendaDataGridViewTextBoxColumn.Name = "codigovendaDataGridViewTextBoxColumn";
            // 
            // codigovendedorDataGridViewTextBoxColumn
            // 
            this.codigovendedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_vendedor";
            this.codigovendedorDataGridViewTextBoxColumn.HeaderText = "Código do Vendedor";
            this.codigovendedorDataGridViewTextBoxColumn.Name = "codigovendedorDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // valorcomissaoDataGridViewTextBoxColumn
            // 
            this.valorcomissaoDataGridViewTextBoxColumn.DataPropertyName = "valor_comissao";
            this.valorcomissaoDataGridViewTextBoxColumn.HeaderText = "Valor da Comissão";
            this.valorcomissaoDataGridViewTextBoxColumn.Name = "valorcomissaoDataGridViewTextBoxColumn";
            // 
            // viewcomissaovendedorBindingSource
            // 
            this.viewcomissaovendedorBindingSource.DataMember = "view_comissao_vendedor";
            this.viewcomissaovendedorBindingSource.DataSource = this.controle_comissoesDataSet6;
            // 
            // controle_comissoesDataSet6
            // 
            this.controle_comissoesDataSet6.DataSetName = "controle_comissoesDataSet6";
            this.controle_comissoesDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_comissao_vendedorTableAdapter
            // 
            this.view_comissao_vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelComissaoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RelComissaoVendedor";
            this.Text = "RelComissaoVendedor";
            this.Load += new System.EventHandler(this.RelComissaoVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcomissaovendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_comissoesDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_comissoesDataSet6 controle_comissoesDataSet6;
        private System.Windows.Forms.BindingSource viewcomissaovendedorBindingSource;
        private controle_comissoesDataSet6TableAdapters.view_comissao_vendedorTableAdapter view_comissao_vendedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigovendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcomissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}