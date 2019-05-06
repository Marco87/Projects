using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication6
{
    public partial class Form3 : Form
    {
        PictureBox[] paineis = new PictureBox[1000];
        Point lastClick;
        int quantidade_de_vagas2, andar2;
        string identificador_vaga2;
        


        //Image imagem;


        //int valor_x, valor_y;

        public Form3()//int quantidade_de_vagas, int andar)
        {


            InitializeComponent();

            quantidade_de_vagas2 = Class1.quantidade_vaga;
            andar2 = Class1.andares;

        }


        /*
        public int quantidade_de_vagas()
        {
            int quantidade_de_vagas2 = 0;

            string Conexao = "Server=127.0.0.1;Database=estacionamento;Uid=root;Pwd=258258";
            MySqlConnection conn = new MySqlConnection(Conexao);
            MySqlCommand comando = conn.CreateCommand();
            comando.CommandText = "select count(idVaga) from vaga";

            try
            {


                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    quantidade_de_vagas2 = Convert.ToInt32(leitor.GetString(0));
                }
                //conn.Close();
            }
            catch (MySqlException erro)
            {
                
             MessageBox.Show("Erro Ao Consultar Dado!", erro.Message);
             conn.Close();
            }
            //finally
            //{

                //conn.Close();
            //}
            //MessageBox.Show(quantidade_de_vagas2.ToString());
            return quantidade_de_vagas2;

        }
        
        
        public void traco(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 20, 20, 20, 20 };
            Pen retangulo = new Pen(Color.Black, 25);
            retangulo.DashPattern = dashValues;
            e.Graphics.DrawLine(retangulo, new Point(50, 70), new Point(70, 70));
        }
        */
        //public void painel_da_vaga()
        //{

        //}

        public void preencher_combobox(ComboBox x)
        {

            for (int i = 0; i < quantidade_de_vagas2; i++)
            {
                x.Items.Add(i);
            }

        }

        /*
        public void linha_vertical_direita(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 3, 5, 5 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(110, 10), new Point(110, 120));
        }

        public void linha_vertical_esquerda(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 3, 5, 5 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(8, 10), new Point(8, 120));
        }

        public void linha_vertical_direita_180(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 3, 5, 5 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(110, 10), new Point(110, 120));
        }

        public void linha_vertical_esquerda_180(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 3, 5, 5 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(8, 10), new Point(8, 120));
        }
        */
        public void painel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y);
        }

        private void painel_MouseMove(object sender, MouseEventArgs e, int i)
        {
            //blackPanel[1].Select = true;
            //for (int i = 0; i < quantidade_de_vagas2; i++)
            //{
            //if (blackPanel[i].Focus())
            //{
            if (e.Button == MouseButtons.Left)// && paineis[i].Focus())
            {
                paineis[i].Left += e.X - lastClick.X;
                paineis[i].Top += e.Y - lastClick.Y;

                //MessageBox.Show("Consegui");
            }

            //System.Windows.Forms.MessageBox.Show(i.ToString());
            //}
            //}
        }



        private void painel_MouseClick(object sender, MouseEventArgs e, int i)
        {
            //int posicao_x,posicao_y;


            if (e.Button == MouseButtons.Right)
            {

                /*Form6 f6 = new Form6();
                f6.Show();

                identificador_vaga2 = Class1.identificador_vagas;
                panel1.Refresh();
                */

                Form6 f6 = new Form6();

                DialogResult rs = f6.ShowDialog();

                if (rs == DialogResult.OK)
                {

                    limpar(i);


                    identificador_vaga2 = Class1.identificador_vagas;

                    painel_da_vaga2(i, identificador_vaga2, paineis[i].Location.X, paineis[i].Location.Y);

                    //id_vaga(i,identificador_vaga2);
                }


            }
        }

        /*private void painel_MouseClick_esquerdo(object sender, MouseEventArgs e, int i)
        {
            if (e.Button == MouseButtons.Left)
            {
                paineis[i].Paint += new PaintEventHandler(borda);
                panel1.Controls.Add(paineis[i]);
                panel1.Refresh();
            }
            else
            {

            }
        }*/

        public void limpar(int i)
        {
            panel1.Controls.Remove(paineis[i]);

        }

        /*public void limpar(object sender, PaintEventArgs e)
        {
            
        }

        public void id_vaga(int i,string identificador_vaga3)
        {
            paineis[i].Paint += new PaintEventHandler((s, e) => escrever(s, e, identificador_vaga3));
            //panel1.Controls.Add(paineis[i]);
            panel1.Refresh();
        }
        
        public void linha_horizontal(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 2, 5, 3 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(11, 5), new Point(109, 5));
        }

        public void linha_horizontal_180(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 2, 5, 3 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(11, 5), new Point(11, 105));
        }

        public void carro_verde(object sender, PaintEventArgs e)
        {
            imagem = Image.FromFile(@"C:\Users\Caco\Desktop\carro-verde1.png");
            e.Graphics.DrawImage(imagem, new Point(30, 13));
        }

        public void carro_verde_180(object sender, PaintEventArgs e)
        {
            imagem = Image.FromFile(@"C:\Users\Caco\Desktop\carro-verde1.png");
            e.Graphics.RotateTransform(180);
            e.Graphics.DrawImage(imagem, new Point(30, 13));
        }
        */
        /*public void borda(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red,e.ClipRectangle.Left,e.ClipRectangle.Top,e.ClipRectangle.Width - 1,e.ClipRectangle.Height - 1);
            base.OnPaint(e);

        }*/

        public void escrever(object sender, PaintEventArgs e, string identificador_da_vaga)
        {
            SolidBrush blush = new SolidBrush(Color.White);
            Font fonte = new Font("Arial", 16);
            StringFormat alinhar = new StringFormat();
            alinhar.Alignment = StringAlignment.Center;
            alinhar.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(identificador_da_vaga, fonte, blush, new PointF(65, 150),alinhar);
        }

        /*
        public void rodar(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(100.0F, 0.0F);

            e.Graphics.RotateTransform(60.0F);

            e.Graphics.DrawEllipse(new Pen(Color.White, 3), 0, 0, 150, 60);

        }
        */
        /*
        public void painel_da_vaga_180(int i, string nome_vaga, int posicao_x, int posicao_y)
        {
            paineis[i] = new PictureBox();
            paineis[i].BackColor = Color.Transparent;
            paineis[i].Size = new Size(200, 120);
            paineis[i].Paint += new PaintEventHandler(linha_horizontal_180);
            paineis[i].Paint += new PaintEventHandler(linha_vertical_direita_180);
            paineis[i].Paint += new PaintEventHandler(linha_vertical_esquerda_180);
            paineis[i].MouseMove += new MouseEventHandler((s, e) => painel_MouseMove(s, e, i));
            paineis[i].MouseDown += new MouseEventHandler(painel_MouseDown);
            paineis[i].Paint += new PaintEventHandler(carro_verde_180);
            paineis[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick(s, e, i));

            paineis[i].Paint += new PaintEventHandler((s, e) => escrever(s, e, nome_vaga));

            //paineis[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick_esquerdo(s, e, i));

            //paineis[i].Paint += new PaintEventHandler(traco);
            paineis[i].Location = new Point(posicao_x, posicao_y);

            //valor_x = valor_x + 50;
            //valor_y = valor_y + 50;

            panel1.Controls.Add(paineis[i]);

        }
        */

        public void painel_da_vaga2(int i, string nome_vaga, int posicao_x, int posicao_y)
        {
            //MessageBox.Show(quantidade_de_vagas2.ToString());
            //int valor_x = 45, valor_y = 12;

            paineis[i] = new PictureBox();
            paineis[i].BackColor = Color.Transparent;
           //paineis[i].Size = new Size(120, 120);
            //paineis[i].Paint += new PaintEventHandler(linha_horizontal);
            //paineis[i].Paint += new PaintEventHandler(linha_vertical_direita);
            //paineis[i].Paint += new PaintEventHandler(linha_vertical_esquerda);
            paineis[i].MouseMove += new MouseEventHandler((s, e) => painel_MouseMove(s, e, i));
            paineis[i].MouseDown += new MouseEventHandler(painel_MouseDown);
            //paineis[i].Paint += new PaintEventHandler(carro_verde);
            paineis[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick(s, e, i));

            paineis[i].Paint += new PaintEventHandler((s, e) => escrever(s, e, nome_vaga));

            //paineis[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick_esquerdo(s, e, i));

            //paineis[i].Paint += new PaintEventHandler(traco);
            paineis[i].Location = new Point(posicao_x, posicao_y);
            //paineis[i].ImageLocation = @"C:\Users\Caco\Desktop\carro-verde1.png";

            //valor_x = valor_x + 50;
            //valor_y = valor_y + 50;

            paineis[i].Image = Properties.Resources.carro_verde2;//(@"..\Imagens\carro-verde2.png");
            paineis[i].SizeMode = PictureBoxSizeMode.AutoSize;
            //paineis[i].Padding = new Padding(0, 0, 0, 10);


            panel1.Controls.Add(paineis[i]);

            //preencher_combobox(nome_vaga);

            

        }


        /*
        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a bitmap to hold the rotated result.
            Bitmap result = new Bitmap(bm.Width, bm.Height);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(bm.Width / 2f, bm.Height / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(OriginalBitmap.GetPixel(0, 0));

                //// For debugging. (Makes it easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                gr.DrawImage(bm, 0, 0);
            }

            // Return the result bitmap.
            return result;
        }
         */

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            foreach (Panel x in panel1.Controls)
            {
                
                    //MessageBox.Show(x.ToString());
                    x.BackColor = Color.White;
                    //x.Location = new Point(10,10);
                    panel1.Controls.Add(x);
                
                
                //x.Size = new Size(250, 180);
                //x.Paint += new PaintEventHandler(linha_horizontal);
                //x.Paint += new PaintEventHandler(linha_vertical_direita);
                //x.Paint += new PaintEventHandler(linha_vertical_esquerda);
                //paineis[i].MouseMove += new MouseEventHandler(painel_MouseMove);
                //paineis[i].MouseDown += new MouseEventHandler(painel_MouseDown);


                //x.Paint += new PaintEventHandler(traco);
                //x.Location = new Point(45,12);

                //valor_x = valor_x + 200;
                //valor_y = valor_y + 200;

                
            }
             */
            quantidade_de_vagas2=quantidade_de_vagas2+1;
            painel_da_vaga2(quantidade_de_vagas2, "Vaga " + quantidade_de_vagas2 + "", 10, 10);
            

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            int posicao_x = 45, posicao_y = 12;
            for (int i = 0; i < quantidade_de_vagas2; i++)
            {
                painel_da_vaga2(i, "Vaga " + i + "", posicao_x, posicao_y);
                posicao_x = posicao_x + 10;
                posicao_y = posicao_y + 10;
                
            }

            label1.Text = andar2.ToString();

            

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            /*foreach (object obj in this.panel1.Controls)
            {
                if (obj is Panel)
                {

                }

            }*/
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

               

        private void button2_Click(object sender, EventArgs e)
        {
            paineis[comboBox1.SelectedIndex].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            paineis[comboBox1.SelectedIndex].Refresh();
            panel1.Refresh();

            //Bitmap bitmap = (Bitmap)paineis[comboBox1.SelectedIndex].Image;
            //paineis[comboBox1.SelectedIndex].Image = (Image)(RotateImg(bitmap, 30.0f, Color.Transparent)); ;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            preencher_combobox(comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            paineis[comboBox1.SelectedIndex].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            paineis[comboBox1.SelectedIndex].Refresh();
            panel1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 F1;
            F1 = new Form1();
            F1.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quantidade_de_vagas2 = quantidade_de_vagas2 - 1;
            panel1.Controls.Remove(paineis[comboBox2.SelectedIndex]);
            //painel_da_vaga2(quantidade_de_vagas2, "Vaga " + quantidade_de_vagas2 + "", 10, 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            preencher_combobox(comboBox2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            paineis[comboBox3.SelectedIndex].Width = (int)(paineis[comboBox3.SelectedIndex].Width / 1.25);
            paineis[comboBox3.SelectedIndex].Height = (int)(paineis[comboBox3.SelectedIndex].Height / 1.25);
            //paineis[comboBox3.SelectedIndex].Image.Size = new Size(20,30);
            paineis[comboBox3.SelectedIndex].SizeMode = PictureBoxSizeMode.Zoom;
            paineis[comboBox3.SelectedIndex].Refresh();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            preencher_combobox(comboBox3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            paineis[comboBox3.SelectedIndex].Height += 10;
            paineis[comboBox3.SelectedIndex].Width += 10;
            //pictureBox1.Image.Height += 10;
            paineis[comboBox3.SelectedIndex].SizeMode = PictureBoxSizeMode.Zoom;
            paineis[comboBox3.SelectedIndex].Refresh();
        }

       
    }
}
