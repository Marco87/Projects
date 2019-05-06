using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleComissoes.Controllers;
using ControleComissoes.Models;

namespace ControleComissoes.Views.GerenciarVenda
{
    public partial class InserirVenda : Form
    {
        GerenciarCliPF gerPF = new GerenciarCliPF();
        GerenciarCliPJ gerPJ = new GerenciarCliPJ();
        GerenciarVend gerVenda = new GerenciarVend();
        GerenciarVended gerVendedor = new GerenciarVended();
        GerenciarPlan gerPlano = new GerenciarPlan();
        Validacoes validacoes = new Validacoes();
        Login login = new Login();

        List<string> listaItens = new List<string>();
        List<float> listaValorComissao = new List<float>();


        public InserirVenda()
        {
            InitializeComponent();
            rbPF.Checked = false;
            rbPJ.Checked = false;
            acaoCamposPF(false);
            acaoCamposPJ(false);
            limparCamposVendedor();
            limparCamposPF();
            limparCamposPJ();
            limparCamposItemVenda();
            preencherComboConsultaVendedor();
            preencherComboConsultaPF();
            preencherComboConsultaPJ();
            preencherComboConsultaPlano();
            txtTotalVenda.Text = "0";
        }

        private void limparCamposVendedor()
        {
            txtNomeVendedor.Clear();
            txtCpfVendedor.Clear();
        }

        private void limparCamposPF()
        {
            txtNomePF.Clear();
            txtCpfPF.Clear();
        }

        private void acaoCamposPF(bool acao)
        {
            comboInserirPF.Enabled = acao;
            txtNomePF.Enabled = acao;
            txtCpfPF.Enabled = acao;
        }

        private void limparCamposPJ()
        {
            txtRazaoPJ.Clear();
            txtCnpjPJ.Clear();
        }

        private void acaoCamposPJ(bool acao)
        {
            comboInserirPJ.Enabled = acao;
            txtRazaoPJ.Enabled = acao;
            txtCnpjPJ.Enabled = acao;

        }

        private void limparCamposItemVenda()
        {
            txtPrecoPlano.Clear();
            txtQtdItemVenda.Clear();
            txtTotalItemPlano.Clear();
        }

        private void limparListasItemVenda()
        {

            listItemPlano.Items.Clear();
            listItemQtd.Items.Clear();
            listItemTotal.Items.Clear();
        }

        private void InserirVenda_Load(object sender, EventArgs e)
        {

        }

        private void preencherComboConsultaVendedor()
        {
            List<string> listaVendedor = new List<string>();
            listaVendedor = gerVendedor.preencherComboConsultaVendedor();

            for (int i = 0; i < listaVendedor.Count; i++)
                comboConsultaVendedor.Items.Add(listaVendedor[i]);
        }

        private void preencherComboConsultaPF()
        {
            List<string> listaPF = new List<string>();
            listaPF = gerPF.preencherComboConsultaClientePF();

            for (int i = 0; i < listaPF.Count; i++)
                comboInserirPF.Items.Add(listaPF[i]);
        }

        private void preencherComboConsultaPJ()
        {
            List<string> listaPJ = new List<string>();
            listaPJ = gerPJ.preencherComboConsultaClientePJ();

            for (int i = 0; i < listaPJ.Count; i++)
                comboInserirPJ.Items.Add(listaPJ[i]);
        }

        private void preencherComboConsultaPlano()
        {
            List<string> listaPlano = new List<string>();
            listaPlano = gerPlano.preencherComboConsultaPlano();

            for (int i = 0; i < listaPlano.Count; i++)
                comboConsultaPlano.Items.Add(listaPlano[i]);
        }

        private void exibirDadosCliPF()
        {
            limparCamposPF();
            limparCamposPJ();

            //Declaração das listas de adm e pessoa
            List<cliente_pf> listaPF = new List<cliente_pf>();

            listaPF = gerPF.exibirClientePF(validacoes.retornaCodigo(comboInserirPF.Text));

            //Varre a lista e preenche os campos
            foreach (cliente_pf pf in listaPF)
            {
                txtNomePF.Text = pf.nome;
                txtCpfPF.Text = pf.cpf;
            }
        }

        private void exibirDadosCliPJ()
        {
            limparCamposPJ();
            limparCamposPF();
            //Declaração das listas de adm e pessoa
            List<cliente_pj> listaPJ = new List<cliente_pj>();

            listaPJ = gerPJ.exibirClientePJ(validacoes.retornaCodigo(comboInserirPJ.Text));

            //Varre a lista e preenche os campos
            foreach (cliente_pj pj in listaPJ)
            {
                txtRazaoPJ.Text = pj.razao_social;
                txtCnpjPJ.Text = pj.cnpj;
            }
        }

        private void exibirDadosPlano()
        {
            limparCamposItemVenda();
            //Declaração das listas de adm e pessoa
            List<plano> listaPlano = new List<plano>();

            listaPlano = gerPlano.exibirPlano(validacoes.retornaCodigo(comboConsultaPlano.Text));

            //Varre a lista e preenche os campos
            foreach (plano p in listaPlano)
            {
                txtPrecoPlano.Text = p.valor.ToString();
            }
        }

        public void confirmarVenda()
        {
            Venda venda = new Venda();

            string codVendedor = validacoes.retornaCodigo(comboConsultaVendedor.Text);
            string codigoCliente;
            float totalVenda = Convert.ToInt64(txtTotalVenda.Text);


            if (rbPF.Checked == true)
            {
                codigoCliente = validacoes.retornaCodigo(comboInserirPF.Text);

                if (gerVenda.inserirVendaPF(codVendedor, codigoCliente, totalVenda))
                {
                    MessageBox.Show("Compra efetuada com sucesso!");
                    inserirItemVenda();
                    inserirValorComissao();
                }
                else
                    MessageBox.Show("A operação não pôde ser concluída!");
            }
            if (rbPJ.Checked == true)
            {
                codigoCliente = validacoes.retornaCodigo(comboInserirPJ.Text);

                if (gerVenda.inserirVendaPJ(codVendedor, codigoCliente, totalVenda))
                {
                    MessageBox.Show("Compra efetuada com sucesso!");
                    inserirItemVenda();
                    inserirValorComissao();
                }
                else
                    MessageBox.Show("A operação não pôde ser concluída!");
            }

            limparCamposVendedor();
            limparCamposPF();
            limparCamposPJ();
            limparCamposItemVenda();
            limparListasItemVenda();
            txtTotalVenda.Text = "0";
        }

        private void exibirDadosVendedor()
        {
            limparCamposVendedor();
            List<vendedor> listaVendedor = new List<vendedor>();

            listaVendedor = gerVendedor.exibirVendedor(validacoes.retornaCodigo(comboConsultaVendedor.Text));

            //Varre a lista e preenche os campos
            foreach (vendedor v in listaVendedor)
            {
                txtNomeVendedor.Text = v.nome;
                txtCpfVendedor.Text = v.cpf;
            }
        }

        private void inserirItemVenda()
        {
            int codVenda = gerVenda.retornaUltimoCodigoVenda();
            string codPlano;
            int qtd;
            float totalItem;

            for (int i = 0; i < listaItens.Count; )
            {
                codPlano = listaItens[i];
                i += 1;
                qtd = Convert.ToInt32(listaItens[i]);
                i += 1;
                totalItem = Convert.ToInt64(listaItens[i]);
                i += 1;

                gerVenda.inserirItemVenda(codVenda, codPlano, qtd, totalItem);
            }
        }

        private void inserirValorComissao()
        {
            int codVenda = gerVenda.retornaUltimoCodigoVenda();
            string codVendedor = validacoes.retornaCodigo(comboConsultaVendedor.Text);
            float valorComissao;

            for (int i = 0; i < listaValorComissao.Count; i++)
            {
                valorComissao = listaValorComissao[i];

                gerVenda.inserirComissaoVendedor(codVenda, codVendedor, valorComissao);
            }

        }

        private void rbPF_CheckedChanged(object sender, EventArgs e)
        {
            limparCamposPJ();
            acaoCamposPF(true);
            acaoCamposPJ(false);
        }

        private void rbPJ_CheckedChanged(object sender, EventArgs e)
        {
            limparCamposPF();
            acaoCamposPJ(true);
            acaoCamposPF(false);
        }

        private void comboInserirPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirDadosCliPF();
        }

        private void comboInserirPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirDadosCliPJ();
        }

        private void comboConsultaPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirDadosPlano();
        }

        private void txtTotalItemPlano_Click(object sender, EventArgs e)
        {
            txtTotalItemPlano.Text = (Convert.ToDouble(txtPrecoPlano.Text) * Convert.ToInt32(txtQtdItemVenda.Text)).ToString();
        }

        private void preencherListasItemVenda()
        {
            listItemPlano.Items.Add(comboConsultaPlano.Text);
            listItemQtd.Items.Add(txtQtdItemVenda.Text);
            listItemTotal.Items.Add(txtTotalItemPlano.Text);
        }

        private void armazenarItensVenda()
        {
            listaItens.Add(validacoes.retornaCodigo(comboConsultaPlano.Text));
            listaItens.Add(txtQtdItemVenda.Text);
            listaItens.Add(txtTotalItemPlano.Text);
        }

        private void armazenarValorComissao()
        {
            int tipoCliente = 0;

            if (rbPF.Checked == true)
            {
                tipoCliente = 2;
            }
            if (rbPJ.Checked == true)
            {
                tipoCliente = 3;
            }

            float comissao = 0;

            comissao = (gerVenda.retornarValorComissao(validacoes.retornaCodigo(comboConsultaPlano.Text), tipoCliente, txtQtdItemVenda.Text));
            listaValorComissao.Add(comissao);
        }

        private void btnAdicionarItemVenda_Click(object sender, EventArgs e)
        {
            armazenarItensVenda();
            armazenarValorComissao();

            preencherListasItemVenda();
            txtTotalVenda.Text = (Convert.ToInt64(txtTotalVenda.Text) + (Convert.ToInt64(txtTotalItemPlano.Text))).ToString();
            txtPrecoPlano.Clear();
            txtQtdItemVenda.Clear();
            txtTotalItemPlano.Clear();
        }

        private void txtTotalVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            confirmarVenda();
            Close();
        }

        private void comboConsultaVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirDadosVendedor();
        }

    }
}
