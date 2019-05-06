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
using ControleComissoes.Views.GerenciarAdm;
using ControleComissoes.Views.GerenciarClientePF;
using ControleComissoes.Views;

namespace ControleComissoes
{
    public partial class Login : Form
    {
        Validacoes validacoes = new Validacoes();
        GerenciarAdministrador gerAdm = new GerenciarAdministrador();
        GerenciarCliPF gerPF = new GerenciarCliPF();
        GerenciarCliPJ gerPJ = new GerenciarCliPJ();
        GerenciarVended gerVend = new GerenciarVended();

        //Telas telas = new Telas();
        //TelasVendedor telasVend = new TelasVendedor();

        public int codigoUsuarioLogado;
        public string nomeUsuarioLogado;


        public Login()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void logarUsuario()
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            int codigo = validacoes.login(login, senha);
            if (codigo != -1)
            {
                codigoUsuarioLogado = codigo;

                if (gerAdm.nomeAdm(codigo) != null)
                {
                    MessageBox.Show("Bem vindo ao sistema " + gerAdm.nomeAdm(codigo));
                    nomeUsuarioLogado = gerAdm.nomeAdm(codigo);
                    
                    Telas telas = new Telas();
                    telas.Show();
                }
                /*
                else if (gerPF.nomeCliPF(codigo) != null)
                {
                    MessageBox.Show("Bem vindo ao sistema " + gerPF.nomeCliPF(codigo));
                    nomeUsuarioLogado = gerPF.nomeCliPF(codigo);
                }
                else if (gerPJ.nomeCliPJ(codigo) != null)
                {
                    MessageBox.Show("Bem vindo ao sistema " + gerPJ.nomeCliPJ(codigo));
                    nomeUsuarioLogado = gerPJ.nomeCliPJ(codigo);
                }
                 */
                else if (gerVend.nomeVend(codigo) != null)
                {
                    MessageBox.Show("Bem vindo ao sistema " + gerVend.nomeVend(codigo));
                    nomeUsuarioLogado = gerVend.nomeVend(codigo);

                    TelasVendedor telasVend = new TelasVendedor();
                    telasVend.Show();
                }
                else
                    MessageBox.Show("Login e/ou senha incorretos!");

            }
            else
                MessageBox.Show("Login e/ou senha incorretos!");

            limparCampos();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            logarUsuario();
        }

    }
}
