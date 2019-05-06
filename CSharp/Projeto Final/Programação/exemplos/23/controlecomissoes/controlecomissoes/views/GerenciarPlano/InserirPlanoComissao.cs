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
    public partial class InserirPlanoComissao : Form
    {
        GerenciarPlan gerenciar = new GerenciarPlan();
        Validacoes validacoes = new Validacoes();

        public InserirPlanoComissao()
        {
            InitializeComponent();
            preencherComboConsultaPlano();
            preencherComboTipoCliente();
        }

        private void preencherComboTipoCliente()
        {
            comboTipoCliente.Items.Add("Pessoa Física");
            comboTipoCliente.Items.Add("Pessoa Jurídica");
            comboTipoCliente.Items.Add("Pessoa Física e Pessoa Jurídica");
        }

        private string retornaCodigoPlano()
        {
            //Retorna o código
            string plano = comboInserirPlanoComis.Text;
            string[] pla = plano.Split('-');
            return pla[0];
        }

        private void limparCampos()
        {
            txtComissaoComis.Clear();
            txtFIniComis.Clear();
            txtFFinalComis.Clear();
        }

        private void preencherComboConsultaPlano()
        {
            List<string> listaPlano = new List<string>();
            listaPlano = gerenciar.preencherComboConsultaPlano();

            for (int i = 0; i < listaPlano.Count; i++)
                comboInserirPlanoComis.Items.Add(listaPlano[i]);
        }


        private void inserirPlanoComissao()
        {
            plano_comissao pl = new plano_comissao();

            string codigo = retornaCodigoPlano();
            int tipoCliente = -1;
            float comissao = Convert.ToInt64(txtComissaoComis.Text);
            int faixaIni = Convert.ToInt32(txtFIniComis.Text);
            int faixaFin = Convert.ToInt32(txtFFinalComis.Text);

            if (comboTipoCliente.Text == "Pessoa Física")
                tipoCliente = 2;
            if (comboTipoCliente.Text == "Pessoa Jurídica")
                tipoCliente = 3;
            if (comboTipoCliente.Text == "Pessoa Física e Pessoa Jurídica")
            {
                gerenciar.inserirPlanoComissao(codigo, 2, comissao, faixaIni, faixaFin);
                tipoCliente = 3;
            }

            if (faixaIni < faixaFin)
            {
                if (gerenciar.inserirPlanoComissao(codigo, tipoCliente, comissao, faixaIni, faixaFin))
                    MessageBox.Show("Dados inseridos com sucesso!");
                else
                    MessageBox.Show("A operação não pôde ser concluída!");

                limparCampos();
            }
            else
                MessageBox.Show("A faixa inicial deve ser maior que a faixa final.");

        }

        private void btnCadastroPlanoComissao_Click(object sender, EventArgs e)
        {
            inserirPlanoComissao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
