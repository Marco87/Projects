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
    public partial class FrmHistorico : Form
    {
        GerenciarRelatorios gerRelatorio = new GerenciarRelatorios();

        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            label2.Text = Globais.nomecliente;
            if (gerRelatorio.GeraRelatorioHistoricoCliente(grd) == false)
            {
                MessageBox.Show("Não foi possível gerar o relatório.", "Emissão de Relatório", MessageBoxButtons.OK);
                return;
            }
            Cursor.Current = Cursors.Default;
            if (grd.Rows.Count == 0)
            {
                Globais.idclientehist = "";
                MessageBox.Show("Apesar de cadastrado, o cliente selecionado ainda não usou o estacionamento.", "Histórico do Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
                this.Close();
                
            }
        }
    }
}
