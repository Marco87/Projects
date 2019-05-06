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
    public partial class ConsuVagaAndar : Form
    {
        Vaga vg = new Vaga();
        GerenciarVaga gervaga = new GerenciarVaga();

        public ConsuVagaAndar()
        {
            InitializeComponent();
        }
        private bool verificarCampos()
        {
            if (comboBoxAndar.Text.Trim() == "" || comboBoxAndar.Text == "Andar")
                return false;
            else
                return true;
        }

        private void confirmarCadastro()
        {
            if (!verificarCampos())
                MessageBox.Show("Escolha um andar!");
            else
            {
                int andar = Convert.ToInt16(comboBoxAndar.SelectedItem);

                vg.andar = andar;
                ConsuVaga cv = new ConsuVaga();
                cv.ShowDialog();
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirmarCadastro();

        }

        private void comboBoxAndar_Click(object sender, EventArgs e)
        {
            
        }

        private void buVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsuVagaAndar_Load(object sender, EventArgs e)
        {
            comboBoxAndar.Items.Clear();
            gervaga.consultarAndar(comboBoxAndar);
        }
    }
}
