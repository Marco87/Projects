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
    public partial class InserirAdm : Form
    {
        GerenciarAdministrador gerenciar = new GerenciarAdministrador();

        public InserirAdm()
        {
            InitializeComponent();
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

        private void inserirAdmin()
        {
            administrador adm = new administrador();
            pessoa pessoa = new pessoa();

            string nome = txtNomeAdm.Text;
            string cpf = txtCpfAdm.Text;
            string endereco = txtEndAdm.Text;
            string telefone = txtTelAdm.Text;
            string login = txtLoginAdm.Text;
            string senha = txtSenhaAdm.Text;

            if (gerenciar.inserirAdm(nome, cpf, endereco, telefone, login, senha))
                MessageBox.Show("Dados inseridos com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }

        private void btnCadastroAdm_Click(object sender, EventArgs e)
        {
            inserirAdmin();
        }

        private void txtCpfAdm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

