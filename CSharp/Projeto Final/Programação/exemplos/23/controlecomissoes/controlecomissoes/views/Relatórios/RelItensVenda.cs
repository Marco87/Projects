using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleComissoes.Views.Relatórios
{
    public partial class RelItensVenda : Form
    {
        public RelItensVenda()
        {
            InitializeComponent();
        }

        private void RelItensVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet7.view_itens_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.view_itens_vendaTableAdapter.Fill(this.controle_comissoesDataSet7.view_itens_venda);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
