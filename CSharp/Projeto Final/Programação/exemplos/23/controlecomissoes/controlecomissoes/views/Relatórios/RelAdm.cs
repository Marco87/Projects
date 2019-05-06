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
    public partial class RelAdm : Form
    {
        public RelAdm()
        {
            InitializeComponent();
        }

        private void lvAdm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void RelAdm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet.view_adm'. Você pode movê-la ou removê-la conforme necessário.
            this.view_admTableAdapter.Fill(this.controle_comissoesDataSet.view_adm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
