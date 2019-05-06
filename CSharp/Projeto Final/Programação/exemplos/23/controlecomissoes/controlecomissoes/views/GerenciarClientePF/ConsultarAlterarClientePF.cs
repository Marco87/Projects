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

namespace ControleComissoes.Views.GerenciarClientePF
{
    public partial class ConsultarAlterarClientePF : Form
    {
        GerenciarCliPF gerenciar = new GerenciarCliPF();

        public ConsultarAlterarClientePF()
        {
            InitializeComponent();
            preencherComboConsultaPF();
            habilitarBotoes(false);
            desabilitarCheckBoxAlterarCampo();
            acaoCamposFormulario(false);
            limparCampos();
        }

        private string retornaCodigoPF()
        {
            //Retorna o código da pessoa física a ser exibida
            string clpf = comboConsultPF.Text;
            string[] pf = clpf.Split('-');
            return pf[0];
        }

        private void limparCampos()
        {
            txtNomePF.Clear();
            txtCpfPF.Clear();
            txtEndPF.Clear();
            txtTelPF.Clear();
            txtLoginPF.Clear();
            txtSenhaPF.Clear();
        }

        private void habilitarBotoes(bool acao)
        {
            btnAlterarPF.Visible = acao;
            btnApagarPF.Visible = acao;
        }

        private void preencherComboConsultaPF()
        {
            List<string> listaPF = new List<string>();
            listaPF = gerenciar.preencherComboConsultaClientePF();

            for (int i = 0; i < listaPF.Count; i++)
                comboConsultPF.Items.Add(listaPF[i]);
        }


        private void exibirPF()
        {
            limparCampos();

            //Declaração das listas de pessoa física e pessoa
            List<cliente_pf> listaPF = new List<cliente_pf>();
            List<pessoa> listaPessoa = new List<pessoa>();

            //Carrega as listas declaradas com os respectivos pessoas físicas
            listaPF = gerenciar.exibirClientePF(retornaCodigoPF());
            listaPessoa = gerenciar.exibirPessoa(retornaCodigoPF());

            //Varre a lista e preenche os campos
            foreach (cliente_pf c in listaPF)
            {
                txtNomePF.Text = c.nome;
                txtCpfPF.Text = c.cpf;
            }

            foreach (pessoa p in listaPessoa)
            {
                txtEndPF.Text = p.endereco;
                txtTelPF.Text = p.telefone;
                txtLoginPF.Text = p.login;
                txtSenhaPF.Text = p.senha;
            }
        }

        private void alterarPF()
        {
            string codigoPF = retornaCodigoPF();
            string nome = txtNomePF.Text;
            string cpf = txtCpfPF.Text;
            string endereco = txtEndPF.Text;
            string telefone = txtTelPF.Text;
            string login = txtLoginPF.Text;
            string senha = txtSenhaPF.Text;

            if (gerenciar.alterarPF(codigoPF, nome, cpf, endereco, telefone, login, senha))
                MessageBox.Show("Dados alterados com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }

        private void apagarPF()
        {

            if (gerenciar.apagarClientePF(retornaCodigoPF()))
                MessageBox.Show("Dados apagados com sucesso!");

            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
            
        }

        private void desabilitarCheckBoxAlterarCampo()
        {
            cbAlterarPF.Checked = false;
        }


        private void acaoCamposFormulario(bool acao)
        {
            txtNomePF.Enabled = acao;
            txtCpfPF.Enabled = acao;
            txtEndPF.Enabled = acao;
            txtTelPF.Enabled = acao;
            txtLoginPF.Enabled = acao;
            txtSenhaPF.Enabled = acao;
        }

        private void btnApagarPF_Click(object sender, EventArgs e)
        {
            apagarPF();
        }

        private void btnAlterarPF_Click(object sender, EventArgs e)
        {
            alterarPF();
        }

        private void cbAlterarPF_CheckedChanged(object sender, EventArgs e)
        {
            acaoCamposFormulario(cbAlterarPF.Checked);
            habilitarBotoes(cbAlterarPF.Checked);
        }

        private void comboConsultPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirPF();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
