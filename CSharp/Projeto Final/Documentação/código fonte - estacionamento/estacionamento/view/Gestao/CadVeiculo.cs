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
    public partial class CadVeiculo : Form
    {
        GerenciarVeiculo gerVei = new GerenciarVeiculo();
        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarTipoPlanoEstacionamento gerTipoEst = new GerenciarTipoPlanoEstacionamento();
        GerenciarSituacaoPagamento gerSitPag = new GerenciarSituacaoPagamento();

        Cliente cli = new Cliente();

        Validacoes val = new Validacoes();

        public int idClienteCadastrado;

        public CadVeiculo()
        {
            InitializeComponent();
            txtCliente.Enabled = false;
            preencherCampoCliente();
            limparCampos();
            preencherComboTipoEstacionamento();
        }

        private void preencherComboTipoEstacionamento()
        {
            List<string> listaTipoEst = new List<string>();
            listaTipoEst = gerTipoEst.preencherComboCunsultaTipoEstacionamento();

            for (int i = 0; i < listaTipoEst.Count; i++)
                cbTipoPlano.Items.Add(listaTipoEst[i]);
        }

        public void limparCampos()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            mTxtAno.Clear();
            mTxtPlaca.Clear();
        }

        public void carregarNomeTitular()
        {
            txtCliente.Text = gerCli.retornarNomeClientePorId(cli.idCliente);
        }

        private void preencherCampoCliente()
        {
            txtCliente.Text = gerCli.retornarNomeClientePorId(idClienteCadastrado);
        }

        private void confirmarCadastro()
        {
            string validarCampos = val.validarCamposCadastroVeiculo(cbTipoPlano.Text.Trim(), mTxtPlaca.Text.ToUpper().Trim());

            if (txtCliente.Text == "")
                MessageBox.Show("Um titular deve ser escolhido para que a operação seja executada! \n");
            else if (validarCampos == "")
            {
                if (gerVei.inserirVeiculo(mTxtPlaca.Text.Trim().ToUpper(), txtMarca.Text.Trim().ToUpper(), txtModelo.Text.ToUpper().Trim(), mTxtAno.Text.ToUpper().Trim()) &&
                    gerSitPag.inserirSituacaoPagamento(Convert.ToInt32(val.retornarIdSemTexto(cbTipoPlano.Text.Trim().ToUpper())), null, DateTime.Now.AddMonths(1)))
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCampos();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
                }
            }
            else
            {
                MessageBox.Show(validarCampos);
            }
        }


        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
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
