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

namespace Estacionamento.View.Gestao
{
    public partial class FrmRelatorio : Form
    {

        GerenciarRelatorios gerRelatorio = new GerenciarRelatorios();

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            montaGrid();

            if (gerRelatorio.GeraRelatorioFinanceiro(dtInicio.Value.ToString("yyyy-MM-dd"), dtFim.Value.ToString("yyyy-MM-dd"), grd) == false)  
            {
                MessageBox.Show("Não foi possível gerar o relatório", "Emissão de Relatório", MessageBoxButtons.OK);
            }
            else
            {
                if (grd.Rows.Count > 0)
                {
                    cmdImprimir.Enabled = true;
                }
            }
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            grd.Enabled = false;
            cmdImprimir.Enabled = false;
        }

        private void montaGrid()
        {
            if (grd.Columns.Count != 0)
            {
                grd.Rows.Clear();
            }
            else
            {
                grd.ColumnCount = 2;
                grd.Columns[0].Width = grd.Width / 2;
                grd.Columns[1].Width = grd.Width / 2;
                grd.Columns[0].Name = "Data";
                grd.Columns[1].Name = "Valor";
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
