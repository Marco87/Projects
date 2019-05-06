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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            //Form3 F3 = new Form3(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));

            //F3.Show();
            //this.Close();

            Class1.quantidade_vaga = Convert.ToInt16(textBox1.Text);
            Class1.andares = Convert.ToInt16(textBox2.Text);
            Form3 F3 = new Form3();
            F3.Show();
            this.Close();
        }
        
        
    }
}
