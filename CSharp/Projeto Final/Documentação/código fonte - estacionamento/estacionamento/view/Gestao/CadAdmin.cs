using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Model;
using Estacionamento.Control;


namespace Estacionamento.View.Gestao
{
    public partial class CadAdmin : Form
    {
        GerenciarAdministrador gerAdm = new GerenciarAdministrador();

        Usuario usu = new Usuario();

        Validacoes val = new Validacoes();

        public CadAdmin()
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
            string validarCampos = val.validarCamposCadastroAdministrador(txtNome.Text.Trim().ToUpper(), txtLogin.Text.Trim().ToUpper(), txtSenha.Text.Trim(), txtConfirmarSenha.Text.Trim());

            if (validarCampos == "")
            {
                if (gerAdm.inserirAdministrador(txtNome.Text.ToUpper().Trim(), mTxtTelefone.Text.Trim(), mTxtCelular.Text.Trim(), txtEmail.Text.Trim().ToUpper(), txtEndereco.Text.ToUpper().Trim(), txtLogin.Text.Trim().ToUpper(), txtSenha.Text.Trim()))
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

        private void btnCadAdmin_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

    }
}
