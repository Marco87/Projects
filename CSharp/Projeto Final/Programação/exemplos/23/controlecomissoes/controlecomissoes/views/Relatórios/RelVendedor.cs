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
    public partial class RelVendedor : Form
    {
        public RelVendedor()
        {
            InitializeComponent();
        }

        private void RelVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet3.view_vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.view_vendedorTableAdapter.Fill(this.controle_comissoesDataSet3.view_vendedor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
