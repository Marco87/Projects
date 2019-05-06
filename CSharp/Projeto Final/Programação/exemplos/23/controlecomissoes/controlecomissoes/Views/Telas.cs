using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleComissoes.Views.GerenciarAdm;
using ControleComissoes.Views.GerenciarClientePF;
using ControleComissoes.Views.GerenciarClientePJ;
using ControleComissoes.Views.GerenciarPlano;
using ControleComissoes.Views.GerenciarVenda;
using ControleComissoes.Views.GerenciarVendedor;
using ControleComissoes.Views.Relatórios;
using ControleComissoes.Models;

namespace ControleComissoes.Views
{
    public partial class Telas : Form
    {
        //Login login = new Login();
        //Validacoes validacoes = new Validacoes();


        public Telas()
        {
            InitializeComponent();
        }

        private void btnInserirAdm_Click(object sender, EventArgs e)
        {
            InserirAdm inserirAdm = new InserirAdm();
            inserirAdm.Show();

        }

        private void btnGerAdm_Click(object sender, EventArgs e)
        {
            ConsultarAlterarAdm consultAdm = new ConsultarAlterarAdm();
            consultAdm.Show();
        }

        private void btnInserirPF_Click(object sender, EventArgs e)
        {
            InserirClientePF inserirPF = new InserirClientePF();
            inserirPF.Show();

        }

        private void btnGerPF_Click(object sender, EventArgs e)
        {
            ConsultarAlterarClientePF consultPF = new ConsultarAlterarClientePF();
            consultPF.Show();
        }

        private void btnInserirPJ_Click(object sender, EventArgs e)
        {
            InserirClientePJ inserirPJ = new InserirClientePJ();
            inserirPJ.Show();

        }

        private void btnGerPJ_Click(object sender, EventArgs e)
        {
            ConsultarAlterarClientePJ consultPJ = new ConsultarAlterarClientePJ();
            consultPJ.Show();

        }

        private void btnInserirVend_Click(object sender, EventArgs e)
        {

            InserirVendedor inserirVendedor = new InserirVendedor();
            inserirVendedor.Show();

        }

        private void btnGerVend_Click(object sender, EventArgs e)
        {
            ConsultarAlterarVend consultVendedor = new ConsultarAlterarVend();
            consultVendedor.Show();

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {

            InserirVenda inserirVenda = new InserirVenda();
            inserirVenda.Show();
        }

        private void btnInserirPlano_Click(object sender, EventArgs e)
        {

            InserirPlano inserirPlano = new InserirPlano();
            inserirPlano.Show();

        }

        private void btnInserirPlanoComissao_Click(object sender, EventArgs e)
        {
            InserirPlanoComissao inserirPlanoComissao = new InserirPlanoComissao();
            inserirPlanoComissao.Show();

        }

        private void btnRelAdm_Click(object sender, EventArgs e)
        {
            RelAdm relAdm = new RelAdm();
            relAdm.Show();

        }

        private void btnRelVendaPF_Click(object sender, EventArgs e)
        {

            RelVendaPF relVendaPf = new RelVendaPF();
            relVendaPf.Show();

        }

        private void btnRelVendaPJ_Click(object sender, EventArgs e)
        {

            RelVendaPJ relVendaPj = new RelVendaPJ();
            relVendaPj.Show();

        }

        private void btnComissaoVendedor_Click(object sender, EventArgs e)
        {
            RelComissaoVendedor relComissao = new RelComissaoVendedor();
            relComissao.Show();

        }

        private void btnRelItensVenda_Click(object sender, EventArgs e)
        {

            RelItensVenda relItensVenda = new RelItensVenda();
            relItensVenda.Show();

        }

        private void btnRelPF_Click(object sender, EventArgs e)
        {
            RelCliPF relCliPf = new RelCliPF();
            relCliPf.Show();

        }

        private void btnRelPJ_Click(object sender, EventArgs e)
        {
            RelCliPJ relCliPj = new RelCliPJ();
            relCliPj.Show();

        }

        private void btnRelVendedor_Click(object sender, EventArgs e)
        {

            RelVendedor relVendedor = new RelVendedor();
            relVendedor.Show();

        }

        private void relPlanos_Click(object sender, EventArgs e)
        {
            RelPlano relPlano = new RelPlano();
            relPlano.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
