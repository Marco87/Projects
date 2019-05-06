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
    public partial class InserirVendedor : Form
    {

        GerenciarVended gerenciar = new GerenciarVended();

        public InserirVendedor()
        {
            InitializeComponent();
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

        private void inserirVendedor()
        {
            
                vendedor vend = new vendedor();
                pessoa pessoa = new pessoa();

                string nome = txtNomeVendedor.Text;
                string cpf = txtCpfVendedor.Text;
                string endereco = txtEndVendedor.Text;
                string telefone = txtTelVendedor.Text;
                string login = txtLoginVendedor.Text;
                string senha = txtSenhaVendedor.Text;

                if (gerenciar.inserirVendedor(nome, cpf, endereco, telefone, login, senha))
                MessageBox.Show("Dados inseridos com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }

        private void btnCadastroVendedor_Click(object sender, EventArgs e)
        {
            inserirVendedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
