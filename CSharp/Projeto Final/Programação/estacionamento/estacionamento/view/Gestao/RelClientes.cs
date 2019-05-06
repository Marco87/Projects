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

    public partial class RelClientes : Form
    {

        GerenciarRelatorios gerRelatorio = new GerenciarRelatorios();

        public RelClientes()
        {
            InitializeComponent();
        }

        private void RelClientes_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //montaGrid();
            if (gerRelatorio.CarregaComboPlano(comboBox1) == false)
            {
                MessageBox.Show("Não foi possível inicializar planos.", "Emissão de Relatório", MessageBoxButtons.OK);
                return;
            }
            if (gerRelatorio.GeraRelatorioCliente("", grd) == false)
            {
                MessageBox.Show("Não foi possível gerar o relatório.", "Emissão de Relatório", MessageBoxButtons.OK);
                return;
            }
            if (grd.Rows.Count > 0)
                btnExibir.Enabled = true;
            else
                btnExibir.Enabled = false;
            Cursor.Current = Cursors.Default;
        }

        private void montaGrid()
        {
            if (grd.Columns.Count != 0)
            {
                grd.Rows.Clear();
            }
            else
            {
                this.grd.ColumnCount = 4;
                this.grd.Columns[0].Width = 230;
                this.grd.Columns[1].Width = 75;
                this.grd.Columns[2].Width = 75;
                this.grd.Columns[4].Width = 274;
                this.grd.Columns[0].Name = "Nome";
                this.grd.Columns[1].Name = "Telefone";
                this.grd.Columns[2].Name = "Celular";
                this.grd.Columns[3].Name = "Endereço";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void rdoTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoTodos.Checked == true)
            {
                rdoPlano.Checked = false;
                comboBox1.SelectedIndex = -1;
                comboBox1.Enabled = false;      
            }
        }

        private void rdoPlano_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoPlano.Checked == true)
            {
                rdoTodos.Checked = false;
                comboBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo;
            if (rdoPlano.Checked == true && comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um plano.", "Emissão de Relatório", MessageBoxButtons.OK);
                return;
            }
            if (rdoPlano.Checked == true)
            {
                tipo = comboBox1.Text.Substring(0, 2).Trim();
            }
            else
            {
                tipo = "";
            }
            Cursor.Current = Cursors.WaitCursor;
            grd.Rows.Clear();
            if (gerRelatorio.GeraRelatorioCliente(tipo, grd) == false)
            {
                MessageBox.Show("Não foi possível gerar o relatório.", "Emissão de Relatório", MessageBoxButtons.OK);
                return;
            }
            if (grd.Rows.Count > 0)
                btnExibir.Enabled = true;
            else
                btnExibir.Enabled = false;
            Cursor.Current = Cursors.Default;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            FrmHistorico telaHist = new FrmHistorico();
            Globais.nomecliente = grd.Rows[grd.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            Globais.idclientehist = grd.Rows[grd.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
            telaHist.ShowDialog();

        }
    }
}
