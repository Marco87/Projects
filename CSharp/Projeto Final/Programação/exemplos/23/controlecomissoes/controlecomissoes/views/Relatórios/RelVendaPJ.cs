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
    public partial class RelVendaPJ : Form
    {
        public RelVendaPJ()
        {
            InitializeComponent();
        }

        private void RelVendaPJ_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet5.view_vendapj'. Você pode movê-la ou removê-la conforme necessário.
            this.view_vendapjTableAdapter.Fill(this.controle_comissoesDataSet5.view_vendapj);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
