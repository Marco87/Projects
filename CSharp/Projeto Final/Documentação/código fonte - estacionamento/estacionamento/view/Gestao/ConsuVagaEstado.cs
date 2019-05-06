using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Control;

namespace Estacionamento.View.Gestao
{
    public partial class ConsuVagaEstado : Form
    {
        Vaga vg = new Vaga();
        public ConsuVagaEstado()
        {
            InitializeComponent();
        }
        private bool verificarCampos()
        {
            if (comboBoxEstadoVaga.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void confirmarCadastro()
        {
            if (!verificarCampos())
                MessageBox.Show("Escolha uma Opção!");
            else
            {
                vg.estado_vaga = comboBoxEstadoVaga.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;

            }
        }
        private void buEstadoVaga_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
        }

        private void ConsuVagaEstado_Load(object sender, EventArgs e)
        {
            comboBoxEstadoVaga.Items.Add("DISPONÍVEL");
            comboBoxEstadoVaga.Items.Add("OCUPADO");
            comboBoxEstadoVaga.Items.Add("RESERVADO");
        }
    }
}
