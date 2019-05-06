using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Model;

namespace Estacionamento.View.Gestao
{
    public partial class CadTipoEstacionamento : Form
    {
        GerenciarTipoPlanoEstacionamento gerTipo = new GerenciarTipoPlanoEstacionamento();

        public CadTipoEstacionamento()
        {
            InitializeComponent();
            carregarComboMeses();
        }

        //Limpa os campos do formulário
        private void limparCampos()
        {
            txtDescricao.Clear();
            mTxtValor.Clear();
            cbMeses.SelectedIndex = 0;
        }

        //Carrega a combo com a quantidade de meses disponíveis para os planos
        private void carregarComboMeses()
        {
            cbMeses.Items.Add("1");
            cbMeses.Items.Add("2");
            cbMeses.Items.Add("3");
            cbMeses.Items.Add("4");
            cbMeses.Items.Add("5");
            cbMeses.Items.Add("6");
            cbMeses.Items.Add("7");
            cbMeses.Items.Add("8");
            cbMeses.Items.Add("9");
            cbMeses.Items.Add("10");
            cbMeses.Items.Add("11");
            cbMeses.Items.Add("12");
        }

        //Verifica se há campos em branco
        private bool verificarCamposEmBranco()
        {
            if (txtDescricao.Text.Trim() == "" || mTxtValor.Text.Trim() == "," || cbMeses.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void confirmarCadastro()
        {
            if (!verificarCamposEmBranco())
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            else
            {
                if (gerTipo.inserirTipoEstacionamento(txtDescricao.Text.ToUpper(), mTxtValor.Text, cbMeses.Text.Trim()))
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCampos();
                    this.Hide();
                }
                else
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
            }
        }

        private void btnCadTipoEstacionamento_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
