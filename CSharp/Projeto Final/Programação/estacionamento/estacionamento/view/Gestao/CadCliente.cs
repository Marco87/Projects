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
    public partial class CadCliente : Form
    {
        GerenciarVaga gerVaga = new GerenciarVaga();
        GerenciarTipoPlanoEstacionamento gerTipoEst = new GerenciarTipoPlanoEstacionamento();
        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarVeiculo gerVei = new GerenciarVeiculo();
        GerenciarSituacaoPagamento gerSitPag = new GerenciarSituacaoPagamento();

        Validacoes val = new Validacoes();

        Cliente clie = new Cliente();
        Veiculo veic = new Veiculo();
        TipoEstacionamento tipoEst = new TipoEstacionamento();

        public CadCliente()
        {
            InitializeComponent();
            comboTipoCliente();
            comboSituacaoCliente();
            preencherComboTipoEstacionamento();

            limparCamposCliente();
            limparCamposVeiculo();

            //dtpVencimento.Text = (DateTime.Now).ToString();

            cbSituacao.SelectedIndex = 0;
            cbSituacao.Enabled = false;

            lblVencimento.Visible = false;
            dtpVencimento.Visible = false;
        }

        private void preencherComboTipoEstacionamento()
        {
            List<string> listaTipoEst = new List<string>();
            listaTipoEst = gerTipoEst.preencherComboCunsultaTipoEstacionamento();

            for (int i = 0; i < listaTipoEst.Count; i++)
                cbTipoPlano.Items.Add(listaTipoEst[i]);
        }

        private void limparCamposCliente()
        {
            txtNome.Clear();
            mTxtTelefone.Clear();
            mTxtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            mTxtLogin.Clear();
        }

        private void limparCamposVeiculo()
        {
            cbTipoPlano.SelectedIndex = 0;
            txtModelo.Clear();
            txtMarca.Clear();
            mTxtAno.Clear();
            mTxtPlaca.Clear();
        }

        //Método para exibir o campo de vencimento apenas se o cliente possuir um plano mensal
        private void campoVencimento()
        {
            if ((val.retornarTextoSemId(cbTipoPlano.Text.Trim()) != "ROTATIVO") && (val.retornarTextoSemId(cbTipoPlano.Text.Trim()) != "DIÁRIO"))
            {
                lblVencimento.Visible = true;
                dtpVencimento.Visible = true;

                lblSituacao.Visible = true;
                cbSituacao.Visible = true;

                dtpVencimento.Text = (DateTime.Now).ToString();
            }
            else
            {
                lblVencimento.Visible = false;
                dtpVencimento.Visible = false;

                lblSituacao.Visible = false;
                cbSituacao.Visible = false;

                cbSituacao.SelectedIndex = 2;
                dtpVencimento.Text = (DateTime.Now).ToString();
            }

            lblValorPlano.Text = "R$ " + (gerTipoEst.retornarValorTipoEstacionamentoPorId(Convert.ToInt32(val.retornarIdSemTexto(cbTipoPlano.Text.Trim().ToUpper())))).ToString();
        }

        private void comboTipoCliente()
        {
            cbTipoCliente.Items.Add("PESSOA FÍSICA");
            cbTipoCliente.Items.Add("PESSOA JURÍDICA");
        }

        private void comboSituacaoCliente()
        {
            cbSituacao.Items.Add("A PAGAR");
            cbSituacao.Items.Add("PAGO");
            cbSituacao.Items.Add("NÃO POSSUI PLANO");
        }

        private void confirmarCadastroCliente()
        {
            string tipoCliente = "";
            string correcoesPreenchimento = "";

            if (cbTipoCliente.Text == "PESSOA FÍSICA")
                tipoCliente = "PF";
            else if (cbTipoCliente.Text == "PESSOA JURÍDICA")
                tipoCliente = "PJ";

            correcoesPreenchimento = val.validarCamposCadastroCliente(cbTipoCliente.Text.Trim(), txtNome.Text.Trim(), mTxtLogin.Text.Trim().ToUpper()) + val.validarCamposCadastroVeiculo(cbTipoPlano.Text.Trim(), mTxtPlaca.Text.Trim().ToUpper());

            if (string.IsNullOrEmpty(correcoesPreenchimento))
            {
                DateTime vencimento = dtpVencimento.Value;

                //Campos situação do cliente e vencimento são definidos para o caso do cliente ser Rotativo ou Diário
                if ((val.retornarTextoSemId(cbTipoPlano.Text.Trim()) == "ROTATIVO") || (val.retornarTextoSemId(cbTipoPlano.Text.Trim()) == "DIÁRIO"))
                {
                    vencimento = new DateTime(2099, 1, 1, 0, 0, 0);
                    cbSituacao.SelectedIndex = 2;
                }
                if ((gerCli.inserirCliente(txtNome.Text.Trim().ToUpper(), mTxtTelefone.Text.Trim(), mTxtCelular.Text.Trim(), txtEmail.Text.Trim().ToUpper(), txtEndereco.Text.Trim().ToUpper(), mTxtLogin.Text.Trim().ToUpper(), tipoCliente)) &&
                    ((gerVei.inserirVeiculo(mTxtPlaca.Text.Trim().ToUpper(), txtMarca.Text.Trim().ToUpper(), txtModelo.Text.Trim().ToUpper(), mTxtAno.Text.Trim())) &&
                    ((gerSitPag.inserirSituacaoPagamento(Convert.ToInt32(val.retornarIdSemTexto(cbTipoPlano.Text.Trim())), cbSituacao.Text.Trim().ToUpper(), vencimento)))))
                {
                    MessageBox.Show("Dados incluídos com sucesso!");
                    limparCamposCliente();
                    limparCamposVeiculo();
                    this.Hide();
                }
                else
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
            }
            else
                MessageBox.Show(correcoesPreenchimento);
        }

        private void cbTipoPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            campoVencimento();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            confirmarCadastroCliente();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCamposCliente();
            limparCamposVeiculo();
        }

        private void btnProxTela2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnAntTela1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnProxTela3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnAntTela2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void mTxtLogin_Leave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }




    }
}
