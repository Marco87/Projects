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

namespace ControleComissoes.Views.GerenciarAdm
{
    public partial class ConsultarAlterarAdm : Form
    {
        GerenciarAdministrador gerenciar = new GerenciarAdministrador();

        public ConsultarAlterarAdm()
        {
            InitializeComponent();
            preencherComboConsultaAdm();
            habilitarBotoes(false);
            desabilitarCheckBoxAlterarCampo();
            acaoCamposFormulario(false);
            limparCampos();

        }

        private string retornaCodigoAdm()
        {
            //Retorna o código do administrador a ser exibido
            string admi = comboConsultAdm.Text;
            string[] admin = admi.Split('-');
            return admin[0];
        }

        private void limparCampos()
        {
            txtNomeAdm.Clear();
            txtCpfAdm.Clear();
            txtEndAdm.Clear();
            txtTelAdm.Clear();
            txtLoginAdm.Clear();
            txtSenhaAdm.Clear();
        }

        private void habilitarBotoes(bool acao)
        {
            btnAlterarAdm.Visible = acao;
            btnApagarAdm.Visible = acao;
        }

        private void preencherComboConsultaAdm()
        {
            List<string> listaAdm = new List<string>();
            listaAdm = gerenciar.preencherComboConsultaAdm();

            for (int i = 0; i < listaAdm.Count; i++)
                comboConsultAdm.Items.Add(listaAdm[i]);

        }

        private void exibirAdm()
        {
            limparCampos();

            //Declaração das listas de adm e pessoa
            List<administrador> listaAdm = new List<administrador>();
            List<pessoa> listaPessoa = new List<pessoa>();

            //Carrega as listas declaradas com os respectivos administradores
            listaAdm = gerenciar.exibirAdministrador(retornaCodigoAdm());
            listaPessoa = gerenciar.exibirPessoa(retornaCodigoAdm());

            //Varre a lista e preenche os campos
            foreach (administrador a in listaAdm)
            {
                txtNomeAdm.Text = a.nome;
                txtCpfAdm.Text = a.cpf;
            }

            foreach (pessoa p in listaPessoa)
            {
                txtEndAdm.Text = p.endereco;
                txtTelAdm.Text = p.telefone;
                txtLoginAdm.Text = p.login;
                txtSenhaAdm.Text = p.senha;
            }
        }


        private void alterarAdm()
        {
            string codigoAdm = retornaCodigoAdm();
            string nome = txtNomeAdm.Text;
            string cpf = txtCpfAdm.Text;
            string endereco = txtEndAdm.Text;
            string telefone = txtTelAdm.Text;
            string login = txtLoginAdm.Text;
            string senha = txtSenhaAdm.Text;

            if (gerenciar.alterarAdm(codigoAdm, nome, cpf, endereco, telefone, login, senha))
                MessageBox.Show("Dados alterados com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();

        }

        private void apagarAdm()
        {

            if (gerenciar.apagarAdm(retornaCodigoAdm()))
                MessageBox.Show("Dados apagados com sucesso!");

            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();

        }

        private void desabilitarCheckBoxAlterarCampo()
        {
            cbAlterarAdm.Checked = false;
        }

        private void acaoCamposFormulario(bool acao)
        {
            txtNomeAdm.Enabled = acao;
            txtCpfAdm.Enabled = acao;
            txtEndAdm.Enabled = acao;
            txtTelAdm.Enabled = acao;
            txtLoginAdm.Enabled = acao;
            txtSenhaAdm.Enabled = acao;
        }

        private void btnAlterarAdm_Click(object sender, EventArgs e)
        {
            alterarAdm();
        }

        //Ao passar o mouse por cima
        private void comboConsultAdm_Click_1(object sender, EventArgs e)
        {
            //exibirAdm();
        }

        //Ao clicar sobre o item
        private void comboConsultAdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirAdm();
        }

        private void cbAlterarAdm_CheckedChanged(object sender, EventArgs e)
        {
            acaoCamposFormulario(cbAlterarAdm.Checked);
            habilitarBotoes(cbAlterarAdm.Checked);
        }

        private void btnApagarAdm_Click(object sender, EventArgs e)
        {
            apagarAdm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

