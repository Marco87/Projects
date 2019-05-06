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
    public partial class TelasVendedor : Form
    {
        /*
        Login login = new Login();
        Validacoes validacoes = new Validacoes();
        
        InserirAdm inserirAdm = new InserirAdm();
        ConsultarAlterarAdm consultAdm = new ConsultarAlterarAdm();

        InserirVendedor inserirVendedor = new InserirVendedor();
        ConsultarAlterarVend consultVendedor = new ConsultarAlterarVend();

        InserirPlano inserirPlano = new InserirPlano();
        InserirPlanoComissao inserirPlanoComissao = new InserirPlanoComissao();

        RelAdm relAdm = new RelAdm();
        RelCliPF relCliPf = new RelCliPF();
        RelCliPJ relCliPj = new RelCliPJ();
        RelComissaoVendedor relComissao = new RelComissaoVendedor();
        RelPlano relPlano = new RelPlano();
        RelVendedor relVendedor = new RelVendedor();
        */


        public TelasVendedor()
        {
            InitializeComponent();
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

        private void btnVenda_Click(object sender, EventArgs e)
        {
            InserirVenda inserirVenda = new InserirVenda();
            inserirVenda.Show();
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

        private void btnRelItensVenda_Click(object sender, EventArgs e)
        {
            RelItensVenda relItensVenda = new RelItensVenda();    
            relItensVenda.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
