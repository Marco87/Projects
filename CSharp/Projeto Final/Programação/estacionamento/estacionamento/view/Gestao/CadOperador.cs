using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Model;
using Estacionamento.Controller;

namespace Estacionamento.View.Gestao
{
    public partial class CadOperador : Form
    {
        GerenciarOperador gerOpe = new GerenciarOperador();

        Validacoes val = new Validacoes();

        public CadOperador()
        {
            InitializeComponent();
            limparCampos();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            mTxtTelefone.Clear();
            mTxtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
        }

        private void confirmarCadastro()
        {
            string validarCampos = val.validarCamposCadastroOperador(txtNome.Text.Trim(), txtLogin.Text.Trim(), txtSenha.Text.Trim(), txtConfirmarSenha.Text.Trim());

            if (validarCampos == "")
            {
                if (gerOpe.inserirOperador(txtNome.Text.ToUpper().Trim(), mTxtTelefone.Text.Trim(), mTxtCelular.Text.Trim(), txtEmail.Text.Trim().ToUpper(), txtEndereco.Text.ToUpper().Trim(), txtLogin.Text.Trim().ToUpper(), txtSenha.Text.Trim(),Globais.tipoFuncionario))
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCampos();
                    this.Hide();
                }
                else
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
            }
            else
                MessageBox.Show(validarCampos);
        }

        private void btnCadOperador_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {

        }

        private void CadOperador_Load(object sender, EventArgs e)
        {

        }

    }
}
