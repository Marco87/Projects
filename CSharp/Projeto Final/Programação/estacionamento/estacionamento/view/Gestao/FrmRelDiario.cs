using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Model;
using System.Globalization;
using Estacionamento.Controller;

namespace Estacionamento.View.Gestao
{
    public partial class FrmRelDiario : Form
    {
        GerenciarRelatorios gerRelatorio = new GerenciarRelatorios();

        public FrmRelDiario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (gerRelatorio.GeraRelatorioDiario(grd, dtInicio.Value.ToString("dd/MM/yyyy")) == false)
            {
                MessageBox.Show("Não foi possível gerar o relatório.", "Emissão de Relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (grd.Rows.Count == 0)
                MessageBox.Show("Não foram encontrados dados para o dia selecionado.", "Emissão de Relatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Cursor.Current = Cursors.Default;
        }
    }
}
