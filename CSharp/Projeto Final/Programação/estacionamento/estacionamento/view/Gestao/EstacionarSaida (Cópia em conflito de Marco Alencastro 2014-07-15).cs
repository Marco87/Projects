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
    public partial class EstacionarSaida : Form
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

        public EstacionarSaida()
        {
            InitializeComponent();
            ocultarCampos(false);

            mTxtConsultar.Focus();
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

            if (pagamento == -1)
            {
                MessageBox.Show("A placa digitada não foi encontrada no sistema!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtConsultar.Clear();
                ocultarCampos(false);
            }
            else if (!gerContEst.verificarSeVeiculoEstacionou(pagamento))
            {
                MessageBox.Show("O veículo não deu entrada no estacionamento!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtConsultar.Clear();
                ocultarCampos(false);
                //return false;
            }
            else
            {
                preencherCampos();
                ocultarCampos(true);
                //return true;
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
            lblDataHoraEntradaCliente.Text = (gerContEst.retornarDataHoraEntradaEstacionamento(Convert.ToInt32(pagamento))).ToString();
            lblTipoEstacionamentoCliente.Text = gerTipEst.retornarDescricaoTipoEstacionamentoPorId(gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo));
            
            //Início do tratamento para verificar quanto tempo o cliente ficou no estacionamento, qual o plano e o valor a ser pago
            double valorEstacionamento = gerTipEst.retornarValorTipoEstacionamentoPorId(gerSitPag.retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(cliente, veiculo));

            TimeSpan diferença = DateTime.Now.Subtract((gerContEst.retornarDataHoraEntradaEstacionamento(Convert.ToInt32(pagamento))));
            double tempoDiferenca = 0;

            if (lblTipoEstacionamentoCliente.Text == "ROTATIVO")
            {
                tempoDiferenca = diferença.TotalHours;
            }
            else if (lblTipoEstacionamentoCliente.Text == "DIÁRIO")
            {
                tempoDiferenca = diferença.Days;
            }
            else
            {
                lblValorEstacionamento.Text = "0";
            }

            lblValorEstacionamento.Text = (valorEstacionamento * tempoDiferenca).ToString("0.00");
        }

        private void emitirComprovante()
        {
            string dados;

            dados = "Dados da saída do veículo\n\n\n";
            dados += "Data/Hora da Entrada - " + lblDataHoraEntradaCliente.Text + "\n";
            dados += "Data/Hora da Saída - " + lblDataHoraSaidaCliente.Text + "\n";
            dados += "Vaga - " + lblVagaCliente.Text + "\n";
            dados += "Placa do Veículo - " + lblVeiculoCliente.Text + "\n";
            dados += "Cliente - " + lblNomeCliente.Text + "\n";
            dados += "Tipo de Estacionamento - " + lblTipoEstacionamentoCliente.Text + "\n";
            dados += "Valor - R$ " + lblValorEstacionamento.Text + "\n";

            string nomeDocumento = "Saída - " + lblNomeCliente.Text;

            gerPdf.gerarPDFEstacionar(nomeDocumento, dados);
        }

        private void preencherCampos()
        {
            preencherCamposCliente();
            preencherCamposVeiculo();
            preencherCamposPagamento();
            lblDataHoraSaidaCliente.Text = (DateTime.Now).ToString();
        }

        private void confirmarSaida()
        {
            DateTime entrada = Convert.ToDateTime(lblDataHoraEntradaCliente.Text);
            DateTime saida = Convert.ToDateTime(lblDataHoraSaidaCliente.Text);

            if (gerContEst.inserirSaidaEstacionamento(pagamento, entrada, saida, float.Parse(lblValorEstacionamento.Text)))
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

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            validarConsulta();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEmitirComprovante_Click(object sender, EventArgs e)
        {
            emitirComprovante();
        }

        private void btnConfirmarSaida_Click(object sender, EventArgs e)
        {
            confirmarSaida();
        }
    }
}
