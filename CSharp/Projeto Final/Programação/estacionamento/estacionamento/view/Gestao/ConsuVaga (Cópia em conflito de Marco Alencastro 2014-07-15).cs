using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Estacionamento.Model;
using Estacionamento.Control;

namespace Estacionamento.View.Gestao
{

    public partial class ConsuVaga : Form
    {

        Vaga v = new Vaga();

        GerenciarVaga gervaga = new GerenciarVaga();
        int andar;

        public ConsuVaga()
        {
            InitializeComponent();
            andar = v.andar;
        }


        private void ConsuVaga_Load(object sender, EventArgs e)
        {
            gervaga.consultar_vagas(andar, painelConsultar);
            lblAndar.Text = andar.ToString() + "º Andar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
