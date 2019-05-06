using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleComissoes.Controllers;
using ControleComissoes.Models;

namespace ControleComissoes.Views.GerenciarClientePJ
{
    public partial class ConsultarAlterarClientePJ : Form
    {
        GerenciarCliPJ gerenciar = new GerenciarCliPJ();

        public ConsultarAlterarClientePJ()
        {
            InitializeComponent();
            preencherComboConsultaPJ();
            habilitarBotoes(false);
            desabilitarCheckBoxAlterarCampo();
            acaoCamposFormulario(false);
            limparCampos();
        }

        private string retornaCodigoPJ()
        {
            //Retorna o código da pessoa jurídica a ser exibido
            string clipj = comboConsultPJ.Text;
            string[] pj = clipj.Split('-');
            return pj[0];
        }

        private void limparCampos()
        {
            txtRazaoSocialPJ.Clear();
            txtCnpjPJ.Clear();
            txtEndPJ.Clear();
            txtTelPJ.Clear();
            txtLoginPJ.Clear();
            txtSenhaPJ.Clear();
        }

        private void habilitarBotoes(bool acao)
        {
            btnAlterarPJ.Visible = acao;
            btnApagarAdm.Visible = acao;
        }

        private void preencherComboConsultaPJ()
        {
            List<string> listaPJ = new List<string>();
            listaPJ = gerenciar.preencherComboConsultaClientePJ();

            for (int i = 0; i < listaPJ.Count; i++)
                comboConsultPJ.Items.Add(listaPJ[i]);

        }

        private void exibirPJ()
        {
            limparCampos();

            //Declaração das listas de pessoa jurídica e pessoa
            List<cliente_pj> listaCliPJ = new List<cliente_pj>();
            List<pessoa> listaPessoa = new List<pessoa>();

            //Carrega as listas declaradas com as respectivas pessoas jurídicas
            listaCliPJ = gerenciar.exibirClientePJ(retornaCodigoPJ());
            listaPessoa = gerenciar.exibirPessoa(retornaCodigoPJ());

            //Varre a lista e preenche os campos
            foreach (cliente_pj c in listaCliPJ)
            {
                txtRazaoSocialPJ.Text = c.razao_social;
                txtCnpjPJ.Text = c.cnpj;
            }

            foreach (pessoa p in listaPessoa)
            {
                txtEndPJ.Text = p.endereco;
                txtTelPJ.Text = p.telefone;
                txtLoginPJ.Text = p.login;
                txtSenhaPJ.Text = p.senha;
            }
        }

        private void alterarPJ()
        {
            string codigoPJ = retornaCodigoPJ();
            string razao = txtRazaoSocialPJ.Text;
            string cnpj = txtCnpjPJ.Text;
            string endereco = txtEndPJ.Text;
            string telefone = txtTelPJ.Text;
            string login = txtLoginPJ.Text;
            string senha = txtSenhaPJ.Text;

            if (gerenciar.alterarPJ(codigoPJ, razao, cnpj, endereco, telefone, login, senha))
                MessageBox.Show("Dados alterados com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();

        }

        private void apagarPJ()
        {

            if (gerenciar.apagarClientePJ(retornaCodigoPJ()))
                MessageBox.Show("Dados apagados com sucesso!");

            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();

        }

        private void desabilitarCheckBoxAlterarCampo()
        {
            cbAlterarPJ.Checked = false;
        }

        private void acaoCamposFormulario(bool acao)
        {
            txtRazaoSocialPJ.Enabled = acao;
            txtCnpjPJ.Enabled = acao;
            txtEndPJ.Enabled = acao;
            txtTelPJ.Enabled = acao;
            txtLoginPJ.Enabled = acao;
            txtSenhaPJ.Enabled = acao;
        }


        private void btnApagarAdm_Click(object sender, EventArgs e)
        {
            apagarPJ();
        }

        private void btnAlterarPJ_Click(object sender, EventArgs e)
        {
            alterarPJ();
        }

        private void comboConsultPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirPJ();
        }

        private void cbAlterarPJ_CheckedChanged(object sender, EventArgs e)
        {
            acaoCamposFormulario(cbAlterarPJ.Checked);
            habilitarBotoes(cbAlterarPJ.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
