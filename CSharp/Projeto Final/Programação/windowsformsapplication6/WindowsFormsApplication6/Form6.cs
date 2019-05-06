using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form6 : Form
    {
        public static string vaga;
       
        public Form6()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Class1.identificador_vagas = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
