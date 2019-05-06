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

namespace Estacionamento.View
{
    public partial class CadVagaIncluirIdentificador : Form
    {
        Vaga vg = new Vaga();
        GerenciarVaga gerVaga = new GerenciarVaga();
        public CadVagaIncluirIdentificador()
        {
            InitializeComponent();
        }
        private bool verificarCampos()
        {
            if (textBoxIdVaga.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void confirmarCadastro()
        {
            if (!verificarCampos())
                MessageBox.Show("Digite um Identificador!");
            else
            {
                    
                    vg.identificador_vaga = Convert.ToInt16(textBoxIdVaga.Text);
                    this.DialogResult = DialogResult.OK;

            }
        }
        private void buIdVaga_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
           
        }

        private void textBoxIdVaga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) 
            {
                MessageBox.Show("Por Favor, Digite Somente Numeros.", "Ocorreu um Erro Na Digitação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIdVaga.Clear();
                
            }
        }

        private void CadVagaIncluirIdentificador_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxIdVaga;
        }
    }
}
