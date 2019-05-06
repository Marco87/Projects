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
    public partial class RelPlano : Form
    {
        public RelPlano()
        {
            InitializeComponent();
        }

        private void RelPlano_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet8.view_plano'. Você pode movê-la ou removê-la conforme necessário.
            this.view_planoTableAdapter.Fill(this.controle_comissoesDataSet8.view_plano);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
