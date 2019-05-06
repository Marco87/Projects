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
using Estacionamento.Control;

namespace Estacionamento.View.Gestao
{
    public partial class EstacionarEntrada : Form
    {
        Validacoes val = new Validacoes();

        Vaga va = new Vaga();

        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarVeiculo gerVei = new GerenciarVeiculo();
        GerenciarSituacaoPagamento gerSitPag = new GerenciarSituacaoPagamento();
        GerenciarTipoPlanoEstacionamento gerTipEst = new GerenciarTipoPlanoEstacionamento();
        GerenciarControleEstacionamento gerContEst = new GerenciarControleEstacionamento();
        GerenciarVaga gerVaga = new GerenciarVaga();

        ConsuVagaAndar cva = new ConsuVagaAndar();

        GerarPDF gerPdf = new GerarPDF();

        //Variáveis locais para armazenar os ids
        public int cliente;
        public int veiculo;
        public int pagamento;
        public int vaga = 0;

        public EstacionarEntrada()
        {
            InitializeComponent();
            mTxtConsultar.Focus();

            ocultarCampos(false);

            va.identificador_vaga = 0;
        }

        private void ocultarCampos(bool valida)
        {
            groupBox1.Visible = valida;
        }

        private void validarConsulta()
        {
            if ((mTxtConsultar.Text.Trim() == "") || (mTxtConsultar.Text.Trim().Length < 8))
            {
                MessageBox.Show("O campo de consulta deve ser preenchido, e deve conter 7 dígitos.");
                mTxtConsultar.Focus();
            }
            else
                consultarPlaca();
        }

        private void consultarPlaca()
        {
            EstacionarEntrada.ActiveForm.Height = 272;
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

                EstacionarEntrada.ActiveForm.Height = 70;
                MessageBox.Show("Placa consultada não possui entrada !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void preencherCamposVaga()
        {
            vaga = va.identificador_vaga;
            lblVagaCliente.Text = vaga.ToString();
        }

        private void preencherCampos()
        {
            preencherCamposCliente();
            preencherCamposVeiculo();
            preencherCamposPagamento();
            lblDataHoraEntradaCliente.Text = (DateTime.Now).ToString();
            preencherCamposVaga();
        }

        private void confirmarEntrada()
        {
            vaga = va.identificador_vaga;

            if(lblVagaCliente.Text == "0")
            {
                MessageBox.Show("Selecione a vaga que o veículo ocupará!");
            }
            else if (gerContEst.inserirEntradaEstacionamento(pagamento, DateTime.Now, vaga))
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
            dados += "Vaga - " + lblVagaCliente.Text + "\n";
            dados += "Placa do Veículo - " + lblVeiculoCliente.Text + "\n";
            dados += "Cliente - " + lblNomeCliente.Text + "\n";
            dados += "Tipo de Estacionamento - " + lblTipoEstacionamentoCliente.Text + "\n";

            Random cod = new Random();

            string nomeDocumento = "Entrada - " + lblNomeCliente.Text + " - " + cod.Next(1000, 9999) + cod.Next(1000, 9999);

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

        private void btnSelecionarVaga_Click(object sender, EventArgs e)
        {
            cva.ShowDialog();
            preencherCamposVaga();
        }

        private void EstacionarEntrada_Load(object sender, EventArgs e)
        {

        }

        private void mTxtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnBuscaCliente.Focus();
            }
        }


    }
}
