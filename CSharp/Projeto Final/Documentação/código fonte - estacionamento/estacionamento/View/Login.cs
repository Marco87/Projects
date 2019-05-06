using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.View;
using Estacionamento.View.Gestao;
using Estacionamento.Model;
using  Estacionamento.Controller;

namespace Estacionamento
{
    public partial class Login : Form
    {
        public int count_login = 0;
        GerenciarAdministrador gerAdm = new GerenciarAdministrador();
        GerenciarOperador gerOpe = new GerenciarOperador();
        Principal principalForm = new Principal();
        

        public Login()
        {
            count_login = count_login + 1;
            InitializeComponent();

        }

        private void btnTelaAdm_Click(object sender, EventArgs e)
        {
            TelaAdmin telaAdm = new TelaAdmin();
            telaAdm.Show();
            this.Hide();
            //Login.ActiveForm.Close();
        }

        private void btnTelaOpe_Click(object sender, EventArgs e)
        {
            TelaOperador telaOpe = new TelaOperador();
            telaOpe.Show();
            this.Hide();
            //this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (count_login <= 3)
            {
                if (gerOpe.consultarLoginOperador(txtLogin.Text, txtSenha.Text))
                {
                    Globais._usuario = txtLogin.Text;
                    Globais._senha = txtSenha.Text;
                    this.Dispose();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos. Tente Novamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count_login = count_login + 1;
 
                }   
            }
             else
                 Environment.Exit(0);
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool valida()
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Login inválido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return false;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha inválida.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            return true;

        }

       protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }

       private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
       {
           if ((Keys)e.KeyChar == Keys.Enter)
           {
               txtSenha.Focus();
           }
       }

       private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
       {
           if ((Keys)e.KeyChar == Keys.Enter)
           {
               btnLogin.Focus();
           }
       }

    }
}
 
