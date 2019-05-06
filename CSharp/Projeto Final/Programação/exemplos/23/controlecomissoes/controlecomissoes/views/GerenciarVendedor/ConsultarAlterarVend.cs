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

namespace ControleComissoes.Views.GerenciarVendedor
{
    public partial class ConsultarAlterarVend : Form
    {
        GerenciarVended gerenciar = new GerenciarVended();

        public ConsultarAlterarVend()
        {
            InitializeComponent();
            preencherComboConsultaVend();
            habilitarBotoes(false);
            desabilitarCheckBoxAlterarCampo();
            acaoCamposFormulario(false);
            limparCampos();
        }

        private string retornaCodigoVend()
        {
            //Retorna o código do vendedor a ser exibido
            string vend = comboConsultVendedor.Text;
            string[] ve = vend.Split('-');
            return ve[0];
        }

        private void limparCampos()
        {
            txtNomeVendedor.Clear();
            txtCpfVendedor.Clear();
            txtEndVendedor.Clear();
            txtTelVendedor.Clear();
            txtLoginVendedor.Clear();
            txtSenhaVendedor.Clear();
        }

        private void habilitarBotoes(bool acao)
        {
            btnAlterarVendedor.Visible = acao;
            btnApagarVendedor.Visible = acao;
        }

        private void preencherComboConsultaVend()
        {
            List<string> listaVend = new List<string>();
            listaVend = gerenciar.preencherComboConsultaVendedor();

            for (int i = 0; i < listaVend.Count; i++)
                comboConsultVendedor.Items.Add(listaVend[i]);
        }

        private void exibirVend()
        {
            limparCampos();

            //Declaração das listas de vendedor e pessoa
            List<vendedor> listaVend = new List<vendedor>();
            List<pessoa> listaPessoa = new List<pessoa>();

            //Carrega as listas declaradas com os respectivos vendedores
            listaVend = gerenciar.exibirVendedor(retornaCodigoVend());
            listaPessoa = gerenciar.exibirPessoa(retornaCodigoVend());

            //Varre a lista e preenche os campos
            foreach (vendedor v in listaVend)
            {
                txtNomeVendedor.Text = v.nome;
                txtCpfVendedor.Text = v.cpf;
            }

            foreach (pessoa p in listaPessoa)
            {
                txtEndVendedor.Text = p.endereco;
                txtTelVendedor.Text = p.telefone;
                txtLoginVendedor.Text = p.login;
                txtSenhaVendedor.Text = p.senha;
            }
        }

        private void alterarVend()
        {
            string codigoVend = retornaCodigoVend();
            string nome = txtNomeVendedor.Text;
            string cpf = txtCpfVendedor.Text;
            string endereco = txtEndVendedor.Text;
            string telefone = txtTelVendedor.Text;
            string login = txtLoginVendedor.Text;
            string senha = txtSenhaVendedor.Text;

            if (gerenciar.alterarVendedor(codigoVend, nome, cpf, endereco, telefone, login, senha))
                MessageBox.Show("Dados alterados com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }

        private void apagarVend()
        {

            if (gerenciar.apagarVendedor(retornaCodigoVend()))
                MessageBox.Show("Dados apagados com sucesso!");

            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
            
        }

        private void desabilitarCheckBoxAlterarCampo()
        {
            cbAlterarVendedor.Checked = false;
        }

        private void acaoCamposFormulario(bool acao)
        {
            txtNomeVendedor.Enabled = acao;
            txtCpfVendedor.Enabled = acao;
            txtEndVendedor.Enabled = acao;
            txtTelVendedor.Enabled = acao;
            txtLoginVendedor.Enabled = acao;
            txtSenhaVendedor.Enabled = acao;
        }

        private void btnApagarVendedor_Click(object sender, EventArgs e)
        {
            apagarVend();
        }

        private void btnAlterarVendedor_Click(object sender, EventArgs e)
        {
            alterarVend();
        }

        private void comboConsultVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirVend();
        }

        private void cbAlterarVendedor_CheckedChanged(object sender, EventArgs e)
        {
            acaoCamposFormulario(cbAlterarVendedor.Checked);
            habilitarBotoes(cbAlterarVendedor.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
