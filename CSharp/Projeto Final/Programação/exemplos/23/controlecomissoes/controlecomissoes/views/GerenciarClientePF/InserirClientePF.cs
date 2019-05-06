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


namespace ControleComissoes.Views.GerenciarClientePF
{
    public partial class InserirClientePF : Form
    {
        GerenciarCliPF gerenciar = new GerenciarCliPF();

        public InserirClientePF()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNomePF.Clear();
            txtCpfPF.Clear();
            txtEndPF.Clear();
            txtTelPF.Clear();
            txtLoginPF.Clear();
            txtSenhaPF.Clear();
        }

        private void inserirPF()
        {
            string nome = txtNomePF.Text;
            string cpf = txtCpfPF.Text;
            string endereco = txtEndPF.Text;
            string telefone = txtTelPF.Text;
            string login = txtLoginPF.Text;
            string senha = txtSenhaPF.Text;

            if (gerenciar.inserirPF(nome, cpf, endereco, telefone, login, senha))
                MessageBox.Show("Dados inseridos com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }


        private void btnCadastroPF_Click(object sender, EventArgs e)
        {
            inserirPF();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
