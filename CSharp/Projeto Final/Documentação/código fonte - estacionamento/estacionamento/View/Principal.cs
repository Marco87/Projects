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
using Estacionamento.Controller;


namespace Estacionamento.View
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;
        private DateTime horario = DateTime.Now;
        
        public Principal()
        {
            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Login TelaLogin = new Login();
            TelaLogin.ShowDialog();
            this.user.Text = Globais._usuario.ToUpper().Trim();
            HabilitaMenus(Globais._tipoConexao);
        }

        private void HabilitaMenus(string tipo)
        {
            if (tipo == Globais.tipoAdministrador)
            {
                this.mnuArquivo.Enabled = true;
                this.mnuCadastro.Enabled = true;
                this.mnuControle.Enabled = true;
                this.mnuItemAdministrador.Enabled = true;
                this.mnuItemCliente.Enabled = true;
                this.mnuItemEntrada.Enabled = true;
                this.mnuItemfuncionário.Enabled = true;
                this.mnuItemPlano.Enabled = true;
                this.mnuItemSaída.Enabled = true;
                this.mnuItemSair.Enabled = true;
                this.mnuRelatórios.Enabled = true;
                this.mnuGerenciamento.Enabled = true;
                this.mnuItemGerAdministrador.Enabled = true;
                this.mnuItemGerCliente.Enabled = true;
                this.mnuItemGerFuncionario.Enabled = true;
                //this.mnuItemGerVaga.Enabled = true;
            }
            if (tipo == Globais.tipoFuncionario)
            {
                this.mnuArquivo.Enabled = true;
                this.mnuCadastro.Enabled = true;
                this.mnuControle.Enabled = true;
                this.mnuItemAdministrador.Enabled = false;
                this.mnuItemCliente.Enabled = true;
                this.mnuItemEntrada.Enabled = true;
                this.mnuItemfuncionário.Enabled = false;
                this.mnuItemPlano.Enabled = false;
                this.mnuItemSaída.Enabled = true;
                this.mnuItemSair.Enabled = true;
                this.mnuRelatórios.Enabled = false;
                this.mnuGerenciamento.Enabled = true;
                this.mnuItemGerAdministrador.Enabled = false;
                this.mnuItemGerCliente.Enabled = true;
                this.mnuItemGerFuncionario.Enabled = false;
                //this.mnuItemGerVaga.Enabled = true;
            }
            if (tipo == Globais.tipoCliente)
            {
                this.mnuArquivo.Enabled = true;
                this.mnuCadastro.Enabled = false;
                this.mnuControle.Enabled = false;
                this.mnuItemAdministrador.Enabled = false;
                this.mnuItemCliente.Enabled = false;
                this.mnuItemEntrada.Enabled = false;
                this.mnuItemfuncionário.Enabled = false;
                this.mnuItemPlano.Enabled = false;
                this.mnuItemSaída.Enabled = false;
                this.mnuItemSair.Enabled = true;
                this.mnuRelatórios.Enabled = false;
                this.mnuGerenciamento.Enabled = false;
                this.mnuItemGerAdministrador.Enabled = false;
                this.mnuItemGerCliente.Enabled = false;
                this.mnuItemGerFuncionario.Enabled = false;
                //this.mnuItemGerVaga.Enabled = false;
            }

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAdmin telaAdmin = new CadAdmin();
            telaAdmin.ShowDialog();
        }

        private void mnuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuItemCliente_Click(object sender, EventArgs e)
        {
            CadCliente telaCliente = new CadCliente();
            telaCliente.ShowDialog();
        }

        private void mnuItemfuncionário_Click(object sender, EventArgs e)
        {
            CadOperador telaOperador = new CadOperador();
            telaOperador.ShowDialog();
        }

        private void mnuItemEntrada_Click(object sender, EventArgs e)
        {
            EstacionarEntrada telaEntrada = new EstacionarEntrada();
            telaEntrada.ShowDialog();
        }

        private void mnuItemSaída_Click(object sender, EventArgs e)
        {
            EstacionarSaida telaSaida = new EstacionarSaida();
            telaSaida.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GerCliente gerCli = new GerCliente();
            gerCli.ShowDialog();
        }

        private void mnuItemCadastrarVaga_Click(object sender, EventArgs e)
        {
            CadVaga cadVag = new CadVaga();
            cadVag.ShowDialog();
        }

        private void consultarVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsuVagaAndar cva = new ConsuVagaAndar();
            cva.ShowDialog();
        }

        private void mnuItemAlterarVaga_Click(object sender, EventArgs e)
        {
            AlterarVagaAndar ava = new AlterarVagaAndar();
            ava.ShowDialog();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio relFinanceiro = new FrmRelatorio();
            relFinanceiro.ShowDialog();
        }

        private void administradorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GerAdmin gerAdm = new GerAdmin();
            gerAdm.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerOperador gerOpe = new GerOperador();
            gerOpe.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerCliente gerCli = new GerCliente();
            gerCli.ShowDialog();
        }

        private void planoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadTipoEstacionamento cadPlano = new CadTipoEstacionamento();
            cadPlano.ShowDialog();
        }

        private void logofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login TelaLogin = new Login();
            TelaLogin.ShowDialog();
            this.user.Text = Globais._usuario.ToUpper().Trim();
            HabilitaMenus(Globais._tipoConexao);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelClientes RelatCliente = new RelClientes();
            RelatCliente.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelDiario RelDiario = new FrmRelDiario();
            RelDiario.ShowDialog();
        }


    }
}
