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
    public partial class Form5 : Form
    {
        //int quantidade_de_vagas2;
        TextBox[] textBoxes = new TextBox[100000];
        Label[] labels = new Label[10000];

        public Form5()//int quantidade_de_vagas)
        {
            InitializeComponent();
            //quantidade_de_vagas2 = quantidade_de_vagas;
 
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            /*
            

            for (int i = 0; i < quantidade_de_vagas2; i++)
            {
                textBoxes[i] = new TextBox();
                
                labels[i] = new Label();
                

                this.Controls.Add(textBoxes[i]);
                this.Controls.Add(labels[i]);
            }
            */
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form3 F3 = new Form3(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
