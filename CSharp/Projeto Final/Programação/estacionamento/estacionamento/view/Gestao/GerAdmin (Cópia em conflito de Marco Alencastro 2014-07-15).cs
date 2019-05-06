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
    public partial class GerAdmin : Form
    {
        GerenciarAdministrador gerAdm = new GerenciarAdministrador();

        public GerAdmin()
        {
            InitializeComponent();
            bloquearCampos();
            limparCampos();
            ocultarCampos(false);

            checkAlterarAdmin.Checked = false;
            
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
            checkAlterarAdmin.Checked = false;
        }

        //Oculta a groupBox, e só exibe os campos caso o login digitado seja válido
        private void ocultarCampos(bool valida)
        {
            groupBox1.Visible = valida;
            btnLimparCampos.Visible = valida;
            btnApagarAdmin.Visible = valida;
            btnAltAdmin.Visible = valida;
            lblCamposObrigatorios.Visible = valida;
        }

        public void bloquearCampos()
        {
            if (checkAlterarAdmin.Checked == true)
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

        private void checkAlterarAdmin_CheckedChanged(object sender, EventArgs e)
        {
            bloquearCampos();
        }

        private void exibirAdmin()
        {
            limparCampos();

            //Declaração da lista de administrador
            List<usuario> listaAdmin = new List<usuario>();

            //Carrega a lista declarada
            
            listaAdmin = gerAdm.exibirAdministrador(txtConsultarLogin.Text.ToUpper().Trim());

            //Verifica se a lista contém pelo menos uma linha preenchida (um valor encontrado)
            if (listaAdmin.Count > 0)
            {
                //Varre a lista e preenche os campos
                foreach (usuario u in listaAdmin)
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
            }
            else
            {
                MessageBox.Show("O login digitado não foi encontrado no sistema!");
            }
        }

        private void alterarAdmin()
        {
            if (gerAdm.alterarAdministrador(txtNome.Text.ToUpper().Trim(), mTxtTelefone.Text.Trim(), mTxtCelular.Text.Trim(), txtEmail.Text.Trim().ToUpper(), txtEndereco.Text.ToUpper().Trim(), txtLogin.Text.Trim().ToUpper(), txtSenha.Text.Trim()))
            {
                MessageBox.Show("Dados alterados com sucesso!");
            }
            else
            {
                MessageBox.Show("Houve algum erro interno, tente novamente!");
            }

        }

        private void apagarAdmin()
        {

            if (MessageBox.Show("Tem certeza que deseja apagar estes dados?", "Excluir placa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (gerAdm.apagarAdministrador(txtLogin.Text.ToUpper().Trim()))
                {
                    MessageBox.Show("Dados excluídos com sucesso!");
                    limparCampos();
                    txtConsultarLogin.Text = "";
                }
                else
                {
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
                }
            }

        }

        private void btnConsultarLogin_Click(object sender, EventArgs e)
        {
            exibirAdmin();
        }

        private void btnAltAdmin_Click(object sender, EventArgs e)
        {
            alterarAdmin();
        }

        private void btnApagarAdmin_Click(object sender, EventArgs e)
        {
            apagarAdmin();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtConsultarLogin.Clear();
            limparCampos();
            ocultarCampos(false);
        }

        
    }
}
