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
using MySql.Data.MySqlClient;


namespace Estacionamento.View.Gestao
{
    public partial class AlterarVaga : Form
    {

        GerenciarVaga gerVaga = new GerenciarVaga();
        Vaga vg = new Vaga();

        int quantidade_de_vagas, andares;

        public AlterarVaga()
        {
            InitializeComponent();


            andares = vg.andar;

        }

        private void AlterarVaga_Load(object sender, EventArgs e)
        {
            gerVaga.alterar_vagas(andares, painelVaga);

            lblAndar.Text = andares.ToString() + "º Andar";
            quantidade_de_vagas = vg.consultar_quantidade_vaga;

        }

        private void buAddVaga_Click(object sender, EventArgs e)
        {
            gerVaga.painel_da_vaga_alterar(quantidade_de_vagas, andares +" - "+ quantidade_de_vagas, "DISPONÍVEL", 10, 10, 0, painelVaga, andares,0);
            quantidade_de_vagas = quantidade_de_vagas + 1;
            vg.consultar_quantidade_vaga = quantidade_de_vagas;
        }


        private void comboBoxExcluir_Click(object sender, EventArgs e)
        {
            comboBoxExcluir.Items.Clear();
            comboBoxExcluir.Text = "";
            gerVaga.preencher_combobox(comboBoxExcluir, quantidade_de_vagas);

        }


        private void buRotacionar_Click(object sender, EventArgs e)
        {
            if (comboBoxExcluir.Text.Trim() == "" || comboBoxExcluir.Text == "Vagas")
            {
                MessageBox.Show("Escolha uma Vaga!");
            }
            else
            {
                gerVaga.rotacionar(comboBoxExcluir, painelVaga, quantidade_de_vagas);
                gerVaga.calculo_rotacionar(gerVaga.qual_vaga_combobox(comboBoxExcluir, quantidade_de_vagas, comboBoxExcluir.SelectedItem.ToString()));
            }

        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            if (comboBoxExcluir.Text.Trim() == "" || comboBoxExcluir.Text == "Vagas")
            {
                MessageBox.Show("Escolha uma Vaga!");
            }
            else
            {
                if ((!(gerVaga.retorna_situacao_vaga(comboBoxExcluir, quantidade_de_vagas, "OCUPADO"))) || (!(gerVaga.retorna_situacao_vaga(comboBoxExcluir, quantidade_de_vagas, "RESERVADO"))))
                {
                    MessageBox.Show("Vaga não pode ser removida, pois está sendo usada!", "Vaga em Uso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    gerVaga.excluir_vaga(comboBoxExcluir, painelVaga, quantidade_de_vagas);
                    gerVaga.calculo_excluir(gerVaga.qual_vaga_combobox(comboBoxExcluir, quantidade_de_vagas, comboBoxExcluir.SelectedItem.ToString()));
                    painelVaga.Refresh();
                    comboBoxExcluir.Text = "";
                }
            }
        }

        private void buSalvar_Click(object sender, EventArgs e)
        {
            gerVaga.excluir_tudo(andares);
            gerVaga.salvar_bd_alterar(quantidade_de_vagas, andares);
            this.Close();
        }

        private void buVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void painelVaga_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEstadoVaga2_Click(object sender, EventArgs e)
        {
            comboBoxEstadoVaga2.Items.Clear();
            comboBoxEstadoVaga2.Items.Add("DISPONÍVEL");
            comboBoxEstadoVaga2.Items.Add("RESERVADO");
            comboBoxEstadoVaga2.Items.Add("OCUPADO");
        }

        private void comboBoxEstadoVaga_Click(object sender, EventArgs e)
        {
            comboBoxExcluir.Items.Clear();
            comboBoxExcluir.Text = "";
            gerVaga.preencher_combobox(comboBoxExcluir, quantidade_de_vagas);
        }

        private void buEstadoVaga_Click(object sender, EventArgs e)
        {
            if (comboBoxExcluir.Text.Trim() == "" || comboBoxEstadoVaga2.Text.Trim() == "")
            {
                MessageBox.Show("Escolha uma Opção!");
            }
            else
            {
                gerVaga.mudar_estado_alterar(comboBoxExcluir, comboBoxEstadoVaga2, quantidade_de_vagas);
                comboBoxExcluir.Text = "";
            }
        }

        private void buDeficiente_Click(object sender, EventArgs e)
        {
            gerVaga.painel_da_vaga_alterar(quantidade_de_vagas, andares + " - " + quantidade_de_vagas, "DISPONÍVEL", 10, 10, 0, painelVaga, andares,1);
            quantidade_de_vagas = quantidade_de_vagas + 1;
            vg.consultar_quantidade_vaga = quantidade_de_vagas;
        }

    }
}
