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


namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

            //WindowState = FormWindowState.Maximized;
            //panel1.Left = 0;
            //panel1.Top = 0;
            //panel1.Width = Convert.ToInt16((Screen.PrimaryScreen.Bounds.Width)*(0.9)); //redimensionar tela
            //panel1.Height = Screen.PrimaryScreen.Bounds.Height; //redimensionar tela

            
        }

        Point lastClick;
        //Panel[] blackPanel = new Panel[10];
        //int vagas2 = Convert.ToInt16(quantidade_de_vagas());
        Panel[] paineis = new Panel[1000];
        int valor_x, valor_y;
        //int vagas2 = quantidade_de_vagas();
        //PictureBox[] imagens = new PictureBox[50];

        Image imagem;

        
        

        public int quantidade_de_linhas()
        {
            int quantidade_de_vagas2 = 0;

            string Conexao = "Server=127.0.0.1;Database=estacionamento;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(Conexao);
            MySqlCommand comando = conn.CreateCommand();
            comando.CommandText = "select max(linha) from vaga";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    quantidade_de_vagas2 = Convert.ToInt32(leitor.GetString(0));
                }
            }
            //catch (MySqlException erro)
            //{
            // MessageBox.Show("Erro Ao Consultar Dado!", erro.Message);
            //}
            finally
            {

                conn.Close();
            }
            //MessageBox.Show(quantidade_de_vagas2.ToString());
            return quantidade_de_vagas2;

        }

        /* public int quantidade_de_vagas_numa_linha()
         {
             int quantidade_de_vagas3 = 0;

             string Conexao = "Server=127.0.0.1;Database=estacionamento;Uid=root;Pwd=258258";
             MySqlConnection conn = new MySqlConnection(Conexao);
             MySqlCommand comando = conn.CreateCommand();
             comando.CommandText = "select COUNT(coluna) from vaga where linha = 1";

             try
             {


                 conn.Open();
                 MySqlDataReader leitor = comando.ExecuteReader();

                 while (leitor.Read())
                 {
                     quantidade_de_vagas3 = Convert.ToInt32(leitor.GetString(0));
                 }
             }
             catch (MySqlException erro)
             {
                 MessageBox.Show("Erro Ao Consultar Dado!", erro.Message);
             }
             //MessageBox.Show(quantidade_de_vagas2.ToString());
             return quantidade_de_vagas3;

         }
         */
        public void linha_horizontal(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 2, 5, 3 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(11, 5), new Point(109, 5));
        }

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

        public void painel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X, e.Y);
        }

        private void painel_MouseMove(object sender, MouseEventArgs e)
        {
            //blackPanel[1].Select = true;
            for (int i = 0; i < 10; i++)
            {
                //if (blackPanel[i].Focus())
                //{
                if (e.Button == MouseButtons.Left)// && paineis[i].Focus())
                {
                    paineis[i].Left += e.X - lastClick.X;
                    paineis[i].Top += e.Y - lastClick.Y;

                }
                //System.Windows.Forms.MessageBox.Show(i.ToString());
                //}
            }
        }

        private void painel_MouseMove2(object sender, MouseEventArgs e, Panel painel)
        {
            if (e.Button == MouseButtons.Left)
            {
                painel.Left += e.X - lastClick.X;
                painel.Top += e.Y - lastClick.Y;
            }
        }

        public int quantidade_de_colunas_por_linha(int x)
        {
            int quantidade_de_vagas3 = 0;
            string Conexao = "Server=127.0.0.1;Database=estacionamento;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(Conexao);
            MySqlCommand comando = conn.CreateCommand();

            comando.CommandText = "select COUNT(coluna) from vaga where linha = '" + x + "'";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    quantidade_de_vagas3 = Convert.ToInt32(leitor.GetString(0));
                    //linhas = Convert.ToInt32(leitor.GetString(1));
                }
            }

            //catch (MySqlException erro)
            //{
            //MessageBox.Show("Erro Ao Consultar Dado!", erro.Message);
            //}

            finally
            {

                conn.Close();
            }

            return quantidade_de_vagas3;

            
        }

        public int vagas(int x,int z)
        {
            string vagas2 = "";
            int vaga3 = 0;
            string Conexao = "Server=127.0.0.1;Database=estacionamento;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(Conexao);
            MySqlCommand comando = conn.CreateCommand();

            comando.CommandText = "select situacao from vaga where linha= '" + x + "' and coluna = '" + z + "'";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    vagas2 = leitor.GetString(0);
                    //linhas = Convert.ToInt32(leitor.GetString(1));
                }
            }

            //catch (MySqlException erro)
            //{
            //MessageBox.Show("Erro Ao Consultar Dado!", erro.Message);
            //}

            finally
            {

                conn.Close();
            }

            if(vagas2 == "DISPONÍVEL")
            {
                vaga3 = 1;
            }
            else
            {
                if(vagas2 =="OCUPADO")
                {
                    vaga3 = 2;
                }
                else
                {
                    vaga3 = 3;
                }

            }

            return vaga3;
        }

        public void painel_da_vaga()
        {
                        
            int p = 1;//, linhas;

            
            while (p <= quantidade_de_linhas())
            {

                

                valor_x = 45;


                if (p == 1)
                    valor_y = 12;
                else
                    valor_y = valor_y + 150;

                for (int i = 0; i < quantidade_de_colunas_por_linha(p); i++)
                {
                    paineis[i] = new Panel();
                    // Set color, location and size of the black panel
                    paineis[i].BackColor = Color.Transparent;
                    paineis[i].Size = new Size(190, 120);
                    paineis[i].Paint += new PaintEventHandler(linha_horizontal);
                    paineis[i].Paint += new PaintEventHandler(linha_vertical_direita);
                    paineis[i].Paint += new PaintEventHandler(linha_vertical_esquerda);

                    //paineis[i].MouseMove += new MouseEventHandler(painel_MouseMove);


                    if (vagas(p, i) == 1)
                    {
                        paineis[i].Paint += new PaintEventHandler(carro_verde);
                    }
                    else
                    {
                        if (vagas(p, i) == 2)
                        {
                            paineis[i].Paint += new PaintEventHandler(carro_vermelho);
                        }
                        else
                        {
                            paineis[i].Paint += new PaintEventHandler(carro_amarelo);
                        }

                    }


                    paineis[i].Paint += new PaintEventHandler(escrever);

                   
                    paineis[i].Location = new Point(valor_x, valor_y);
                    valor_x = valor_x + 200;


                    panel1.Controls.Add(paineis[i]);


                    //for (int j = i; j < quantidade_de_vagas3; j++)
                    //{

                    //MessageBox.Show(valor_x.ToString());
                    //valor_y = valor_y + 200;
                    //}

                    //blackPanel[i].MouseDown += new MouseEventHandler(painel_MouseDown);
                    //blackPanel[i].MouseMove += new MouseEventHandler(painel_MouseMove);
                    //System.Windows.Forms.MessageBox.Show(i.ToString());

                    // blackPanel[i].Left += e.button
                    //blackPanel.Paint() = linha(sender, e);

                    // Same here with the white one
                    //whitePanel.BackColor = Color.White;
                    //whitePanel.Location = new Point(110, 10);
                    //whitePanel.Size = new Size(90, 90);

                    // That's the point, container controls exposes the Controls
                    // collection that you could use to add controls programatically

                    //l[i].Text = "L";
                    //blackPanel[i].Controls[i].Text = "ola";
                    
                    // blackPanel.Controls.Add (linha(sender, e));
                    //panel1.Controls.Add(whitePanel);
                }

                p++;
            }

        }

        public void carro_vermelho(object sender, PaintEventArgs e)
        {
           
            
            imagem = Image.FromFile(@"C:\Users\Caco\Desktop\carro-vermelho1.png");
            
            e.Graphics.DrawImage(imagem, new Point(30, 13)); 


            //usar esse
            //float[] dashValues = { 20, 20, 20, 20 };
            //Pen retangulo = new Pen(Color.Black, 25);
            //retangulo.DashPattern = dashValues;
            //e.Graphics.DrawLine(retangulo, new Point(50, 70), new Point(70, 70));
        }

        public void carro_verde(object sender, PaintEventArgs e)
        {
            imagem = Image.FromFile(@"C:\Users\Caco\Desktop\carro-verde1.png");
            e.Graphics.DrawImage(imagem, new Point(30, 13)); 
        }

        public void carro_amarelo(object sender, PaintEventArgs e)
        {
            imagem = Image.FromFile(@"C:\Users\Caco\Desktop\carro-amarelo1.png");
            e.Graphics.DrawImage(imagem, new Point(30, 13));
        }

        public void escrever(object sender, PaintEventArgs e)
        {
            SolidBrush blush = new SolidBrush(Color.White);
            //e.Graphics.FillRectangle(blush, 7, 10, 30 - 19, 5);
            Font fonte = new Font("Arial", 20);
            e.Graphics.DrawString("test", fonte, blush, new PointF(75, 120));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       

       
        private void Form2_Load(object sender, EventArgs e)
        {
            painel_da_vaga();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*
        public void vagas_certas(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                blackPanel[i] = new Panel();
                // Set color, location and size of the black panel
                blackPanel[i].BackColor = Color.Gray;
                blackPanel[i].Location = new Point(10, 10);
                blackPanel[i].Size = new Size(279, 118);
                blackPanel[i].Paint += new PaintEventHandler(linha_horizontal);
                blackPanel[i].Paint += new PaintEventHandler(linha_vertical_direita);

                blackPanel[i].MouseDown += new MouseEventHandler(painel_MouseDown);
                blackPanel[i].MouseMove += new MouseEventHandler(painel_MouseMove);
                //System.Windows.Forms.MessageBox.Show(i.ToString());

                // blackPanel[i].Left += e.button
                //blackPanel.Paint() = linha(sender, e);

                // Same here with the white one
                //whitePanel.BackColor = Color.White;
                //whitePanel.Location = new Point(110, 10);
                //whitePanel.Size = new Size(90, 90);

                // That's the point, container controls exposes the Controls
                // collection that you could use to add controls programatically

                //l[i].Text = "L";
                //blackPanel[i].Controls[i].Text = "ola";
                panel1.Controls.Add(blackPanel[i]);
                // blackPanel.Controls.Add (linha(sender, e));
                //panel1.Controls.Add(whitePanel);
            }

        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
            
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //panel2.Top = (int)(panel2.Top - (panel2.Height * 0.05));
            //panel2.Left = (int)(panel2.Left - (panel2.Width * 0.05));
            //panel2.Height = (int)(panel2.Height + (panel2.Height * 0.05));
            //panel2.Width = (int)(panel2.Width + (panel2.Width * 0.05));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panel2.Top = (int)(panel2.Top + (panel2.Height * 0.05));
            //panel2.Left = (int)(panel2.Left + (panel2.Width * 0.05));
            //panel2.Height = (int)(panel2.Height - (panel2.Height * 0.05));
            //panel2.Width = (int)(panel2.Width - (panel2.Width * 0.05));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel2.RotateFlip(RotateFlipType.Rotate90FlipY);
            //panel2.Refresh();
        }

        /*
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel2);
            if (e.Button == MouseButtons.Left)
            {
                panel2.Left += e.X - lastClick.X;
                panel2.Top += e.Y - lastClick.Y;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
             
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
             
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
             
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            linha_horizontal(sender, e);
            linha_vertical_direita(sender, e);
            linha_vertical_esquerda(sender, e);
            traco(sender, e);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel3);
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel12_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel13_MouseDown(object sender, MouseEventArgs e)
        {
            painel_MouseDown(sender, e);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel4);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel5);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel6);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel7);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel8);
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel9);
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel10);
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel11);
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel12);
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            painel_MouseMove2(sender, e, panel13);
        }
         */
    }
}
