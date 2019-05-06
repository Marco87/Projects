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


namespace ControleComissoes.Views.GerenciarClientePJ
{
    public partial class InserirClientePJ : Form
    {
        GerenciarCliPJ gerenciar = new GerenciarCliPJ();

        public InserirClientePJ()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtRazaoSocialPJ.Clear();
            txtCnpjPJ.Clear();
            txtEndPJ.Clear();
            txtTelPJ.Clear();
            txtLoginPJ.Clear();
            txtSenhaPJ.Clear();
        }


        private void inserirPJ()
        {
            string razao = txtRazaoSocialPJ.Text;
            string cnpj = txtCnpjPJ.Text;
            string endereco = txtEndPJ.Text;
            string telefone = txtTelPJ.Text;
            string login = txtLoginPJ.Text;
            string senha = txtSenhaPJ.Text;

            if (gerenciar.inserirPJ(razao, cnpj, endereco, telefone, login, senha))
                MessageBox.Show("Dados inseridos com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }


        private void btnCadastroPJ_Click(object sender, EventArgs e)
        {
            inserirPJ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
