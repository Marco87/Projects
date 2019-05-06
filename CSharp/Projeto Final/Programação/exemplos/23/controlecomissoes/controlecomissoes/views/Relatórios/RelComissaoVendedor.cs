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
    public partial class RelComissaoVendedor : Form
    {
        public RelComissaoVendedor()
        {
            InitializeComponent();
        }

        private void RelComissaoVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet6.view_comissao_vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.view_comissao_vendedorTableAdapter.Fill(this.controle_comissoesDataSet6.view_comissao_vendedor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
