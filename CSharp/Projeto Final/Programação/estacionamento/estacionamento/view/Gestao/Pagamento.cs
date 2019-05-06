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
    public partial class Pagamento : Form
    {
        GerenciarVeiculo gerVei = new GerenciarVeiculo();
        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarControleEstacionamento gerContEst = new GerenciarControleEstacionamento();
        GerenciarSituacaoPagamento gerSitPag = new GerenciarSituacaoPagamento();
        GerenciarTipoPlanoEstacionamento gerTipEst = new GerenciarTipoPlanoEstacionamento();
        GerarPDF gerPdf = new GerarPDF();

        public string placaVeiculo;

        //Variáveis locais para armazenar os ids
        int cliente;
        int veiculo;
        int pagamento;

        public Pagamento()
        {
            InitializeComponent();
        }

        public void consultarPlaca()
        {
            cliente = gerVei.retornarIdClientePorPlaca(placaVeiculo);
            veiculo = gerVei.retornarIdVeiculoPorPlaca(placaVeiculo);
            pagamento = gerSitPag.retornarIdSituacaoPorIdClienteIdVeiculo(cliente, veiculo);

            if (pagamento != -1)
            {
                preencherCampos();
                //return true;
            }
            else
            {
                MessageBox.Show("A placa digitada não foi encontrada no sistema!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
        }

        private void preencherCamposCliente()
        {
            lblNomeCliente.Text = gerCli.retornarNomeClientePorId(cliente);
        }

        private void preencherCamposVeiculo()
        {
            lblVeiculoCliente.Text = placaVeiculo.Trim().ToUpper();
        }

        private void preencherCamposPagamento()
        {
            lblTipoEstacionamentoCliente.Text = gerTipEst.retornarDescricaoTipoEstacionamentoPorId(gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo));
            lblValorEstacionamento.Text = "R$ " + (gerTipEst.retornarValorTipoEstacionamentoPorId(gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo))).ToString();
            lblVencimentoCliente.Text = ((gerSitPag.retornarDataDeVencimentoPorIdClienteIdVeiculo(cliente, veiculo)).AddMonths(gerSitPag.retornarMesesPagosPorIdClienteIdVeiculo(cliente, veiculo)).ToString());
        }

        private void preencherCampos()
        {
            preencherCamposCliente();
            preencherCamposVeiculo();
            preencherCamposPagamento();
            lblHoraPagamento.Text = (DateTime.Now).ToString();
        }

        private void confirmarPagamento()
        {
            int estacionamento = gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo);

            if (gerContEst.inserirPagamentoEstacionamento(pagamento, DateTime.Now, DateTime.Now, gerTipEst.retornarValorTipoEstacionamentoPorId(gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo)))
                && gerSitPag.atualizarMesesPagos(cliente, veiculo, gerTipEst.retornarQuantidadeMesesTipoEstacionamentoPorId(estacionamento)))
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

            dados = "Dados do Pagamento\n\n\n";
            dados += "Data/Hora do Pagamento - " + lblHoraPagamento.Text + "\n";
            dados += "Placa do Veículo - " + lblVeiculoCliente.Text + "\n";
            dados += "Cliente - " + lblNomeCliente.Text + "\n";
            dados += "Tipo de Estacionamento - " + lblTipoEstacionamentoCliente.Text + "\n";
            dados += "Valor - " + lblValorEstacionamento.Text + "\n";
            dados += "Vencimento - " + lblVencimentoCliente.Text + "\n";

            Random cod = new Random();

            string nomeDocumento = "Pagamento - " + lblNomeCliente.Text + cod.Next(1000, 9999) + cod.Next(1000, 9999);

            gerPdf.gerarPDFEstacionar(nomeDocumento, dados);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {
            confirmarPagamento();
        }

    }
}
