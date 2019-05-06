using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Control;
using Estacionamento.Model;

namespace Estacionamento.View.Gestao
{
    public partial class GerCliente : Form
    {
        Cliente cli = new Cliente();
        Veiculo vei = new Veiculo();

        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarVeiculo gerVei = new GerenciarVeiculo();
        GerenciarTipoPlanoEstacionamento gerTipoEst = new GerenciarTipoPlanoEstacionamento();
        GerenciarSituacaoPagamento gerSitPag = new GerenciarSituacaoPagamento();
        GerenciarControleEstacionamento gerContEst = new GerenciarControleEstacionamento();

        CadVeiculo cadVei = new CadVeiculo();
        Pagamento pag = new Pagamento();

        Validacoes val = new Validacoes();

        public int idClienteCad;

        public GerCliente()
        {
            InitializeComponent();
            txtLogin.Enabled = false;
            //cbPlaca.Enabled = false;
            txtTipoCliente.Enabled = false;

            preencherComboTipoEstacionamento();

            comboSituacaoCliente();

            cbConsultar.Items.Add("CONSULTAR PELA PLACA");
            cbConsultar.Items.Add("CONSULTAR PELO IDENTIFICADOR");

            limparCamposCliente();
            limparCamposVeiculo();
            limparCamposPagamento();

            bloquearCamposCliente();
            bloquearCamposVeiculo();
            bloquearCamposPagamento();

            cbConsultar.SelectedIndex = 0;
            cbTipoPlano.SelectedIndex = 0;

            ocultarCampos(false);

        }

        //Campos ocultos na inicialiação do formulário
        private void ocultarCampos(bool valida)
        {
            tabControl1.Visible = valida;
            btnCadVeiculo.Visible = valida;
            btnEfetuarPagamento.Visible = valida;
            btnLimparCampos.Visible = valida;
            lblCamposObrigatorios.Visible = valida;
        }

        //Tratamento dos campos do cliente

        private void comboSituacaoCliente()
        {
            cbSituacao.Items.Add("A PAGAR");
            cbSituacao.Items.Add("PAGO");
            cbSituacao.Items.Add("NÃO POSSUI PLANO");
        }

        private void limparCamposCliente()
        {
            txtTipoCliente.Clear();
            txtNome.Clear();
            mTxtTelefone.Clear();
            mTxtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtLogin.Clear();
            //cbSituacao.SelectedIndex = ;
        }

        private void bloquearCamposCliente()
        {
            GerCliente.ActiveForm.Height = 446;
            if (checkAlterarCliente.Checked == true)
            {
                //txtTipoCliente.Enabled = true;
                txtNome.Enabled = true;
                mTxtTelefone.Enabled = true;
                mTxtCelular.Enabled = true;
                txtEmail.Enabled = true;
                txtEndereco.Enabled = true;
                //txtLogin.Enabled = true;
                cbSituacao.Enabled = true;
            }
            else
            {
                //txtTipoCliente.Enabled = false;
                txtNome.Enabled = false;
                mTxtTelefone.Enabled = false;
                mTxtCelular.Enabled = false;
                txtEmail.Enabled = false;
                txtEndereco.Enabled = false;
                //txtLogin.Enabled = false;
                cbSituacao.Enabled = false;
            }
            bloquearCamposVeiculo();
        }

        //Verifica se há algum cliente vinculado à placa digitada
        private bool consultarPorPlaca()
        {
            if (gerVei.retornarIdClientePorPlaca(mTxtConsultar.Text.Trim().ToUpper()) != -1)
            {
                return true;
            }
            else
                return false;
        }

        //Verifica se o login digitado pelo cliente existe no sistema
        private bool consultarPorLogin()
        {
            if (gerCli.retornarIdClientePorLogin(mTxtConsultar.Text.Trim().ToUpper()) != -1)
            {
                return true;
            }
            else
                return false;
        }

        //Exibe os dados do cliente no formulário
        private void exibirCliente()
        {
            //Caso a opção seja consultar pela placa
            if (cbConsultar.SelectedIndex == 0)
            {
                if (consultarPorPlaca())
                {
                    GerCliente.ActiveForm.Height = 446;
                    limparCamposCliente();

                    //Declaração da lista de cliente
                    List<cliente> listaCli = new List<cliente>();

                    //Carrega a lista declarada
                    listaCli = gerCli.exibirClientePorId(gerVei.retornarIdClientePorPlaca(mTxtConsultar.Text.Trim().ToUpper()));

                    //Varre a lista e preenche os campos
                    GerOperador.ActiveForm.Height = 446;
                    foreach (cliente c in listaCli)
                    {
                        limparCamposCliente();

                        txtTipoCliente.Text = c.tipoCliente;
                        txtNome.Text = c.nome;
                        mTxtTelefone.Text = c.telefone;
                        mTxtCelular.Text = c.Celular;
                        txtEmail.Text = c.email;
                        txtEndereco.Text = c.endereco;
                        txtLogin.Text = c.login;
                        //dtVencimento.Text = c.primeiroVencimento.ToString();

                        //Variável local recebe o id do cliente
                        idClienteCad = c.idCliente;
                        //Variável da classe Cliente recebe o id do cliente exibido na tela
                        cli.idCliente = c.idCliente;
                    }

                    ocultarCampos(true);
                    preencherComboPlacas(gerVei.retornarIdClientePorPlaca(mTxtConsultar.Text.Trim().ToUpper()));
                }
                else
                {
                    MessageBox.Show("A placa digitada não corresponde a nenhum cliente cadastrado!");
                    GerCliente.ActiveForm.Height = 93;
                }
            }
            //Caso a opção seja consultar por login
            else if (cbConsultar.SelectedIndex == 1)
            {
                if (consultarPorLogin())
                {
                    GerCliente.ActiveForm.Height = 446;
                    limparCamposCliente();

                    //Declaração da lista de cliente
                    List<cliente> listaCli = new List<cliente>();

                    //Carrega a lista declarada
                    listaCli = gerCli.exibirClientePorId(gerCli.retornarIdClientePorLogin(mTxtConsultar.Text.Trim().ToUpper()));

                    //Varre a lista e preenche os campos
                    foreach (cliente c in listaCli)
                    {
                        limparCamposCliente();

                        txtTipoCliente.Text = c.tipoCliente;
                        txtNome.Text = c.nome;
                        mTxtTelefone.Text = c.telefone;
                        mTxtCelular.Text = c.Celular;
                        txtEmail.Text = c.email;
                        txtEndereco.Text = c.endereco;
                        txtLogin.Text = c.login;

                        //Variável local recebe o id do cliente
                        idClienteCad = c.idCliente;
                        //Variável da classe Cliente recebe o id do cliente exibido na tela
                        cli.idCliente = c.idCliente;
                    }
                    ocultarCampos(true);
                    preencherComboPlacas(gerCli.retornarIdClientePorLogin(mTxtConsultar.Text.Trim().ToUpper()));
                }
                else
                {              
                    MessageBox.Show("O identificador digitado não corresponde a nenhum cliente cadastrado!");
                    GerCliente.ActiveForm.Height = 93;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma das opções de consulta!");
            }
        }

        //Altera os dados do cliente (titular)
        private void alterarCliente()
        {
            DateTime vencimento = dtVencimento.Value;

            if (gerCli.alterarCliente(cli.idCliente, txtNome.Text.ToUpper().Trim(), mTxtTelefone.Text.Trim(), mTxtCelular.Text.Trim(), txtEmail.Text.Trim().ToUpper(), txtEndereco.Text.ToUpper().Trim()))
            {
                MessageBox.Show("Dados alterados com sucesso!");
                GerCliente.ActiveForm.Height = 93;
            }
            else
            {
                MessageBox.Show("Houve algum erro interno, tente novamente!");
                GerCliente.ActiveForm.Height = 93;
            }
        }

        private void apagarCliente()
        {
            GerCliente.ActiveForm.Height = 443;
            if (MessageBox.Show("Tem certeza que deseja apagar estes dados? \n Todos os veículos ligados a esse cliente também serão apagados!", "Excluir veículo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int pagamento = gerSitPag.retornarIdSituacaoPorIdClienteIdVeiculo(Convert.ToInt32(cli.idCliente), Convert.ToInt32(vei.idVeiculo));


                if  ((gerVei.apagarVeiculoPorIdCliente (cli.idCliente)) &&
                    (gerCli.apagarCliente(cli.idCliente)))
                {
                    MessageBox.Show("Dados excluídos com sucesso!");
                    limparCamposVeiculo();
                    GerCliente.ActiveForm.Height = 93;
                }
                else
                {
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
                    GerCliente.ActiveForm.Height = 93;
                }
            }
        }

        //----------------------------------------------------------------------------------------------------

        //Tratamento dos campos do veículo

        private void preencherComboTipoEstacionamento()
        {
            List<string> listaTipoEst = new List<string>();
            listaTipoEst = gerTipoEst.preencherComboCunsultaTipoEstacionamento();

            for (int i = 0; i < listaTipoEst.Count; i++)
                cbTipoPlano.Items.Add(listaTipoEst[i]);
        }

        private void limparCamposVeiculo()
        {
            cbPlaca.Items.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtAno.Clear();
        }

        private void bloquearCamposVeiculo()
        {
            if (checkAlterarCliente.Checked == true)
            {
                cbPlaca.Enabled = true;
                txtModelo.Enabled = true;
                txtMarca.Enabled = true;
                txtAno.Enabled = true;
            }
            else
            {
                //cbPlaca.Enabled = false;
                txtModelo.Enabled = false;
                txtMarca.Enabled = false;
                txtAno.Enabled = false;
            }

            bloquearCamposPagamento();
        }

        //Preenche a combo box com as placas cadastradas pelo id do cliente consultado
        private void preencherComboPlacas(int id)
        {
            //Declaração da lista de placas
            List<string> placas = new List<string>();

            //Carrega a lista de placas
            placas = gerVei.preencherComboPlaca(id);

            foreach (string l in placas)
            {
                cbPlaca.Items.Add(l);
                cbPlaca.SelectedIndex = 0;
            }

            exibirVeiculo();
        }

        //Exibe as informações do veículo no formulário
        private void exibirVeiculo()
        {
            //Declaração da lista de veículo
            List<veiculo> listaVei = new List<veiculo>();

            //Carrega a lista declarada
            listaVei = gerVei.exibirVeiculoPorPlaca(cbPlaca.Text);

            foreach (veiculo v in listaVei)
            {
                //cbTipoPlano.SelectedIndex = (v.idTipoEstacionamento) - 1;
                txtModelo.Text = v.modelo;
                txtMarca.Text = v.marca;
                txtAno.Text = v.ano;

                vei.idVeiculo = v.idVeiculo;
            }

            exibirPagamento();
        }

        //Fazer alterações no cadastro do veículo
        private void alterarVeiculo()
        {
            {
                if (gerVei.alterarVeiculo(cbPlaca.Text.Trim().ToUpper(), txtMarca.Text.Trim().ToUpper(), txtModelo.Text.Trim().ToUpper(), txtAno.Text.ToUpper().Trim(), cli.idCliente))
                {
                    MessageBox.Show("Dados alterados com sucesso!");

                }
                else
                {
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
                }
            }
            GerOperador.ActiveForm.Height = 93;
        }

        //Apagar um veículo do sistema
        private void apagarVeiculo()
        {
            if (MessageBox.Show("Tem certeza que deseja apagar estes dados?", "Excluir veículo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (gerVei.apagarVeiculo(cbPlaca.Text.Trim().ToUpper()))
                {
                    MessageBox.Show("Dados excluídos com sucesso!");
                    limparCamposVeiculo();
                }
                else
                {
                    MessageBox.Show("Houve algum erro interno, tente novamente!");
                }
            }
            GerOperador.ActiveForm.Height = 93;
        }

        //----------------------------------------------------------------------------------------------------

        //Tratamento dos campos do pagamento

        private void bloquearCamposPagamento()
        {
            if (checkAlterarCliente.Checked == true)
            {
                cbTipoPlano.Enabled = true;
                cbSituacao.Enabled = true;
                dtVencimento.Enabled = true;
            }
            else
            {
                cbTipoPlano.Enabled = false;
                cbSituacao.Enabled = false;
                dtVencimento.Enabled = false;
            }
            GerOperador.ActiveForm.Height = 93;
        }

        private void limparCamposPagamento()
        {
            cbTipoPlano.SelectedIndex = 0;
            lblValorPlano.Text = "Valor do Plano";
            //cbSituacao.SelectedIndex = 0;
            dtVencimento.Text = (DateTime.Now).ToString();
        }

        //Método para exibir o campo de vencimento e o botão de pagamento apenas se o cliente possuir um plano mensal
        private void campoVencimento()
        {
            if (cbTipoPlano.Text.Trim() != "")
            {
                if ((val.retornarTextoSemId(cbTipoPlano.Text.Trim()) != "ROTATIVO") && (val.retornarTextoSemId(cbTipoPlano.Text.Trim()) != "DIÁRIO"))
                {
                    lblVencimento.Visible = true;
                    dtVencimento.Visible = true;

                    lblSituacao.Visible = true;
                    cbSituacao.Visible = true;

                    btnEfetuarPagamento.Visible = true;

                    //cbSituacao.SelectedIndex = 0;
                }
                else
                {
                    lblVencimento.Visible = false;
                    dtVencimento.Visible = false;

                    lblSituacao.Visible = false;
                    cbSituacao.Visible = false;

                    btnEfetuarPagamento.Visible = false;

                    //cbSituacao.SelectedIndex = 2;
                    //dtVencimento.Text = (Convert.ToDateTime(null)).ToString();
                }

                lblValorPlano.Text = "R$ " + (gerTipoEst.retornarValorTipoEstacionamentoPorId(Convert.ToInt32(val.retornarIdSemTexto(cbTipoPlano.Text.Trim().ToUpper())))).ToString();
            }
        }

        //Exibe as informações do veículo no formulário
        private void exibirPagamento()
        {
            //Declaração da lista de gerenciamento de pagamento
            List<gerenciar_situacao_pagamento> listaGer = new List<gerenciar_situacao_pagamento>();

            //Carrega a lista declarada
            listaGer = gerSitPag.exibirSituacaoPagamento();

            DateTime dataAtual = DateTime.Now;

            foreach (gerenciar_situacao_pagamento g in listaGer)
            {
                cbTipoPlano.SelectedIndex = (g.idTipoPlanoEstacionamento) - 1;

                //Data retornada do bd adicionada dos meses que já foram pagos e atualizada para ser exibida
                DateTime dataExibida = (Convert.ToDateTime(g.vencimentoPagamento).AddMonths(Convert.ToInt32(g.mesesPagos)));

                dtVencimento.Text = dataExibida.ToString();

                //Verifica se a data exibida é maior que a atual, para que a situação do cliente possa ser atualizada
                if (dataExibida >= dataAtual)//PAGO
                    cbSituacao.SelectedIndex = 1;
                else//A PAGAR
                    cbSituacao.SelectedIndex = 0;
            }

            campoVencimento();
        }

        private void alterarPagamento()
        {
            DateTime vencimento = dtVencimento.Value;
            string situacao;

            //Valores atribuídos aos planos rotativo e diário
            if ((val.retornarTextoSemId(cbTipoPlano.Text.Trim()) == "ROTATIVO") || (val.retornarTextoSemId(cbTipoPlano.Text.Trim()) == "DIÁRIO"))
            {
                situacao = "NÃO POSSUI PLANO";
                vencimento = new DateTime(2099, 1, 1, 0, 0, 0);
            }
            else
                situacao = cbSituacao.Text.Trim().ToUpper();


            if (gerSitPag.alterarSituacaoPagamento(cli.idCliente, vei.idVeiculo, Convert.ToInt32(val.retornarIdSemTexto(cbTipoPlano.Text.Trim())), situacao, vencimento)
                && gerSitPag.zerarMesesPagos(cli.idCliente, vei.idVeiculo))
            {
                MessageBox.Show("Dados alterados com sucesso!");
                GerOperador.ActiveForm.Height = 93;
            }
            else
            {
                MessageBox.Show("Houve algum erro interno, tente novamente!");
                GerOperador.ActiveForm.Height = 93;
            }
        }

        //----------------------------------------------------------------------------------------------------

        //CheckBox

        private void checkAlterarCliente_CheckedChanged(object sender, EventArgs e)
        {
            bloquearCamposCliente();
        }

        //----------------------------------------------------------------------------------------------------

        //ComboBox

        private void cbTipoPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            campoVencimento();
        }

        private void cbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtAno.Clear();
            exibirVeiculo();
        }


        //----------------------------------------------------------------------------------------------------

        //Botões

        private void btnConsultarPlaca_Click(object sender, EventArgs e)
        {
            checkAlterarCliente.Checked = true;
            limparCamposVeiculo();
            campoVencimento();
            exibirCliente();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            mTxtConsultar.Clear();
            limparCamposCliente();
            limparCamposVeiculo();
            limparCamposPagamento();
            ocultarCampos(false);
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            cadVei.limparCampos();
            cadVei.carregarNomeTitular();
            cadVei.ShowDialog();
            cbPlaca.Items.Clear();
            exibirCliente();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            alterarVeiculo();
            cbPlaca.Items.Clear();
            exibirCliente();
        }

        private void btnApagarVeiculo_Click(object sender, EventArgs e)
        {
            apagarVeiculo();
            cbPlaca.Items.Clear();
            exibirCliente();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            apagarCliente();
            ocultarCampos(false);
            mTxtConsultar.Clear();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            alterarCliente();
            cbPlaca.Items.Clear();
            exibirCliente();
        }

        private void btnAlterarPagamento_Click(object sender, EventArgs e)
        {
            alterarPagamento();
            cbPlaca.Items.Clear();
            exibirCliente();
        }

        private void btnEfetuarPagamento_Click(object sender, EventArgs e)
        {
            pag.placaVeiculo = cbPlaca.Text;
            pag.consultarPlaca();
            pag.ShowDialog();
            cbPlaca.Items.Clear();
            exibirCliente();
            tabControl1.SelectedIndex = 0;
        }

        private void GerCliente_Load(object sender, EventArgs e)
        {

        }



    }
}
