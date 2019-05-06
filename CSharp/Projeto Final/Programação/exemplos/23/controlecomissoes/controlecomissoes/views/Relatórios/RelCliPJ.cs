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
    public partial class RelCliPJ : Form
    {
        public RelCliPJ()
        {
            InitializeComponent();
        }

        private void RelCliPJ_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet2.view_clipj'. Você pode movê-la ou removê-la conforme necessário.
            this.view_clipjTableAdapter.Fill(this.controle_comissoesDataSet2.view_clipj);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
