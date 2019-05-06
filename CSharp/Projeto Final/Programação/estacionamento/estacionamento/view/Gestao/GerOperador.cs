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
    public partial class GerOperador : Form
    {
        GerenciarOperador gerOpe = new GerenciarOperador();

        public GerOperador()
        {
            InitializeComponent();
            bloquearCampos();
            limparCampos();
            ocultarCampos(false);

            checkAlterarOperador.Checked = false;
        }

        public void limparCampos()
        {
            txtNome.Clear();
            mTxtTelefone.Clear();
            mTxtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            checkAlterarOperador.Checked = false;
            ocultarCampos(false);
        }

        //Oculta a groupBox, e só exibe os campos caso o login digitado seja válido
        private void ocultarCampos(bool valida)
        {
            groupBox1.Visible = valida;
            btnLimparCampos.Visible = valida;
            btnApagarOperador.Visible = valida;
            btnAltOperador.Visible = valida;
            lblCamposObrigatorios.Visible = valida;
        }

        public void bloquearCampos()
        {
            if (checkAlterarOperador.Checked == true)
            {
                txtNome.Enabled = true;
                mTxtTelefone.Enabled = true;
                mTxtCelular.Enabled = true;
                txtEmail.Enabled = true;
                txtEndereco.Enabled = true;
                //txtLogin.Enabled = true;
                txtSenha.Enabled = true;
            }
            else
            {
                txtNome.Enabled = false;
                mTxtTelefone.Enabled = false;
                mTxtCelular.Enabled = false;
                txtEmail.Enabled = false;
                txtEndereco.Enabled = false;
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
            }
        }

        private void exibirOpe()
        {
            limparCampos();

            //Declaração da lista de administrador
            List<usuario> listaOpe = new List<usuario>();

            //Carrega a lista declarada

            listaOpe = gerOpe.exibirOperador(txtConsultarLogin.Text.ToUpper().Trim());

            //Verifica se a lista contém pelo menos uma linha preenchida (um valor encontrado)
            if (listaOpe.Count > 0)
            {
                GerOperador.ActiveForm.Height = 353;
                //Varre a lista e preenche os campos
                foreach (usuario u in listaOpe)
                {
                    txtNome.Text = u.nome;
                    mTxtTelefone.Text = u.telefone;
                    mTxtCelular.Text = u.celular;
                    txtEmail.Text = u.email;
                    txtEndereco.Text = u.endereco;
                    txtLogin.Text = u.login;
                    txtSenha.Text = u.senha;
                }

                ocultarCampos(true);
                GerOperador.ActiveForm.Height = 89;
            }
            else
            {
                GerOperador.ActiveForm.Height = 89;
                MessageBox.Show("O login digitado não foi encontrado no sistema!");
            }
        }

        private void alterarOpe()
        {
            if (gerOpe.alterarOperador(txtNome.Text.ToUpper().Trim(), mTxtTelefone.Text.Trim(), mTxtCelular.Text.Trim(), txtEmail.Text.Trim().ToUpper(), txtEndereco.Text.ToUpper().Trim(), txtLogin.Text.Trim().ToUpper(), txtSenha.Text.Trim()))
            {
                MessageBox.Show("Dados alterados com sucesso!");
                GerOperador.ActiveForm.Height = 89;
            }
            else
            {
                MessageBox.Show("Houve algum erro interno, tente novamente!");
                GerOperador.ActiveForm.Height = 89;
            }

        }

        private void apagarOpe()
        {

            GerOperador.ActiveForm.Height = 353;
            if (MessageBox.Show("Tem certeza que deseja apagar estes dados?", "Excluir placa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (gerOpe.apagarOperador(txtLogin.Text.ToUpper().Trim()))
                {
                    MessageBox.Show("Dados excluídos com sucesso!");
                    limparCampos();
                    txtConsultarLogin.Text = "";
                    GerOperador.ActiveForm.Height = 89;
                }
                else
                {
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
                    GerOperador.ActiveForm.Height = 89;
                }
            }

        }

        private void btnAltOperador_Click(object sender, EventArgs e)
        {
            alterarOpe();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtConsultarLogin.Clear();
            limparCampos();
            ocultarCampos(false);
        }

        private void btnConsultarLogin_Click(object sender, EventArgs e)
        {
            exibirOpe();
        }

        private void btnApagarOperador_Click(object sender, EventArgs e)
        {
            apagarOpe();
            ocultarCampos(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkAlterarOperador_CheckedChanged(object sender, EventArgs e)
        {
            bloquearCampos();
        }
    }
}
