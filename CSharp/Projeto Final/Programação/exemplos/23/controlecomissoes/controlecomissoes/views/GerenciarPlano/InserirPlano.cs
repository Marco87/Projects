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

namespace ControleComissoes.Views.GerenciarPlano
{
    public partial class InserirPlano : Form
    {
        GerenciarPlan gerenciar = new GerenciarPlan();

        public InserirPlano()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtDescPlano.Clear();
            txtTipoPlano.Clear();
            txtValorPlano.Clear();
        }


        private void inserirPlano()
        {
            plano pl = new plano();

            string descricao = txtDescPlano.Text;
            int tipo = Convert.ToInt32(txtTipoPlano.Text);
            float valor = Convert.ToInt64(txtValorPlano.Text);
            
            if (gerenciar.inserirPlano(descricao, tipo, valor))
                MessageBox.Show("Dados inseridos com sucesso!");
            else
                MessageBox.Show("A operação não pôde ser concluída!");

            limparCampos();
        }


        private void btnCadastroPlano_Click(object sender, EventArgs e)
        {
            inserirPlano();
        }

        private void txtTipoPlano_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Pacote de dados\n" +
                            "2 - Pacote de voz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
