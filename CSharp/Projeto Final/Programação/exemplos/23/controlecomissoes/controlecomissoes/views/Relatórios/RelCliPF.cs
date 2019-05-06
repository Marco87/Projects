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
    public partial class RelCliPF : Form
    {
        public RelCliPF()
        {
            InitializeComponent();
        }

        private void RelCliPF_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_comissoesDataSet1.view_clipf'. Você pode movê-la ou removê-la conforme necessário.
            this.view_clipfTableAdapter.Fill(this.controle_comissoesDataSet1.view_clipf);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
