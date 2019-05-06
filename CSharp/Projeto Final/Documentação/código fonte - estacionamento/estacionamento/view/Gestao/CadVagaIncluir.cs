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
using MySql.Data.MySqlClient;

namespace Estacionamento.View.Gestao
{
    public partial class CadVagaIncluir : Form
    {
        GerenciarVaga gerVaga = new GerenciarVaga();

        Vaga vg = new Vaga();

        int quantidade_de_vagas, andares;

        public CadVagaIncluir()
        {
            InitializeComponent();

            quantidade_de_vagas = 0;//vg.quantidade_vaga;
            andares = vg.andar;

        }


        private void CadVagaIncluir_Load(object sender, EventArgs e)
        {
            //int quant = quantidade_de_vagas;
            /*WindowState = FormWindowState.Maximized;
            painelVaga.Left = 0;
            painelVaga.Top = 0;
            painelVaga.Width = Convert.ToInt16((Screen.PrimaryScreen.Bounds.Width) * (0.75)); //redimensionar tela
            painelVaga.Height = Screen.PrimaryScreen.Bounds.Height; //redimensionar tela

            buVoltar.Left = Convert.ToInt16((Screen.PrimaryScreen.Bounds.Width) * (0.9));
            buVoltar.Top = Convert.ToInt16((Screen.PrimaryScreen.Bounds.Width) * (0.9));
            */

            /*
            int posicao_x = 45,posicao_y = 12;
            
                for (int i = 0; i < quantidade_de_vagas; i++)
                {
                    gerVaga.painel_da_vaga(i, andares + " - " + i, posicao_x, posicao_y, painelVaga, andares);

                    posicao_x = posicao_x + 50;
                    posicao_y = posicao_y + 50;
                    gerVaga.calculo_rotacionar_inicial(i);
                    gerVaga.calculo_excluir_inicial(i);
                    
                }
             */ 

            lblTXTAndarVaga.Text = andares.ToString() + "º Andar";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            gerVaga.painel_da_vaga(quantidade_de_vagas, andares + " - " + quantidade_de_vagas, 10, 10, painelVaga, andares,0);
            gerVaga.calculo_excluir_inicial(quantidade_de_vagas);
            gerVaga.calculo_rotacionar_inicial(quantidade_de_vagas);
            gerVaga.calculo_deficiente_inicial(quantidade_de_vagas);

            quantidade_de_vagas = quantidade_de_vagas + 1;

            vg.consultar_quantidade_vaga = quantidade_de_vagas;
        }

        private void buRotacionar_Click(object sender, EventArgs e)
        {
            if (comboBoxRotacionar.Text.Trim() == "" || comboBoxRotacionar.Text == "Vagas")
            {
                MessageBox.Show("Escolha uma Vaga!");
            }
            else
            {
                gerVaga.rotacionar(comboBoxRotacionar, painelVaga, quantidade_de_vagas);
                gerVaga.calculo_rotacionar(gerVaga.qual_vaga_combobox(comboBoxRotacionar, quantidade_de_vagas, comboBoxRotacionar.SelectedItem.ToString()));
            }
        }

        private void comboBoxRotacionar_Click(object sender, EventArgs e)
        {
            comboBoxRotacionar.Items.Clear();
            comboBoxRotacionar.Text = "";
            gerVaga.preencher_combobox(comboBoxRotacionar, quantidade_de_vagas);

        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            if (comboBoxRotacionar.Text.Trim() == "" || comboBoxRotacionar.Text == "Vagas")
            {
                MessageBox.Show("Escolha uma Vaga!");
            }
            else
            {
                gerVaga.excluir_vaga(comboBoxRotacionar, painelVaga, quantidade_de_vagas);
                gerVaga.calculo_excluir(gerVaga.qual_vaga_combobox(comboBoxRotacionar, quantidade_de_vagas, comboBoxRotacionar.SelectedItem.ToString()));
                painelVaga.Refresh();
                comboBoxRotacionar.Text = "";
            }

        }

        private void buSalvar_Click(object sender, EventArgs e)
        {
            if ((checkBoxAndar.Checked == true))
            {
                if (textBoxMaisAndares.Text == "")
                {
                    MessageBox.Show("Por Favor, Digite a quantidade de Andares.", "Ocorreu um Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gerVaga.salvar_bd_mais_andares(quantidade_de_vagas,andares,"DISPONÍVEL", Convert.ToInt16(textBoxMaisAndares.Text));
                    this.Close();
                }
            }
            else
            {
            gerVaga.salvar_bd(quantidade_de_vagas, andares, "DISPONÍVEL");
            this.Close();
            }
            

        }

        private void checkBoxAndar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAndar.Checked == true)
            {
                textBoxMaisAndares.Enabled = true;
                textBoxMaisAndares.Visible = true;
                textBoxMaisAndares.Focus();
            }
            else
            {
                textBoxMaisAndares.Enabled = false;
                textBoxMaisAndares.Visible = false;
            }
        }

        private void textBoxMaisAndares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Por Favor, Digite Somente Numeros.", "Ocorreu um Erro Na Digitação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMaisAndares.Clear();

            }
        }

        private void buDeficiente_Click(object sender, EventArgs e)
        {
            gerVaga.painel_da_vaga(quantidade_de_vagas, andares + " - " + quantidade_de_vagas, 10, 10, painelVaga, andares,1);
            gerVaga.calculo_excluir_inicial(quantidade_de_vagas);
            gerVaga.calculo_rotacionar_inicial(quantidade_de_vagas);

            gerVaga.calculo_deficiente(quantidade_de_vagas);

            quantidade_de_vagas = quantidade_de_vagas + 1;

            vg.consultar_quantidade_vaga = quantidade_de_vagas;
        }
    }
}
