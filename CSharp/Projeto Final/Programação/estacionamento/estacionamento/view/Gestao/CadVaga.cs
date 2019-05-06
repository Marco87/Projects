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

namespace Estacionamento.View.Gestao
{
    public partial class CadVaga : Form
    {
        GerenciarVaga gerVaga = new GerenciarVaga();

        Vaga vg = new Vaga();

        public CadVaga()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            mTxtAndar.Clear();

        }

        private bool verificarCamposEmBranco()
        {
            if (mTxtAndar.Text.Trim() == "")
                return false;
            else
                return true;
        }

        private void confirmarCadastro()
        {
            if (!verificarCamposEmBranco())
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            else
            {
                if (gerVaga.consultarAndarExistente(Convert.ToInt16(mTxtAndar.Text)) == Convert.ToInt16(mTxtAndar.Text))
                {
                    MessageBox.Show("Atenção! Andar Já Existente, Por Favor informar outro andar!");
                    mTxtAndar.Text = "";
                    mTxtAndar.Focus();
                }
                else
                {
                    
                    vg.andar = Convert.ToInt16(mTxtAndar.Text);
                    CadVagaIncluir cvi = new CadVagaIncluir();
                    cvi.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCadVaga_Click(object sender, EventArgs e)
        {
            confirmarCadastro();
        }

        private void CadVaga_Load(object sender, EventArgs e)
        {
            this.ActiveControl = mTxtAndar;
        }
    }
}
