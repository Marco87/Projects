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
    public partial class TelaAdmin : Form
    {
        //Instâncias das telas de cadastro
        CadVaga cadVaga = new CadVaga();
        CadCliente cadCli = new CadCliente();
        CadVeiculo cadVeiculo = new CadVeiculo();
        CadAdmin cadAdm = new CadAdmin();
        CadOperador cadOpe = new CadOperador();
        CadTipoEstacionamento cadTipoEst = new CadTipoEstacionamento();

        //Instâncias das telas de gerenciamento
        GerAdmin gerAdm = new GerAdmin();
        GerCliente gerCli = new GerCliente();

        //Instâncias das telas de estacionar
        EstacionarEntrada estEnt = new EstacionarEntrada();
        EstacionarSaida estSaida = new EstacionarSaida();

        public TelaAdmin()
        {
            InitializeComponent();
        }

        //Tela de estacionar
        private void btnEstEnt_Click(object sender, EventArgs e)
        {
            estEnt.Show();
        }

        //Telas de cadastro
        private void btnCadTipoEst_Click(object sender, EventArgs e)
        {
            cadTipoEst.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            cadCli.Show();
        }

        private void btnCadVaga_Click(object sender, EventArgs e)
        {
            cadVaga.Show();
        }

        private void btnCadAdm_Click(object sender, EventArgs e)
        {
            cadAdm.Show();
        }

        private void btnCadOpe_Click(object sender, EventArgs e)
        {
            cadOpe.Show();
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            cadVeiculo.Show();
        }

        //Telas de gerenciamento
        private void btnGerAdm_Click(object sender, EventArgs e)
        {
            gerAdm.Show();
        }

        private void btnGerCliente_Click(object sender, EventArgs e)
        {
            gerCli.Show();
        }

        //Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEstacionarSaida_Click(object sender, EventArgs e)
        {
            estSaida.Show();
        }

    }
}