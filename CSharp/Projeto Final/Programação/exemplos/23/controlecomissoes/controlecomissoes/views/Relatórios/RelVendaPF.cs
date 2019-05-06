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
    public partial class RelVendaPF : Form
    {
        public RelVendaPF()
        {
            InitializeComponent();
        }

        private void RelVendaPF_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet4.view_vendapf'. Você pode movê-la ou removê-la conforme necessário.
            this.view_vendapfTableAdapter.Fill(this.controle_comissoesDataSet4.view_vendapf);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
