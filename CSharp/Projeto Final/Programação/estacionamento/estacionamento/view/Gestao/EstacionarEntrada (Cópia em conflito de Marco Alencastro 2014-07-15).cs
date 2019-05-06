using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Model;
using Estacionamento.Controller;

namespace Estacionamento.View.Gestao
{
    public partial class EstacionarEntrada : Form
    {
        Validacoes val = new Validacoes();

        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarVeiculo gerVei = new GerenciarVeiculo();
        GerenciarSituacaoPagamento gerSitPag = new GerenciarSituacaoPagamento();
        GerenciarTipoPlanoEstacionamento gerTipEst = new GerenciarTipoPlanoEstacionamento();
        GerenciarControleEstacionamento gerContEst = new GerenciarControleEstacionamento();

        GerarPDF gerPdf = new GerarPDF();

        //Variáveis locais para armazenar os ids
        int cliente;
        int veiculo;
        int pagamento;

        public EstacionarEntrada()
        {
            InitializeComponent();
            mTxtConsultar.Focus();

            ocultarCampos(false);
        }

        private void ocultarCampos(bool valida)
        {
            groupBox1.Visible = valida;
        }

        private void validarConsulta()
        {
            if ((mTxtConsultar.Text.Trim() == "") || (mTxtConsultar.Text.Trim().Length < 8))
            {
                MessageBox.Show("O campo de consulta deve ser preenchido, e deve conter 7 dígitos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtConsultar.Focus();
            }
            else
                consultarPlaca();
        }

        private void consultarPlaca()
        {
            cliente = gerVei.retornarIdClientePorPlaca(mTxtConsultar.Text.Trim().ToUpper());
            veiculo = gerVei.retornarIdVeiculoPorPlaca(mTxtConsultar.Text.Trim().ToUpper());
            pagamento = gerSitPag.retornarIdSituacaoPorIdClienteIdVeiculo(cliente, veiculo);

            if (pagamento != -1)
            {
                preencherCampos();
                ocultarCampos(true);
                //return true;
            }
            else
            {
                MessageBox.Show("A placa digitada não foi encontrada no sistema!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtConsultar.Clear();
                ocultarCampos(false);
                //return false;
            }
        }

        private void preencherCamposCliente()
        {
            lblNomeCliente.Text = gerCli.retornarNomeClientePorId(cliente);
        }

        private void preencherCamposVeiculo()
        {
            lblVeiculoCliente.Text = mTxtConsultar.Text.Trim().ToUpper();
        }

        private void preencherCamposPagamento()
        {

            lblTipoEstacionamentoCliente.Text = gerTipEst.retornarDescricaoTipoEstacionamentoPorId(gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo));
        }

        private void preencherCampos()
        {
            preencherCamposCliente();
            preencherCamposVeiculo();
            preencherCamposPagamento();
            lblDataHoraEntradaCliente.Text = (DateTime.Now).ToString();
        }

        private void confirmarEntrada()
        {
            if (gerContEst.inserirEntradaEstacionamento(pagamento, DateTime.Now, 0))
            {
                MessageBox.Show("Dados incluídos com sucesso!");
                emitirComprovante();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Houve algum erro interno, tente novamente!");
            }
        }

        private void emitirComprovante()
        {
            string dados;

            dados = "Dados da entrada do veículo\n\n\n";
            dados += "Data/Hora da Entrada - " + lblDataHoraEntradaCliente.Text + "\n";
            //dados += "Vaga - " + lblVaga.Text + "\n";
            dados += "Placa do Veículo - " + lblVeiculoCliente.Text + "\n";
            dados += "Cliente - " + lblNomeCliente.Text + "\n";
            dados += "Tipo de Estacionamento - " + lblTipoEstacionamentoCliente.Text + "\n";

            string nomeDocumento = "Entrada - " + lblNomeCliente.Text;

            gerPdf.gerarPDFEstacionar(nomeDocumento, dados);
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            validarConsulta();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmarEntrada_Click(object sender, EventArgs e)
        {
            confirmarEntrada();
        }

        private void EstacionarEntrada_Load(object sender, EventArgs e)
        {

        }

        private void btnEmitirComprovante_Click(object sender, EventArgs e)
        {
            emitirComprovante();
        }

    }
}
