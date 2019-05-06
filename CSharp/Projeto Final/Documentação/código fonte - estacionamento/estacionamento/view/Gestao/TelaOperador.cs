using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.View;
using Estacionamento.View.Gestao;
using Estacionamento.Model;

namespace Estacionamento.View.Gestao
{
    public partial class TelaOperador : Form
    {
        CadVaga cadVaga = new CadVaga();
        CadCliente cadCli = new CadCliente();

        EstacionarEntrada estEnt = new EstacionarEntrada();
        EstacionarSaida estSaida = new EstacionarSaida();

        public TelaOperador()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadVaga_Click(object sender, EventArgs e)
        {
            cadVaga.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            cadCli.Show();
        }

        private void btnEstacionarEntrada_Click(object sender, EventArgs e)
        {
            estEnt.Show();
        }

        private void btnEstacionarSaida_Click(object sender, EventArgs e)
        {
            estSaida.Show();
        }

    }
}
