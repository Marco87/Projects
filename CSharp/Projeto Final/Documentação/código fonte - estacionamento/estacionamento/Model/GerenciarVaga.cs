using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Estacionamento.View.Gestao;
using Estacionamento.View;
using Estacionamento.Control;

namespace Estacionamento.Model
{

    class GerenciarVaga
    {
        string Conexao;
        MySqlConnection conn;
        MySqlCommand comando;

        PictureBox[] picturebox = new PictureBox[500];
        Label[] labels = new Label[500];

        Vaga vg = new Vaga();



        struct angulo_excluido
        {
            public int vezes;
            public int excluido;
            public string estado_vaga;
            public int deficiente;
        }

        angulo_excluido[] a_z = new angulo_excluido[1000];


        int i = 0, x = 0, y = 0, angulo = 0, remove = -1, contar_vagas = 0, quantidade_de_vagas = -1, identificador_vaga, deficiente = -1;
        string vaga = "", situacao_da_vaga = "";

        Point ultimoClick;


        public void abrir_conexao()
        {
            Conexao = "Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento";
            conn = new MySqlConnection(Conexao);
            comando = conn.CreateCommand();
        }



        int andarExistente;
        public int consultarAndarExistente(int andarExist)
        {
            abrir_conexao();

            comando.CommandText = "select distinct andar from vaga where andar=" + andarExist + "";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    andarExistente = Convert.ToInt16(leitor.GetString(0));
                }


            }

            finally
            {

                conn.Close();
            }

            return andarExistente;

        }



        public void consultarAndar(ComboBox x)
        {
            abrir_conexao();
            comando.CommandText = "select distinct andar from vaga order by andar";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    x.Items.Add(leitor.GetString(0));
                }
            }

            finally
            {

                conn.Close();
            }


        }



        public void painel_da_vaga(int i, string nome_vaga, int posicao_x, int posicao_y, Panel p, int andares, int deficiente)
        {
            picturebox[i] = new PictureBox();
            picturebox[i].BackColor = Color.Transparent;
            picturebox[i].MouseMove += new MouseEventHandler((s, e) => painel_MouseMove(s, e, i));
            picturebox[i].MouseDown += new MouseEventHandler(painel_MouseDown);
            picturebox[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick(s, e, i, andares));
            picturebox[i].Location = new Point(posicao_x, posicao_y);
            if (deficiente == 1)
            {
                picturebox[i].Image = Properties.Resources.carro_verde_deficiente;
            }
            else
            {
                picturebox[i].Image = Properties.Resources.carro_verde2;
            }
            picturebox[i].Size = new Size(135, 180);
            picturebox[i].SizeMode = PictureBoxSizeMode.CenterImage;



            labels[i] = new Label();
            labels[i].Location = new Point(20, 155);
            labels[i].TextAlign = ContentAlignment.MiddleCenter;
            labels[i].Text = nome_vaga;
            labels[i].ForeColor = Color.White;
            labels[i].BackColor = Color.Transparent;
            labels[i].BringToFront();
            labels[i].Font = new Font("Arial", 16);



            p.Controls.Add(picturebox[i]);
            picturebox[i].Controls.Add(labels[i]);

        }

        public void painel_MouseDown(object sender, MouseEventArgs e)
        {
            ultimoClick = new Point(e.X, e.Y);
        }

        public void painel_MouseMove(object sender, MouseEventArgs e, int i)
        {

            if (e.Button == MouseButtons.Left)
            {
                picturebox[i].Left += e.X - ultimoClick.X;
                picturebox[i].Top += e.Y - ultimoClick.Y;

            }

        }

        public void painel_MouseClick(object sender, MouseEventArgs e, int i, int andares)
        {


            /*if (e.Button == MouseButtons.Right)
            {


                CadVagaIncluirIdentificador cvi = new CadVagaIncluirIdentificador();

                DialogResult rs = cvi.ShowDialog();
                if (rs == DialogResult.OK)
                {

                    identificador_vaga = vg.identificador_vaga;
                    labels[i].Text = andares +" - "+identificador_vaga;
                    picturebox[i].Refresh();

                }


            }*/

            if (e.Button == MouseButtons.Right)
            {


                CadVagaIncluirIdentificador cvi = new CadVagaIncluirIdentificador();

                DialogResult rs = cvi.ShowDialog();
                quantidade_de_vagas = vg.consultar_quantidade_vaga;

                if (rs == DialogResult.OK)
                {
                    identificador_vaga = vg.identificador_vaga;

                    if (!(retorna_vaga_existente(quantidade_de_vagas, identificador_vaga)))
                    {

                        MessageBox.Show("Vaga Existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        labels[i].Text = andares + " - " + identificador_vaga;
                        picturebox[i].Refresh();
                    }

                }

            }

        }


        public void preencher_combobox(ComboBox x, int quantidade_de_vagas)
        {

            for (int i = 0; i < quantidade_de_vagas; i++)
            {
                if (a_z[i].excluido == 0)
                {

                    x.Items.Add(labels[i].Text);

                }

                labels[i].Refresh();
            }


        }




        public int qual_vaga_combobox(ComboBox x, int quantidade_de_vagas, string vaga)
        {
            int vaga2 = -1;

            for (int i = 0; i < quantidade_de_vagas; i++)
            {
                if (labels[i].Text == vaga)
                {

                    vaga2 = i;

                }

            }

            return vaga2;
        }





        public void rotacionar(ComboBox c, Panel p, int quantidade)
        {

            picturebox[qual_vaga_combobox(c, quantidade, c.SelectedItem.ToString())].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picturebox[qual_vaga_combobox(c, quantidade, c.SelectedItem.ToString())].Refresh();
            p.Refresh();
            c.Refresh();

        }

        public void excluir_vaga(ComboBox c, Panel p, int quantidade)
        {
            picturebox[qual_vaga_combobox(c, quantidade, c.SelectedItem.ToString())].Controls.Remove(labels[c.SelectedIndex]);
            p.Controls.Remove(picturebox[qual_vaga_combobox(c, quantidade, c.SelectedItem.ToString())]);
        }

        public void calculo_rotacionar(int i)
        {
            a_z[i].vezes = a_z[i].vezes + 1;
        }

        public void calculo_excluir(int i)
        {
            a_z[i].excluido = a_z[i].excluido + 1;
        }

        public void calculo_rotacionar_inicial(int i)
        {
            a_z[i].vezes = 0;
        }

        public void calculo_excluir_inicial(int i)
        {
            a_z[i].excluido = 0;
        }

        public void calculo_deficiente_inicial(int i)
        {
            a_z[i].deficiente = 0;
        }

        public void calculo_deficiente(int i)
        {
            a_z[i].deficiente = 1;
        }



        public void salvar_bd(int quantidade_de_vagas, int andares, string situacao)
        {
            MySqlConnection conn;

            conn = new MySqlConnection("Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento");


            try
            {
                conn.Open();
                for (int i = 0; i < quantidade_de_vagas; i++)
                {


                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "INSERT INTO vaga (andar,vaga,tipo,situacao,posicao_x,posicao_y,angulo,remove) VALUES(" + andares + ",'" + labels[i].Text + "'," + a_z[i].deficiente + ",'" + situacao + "'," + picturebox[i].Location.X + "," + picturebox[i].Location.Y + ", " + a_z[i].vezes + ", " + a_z[i].excluido + ")";

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Registro incluído com sucesso.");
            }


            finally
            {

                conn.Close();
            }
        }



        public void salvar_bd_mais_andares(int quantidade_de_vagas, int andares, string situacao, int outros_andares)
        {
            MySqlConnection conn;

            conn = new MySqlConnection("Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento");


            try
            {
                conn.Open();
                for (int j = andares; j <= outros_andares; j++)
                {
                    for (int i = 0; i < quantidade_de_vagas; i++)
                    {


                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "INSERT INTO vaga (andar,vaga,tipo,situacao,posicao_x,posicao_y,angulo,remove) VALUES(" + j + ",'" + j + " - " + tratar_vaga(labels[i].Text) + "', " + a_z[i].deficiente + ",'" + situacao + "'," + picturebox[i].Location.X + "," + picturebox[i].Location.Y + ", " + a_z[i].vezes + ", " + a_z[i].excluido + ")";

                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Registro incluído com sucesso.");
            }


            finally
            {

                conn.Close();
            }
        }











        public void consultar_vagas(int andar, Panel p)
        {
            abrir_conexao();
            comando.CommandText = "select idVaga,vaga,situacao,posicao_x,posicao_y,angulo,remove,tipo from vaga where andar =" + andar + "";

           
            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    remove = Convert.ToInt32(leitor.GetString(6));
                    if (remove == 0)
                    {
                        i = Convert.ToInt32(leitor.GetString(0));
                        vaga = leitor.GetString(1);
                        situacao_da_vaga = leitor.GetString(2);
                        x = Convert.ToInt32(leitor.GetString(3));
                        y = Convert.ToInt32(leitor.GetString(4));
                        angulo = Convert.ToInt32(leitor.GetString(5));
                        deficiente = Convert.ToInt32(leitor.GetString(7));

                        painel_da_vaga_consultar(i, vaga, situacao_da_vaga, x, y, angulo, remove, p, deficiente);

                    }
                }
            }

            finally
            {

                conn.Close();
            }

        }



        public void painel_da_vaga_consultar(int i, string nome_vaga, string situacao_da_vaga, int posicao_x, int posicao_y, int angulo, int remove, Panel p, int deficiente)
        {
            picturebox[i] = new PictureBox();
            picturebox[i].BackColor = Color.Transparent;
            picturebox[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick_consultar(s, e, i, angulo,deficiente));
            picturebox[i].Location = new Point(posicao_x, posicao_y);


            if (situacao_da_vaga == "DISPONÍVEL")
            {
                
                if (deficiente == 1)
                {
                    picturebox[i].Image = Properties.Resources.carro_verde_deficiente;
                   
                }
                else
                {
                    picturebox[i].Image = Properties.Resources.carro_verde2;
                }

            }
            else
            {
               
                if (situacao_da_vaga == "OCUPADO")
                {
                    if (deficiente == 1)
                    {
                        picturebox[i].Image = Properties.Resources.carro_vermelho_deficiente;
                    }
                    else
                    {
                        picturebox[i].Image = Properties.Resources.carro_vermelho2;
                    }
                    
                }
                else
                {
                    
                    if (deficiente == 1)
                    {
                        picturebox[i].Image = Properties.Resources.carro_amarelo_deficiente;
                    }
                    else
                    {
                        picturebox[i].Image = Properties.Resources.carro_amarelo2;
                    }
                    
                }

            }


            picturebox[i].Size = new Size(135, 180);
            picturebox[i].SizeMode = PictureBoxSizeMode.CenterImage;

            labels[i] = new Label();
            labels[i].Location = new Point(20, 155);
            labels[i].TextAlign = ContentAlignment.MiddleCenter;
            labels[i].Text = nome_vaga;
            labels[i].ForeColor = Color.White;
            labels[i].BackColor = Color.Transparent;
            labels[i].BringToFront();
            labels[i].Font = new Font("Arial", 16);

            p.Controls.Add(picturebox[i]);
            picturebox[i].Controls.Add(labels[i]);


            for (int c = 0; c < angulo; c++)
            {
                picturebox[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picturebox[i].Refresh();
                p.Refresh();

            }

        }

        public void painel_MouseClick_consultar(object sender, MouseEventArgs e, int i, int ang,int deficiente)
        {
            string estado_vaga;

            idDaVagaAlteradaEstacionar(i);

            if (e.Button == MouseButtons.Left)
            {


                ConsuVagaEstado cve = new ConsuVagaEstado();
                DialogResult rsi = cve.ShowDialog();


                if (rsi == DialogResult.OK)
                {

                    estado_vaga = vg.estado_vaga;

                    if (estado_vaga == "DISPONÍVEL")
                    {

                        if (deficiente == 1)
                        {
                            picturebox[i].Image = Properties.Resources.carro_verde_deficiente;
                        }
                        else
                        {
                            picturebox[i].Image = Properties.Resources.carro_verde2;
                        }

                        mudar_estado("DISPONÍVEL", i);

                        retorna_id_quando_muda_estado(i);
                    }
                    else
                    {
                        if (estado_vaga == "OCUPADO")
                        {
                            if (deficiente == 1)
                            {
                                picturebox[i].Image = Properties.Resources.carro_vermelho_deficiente;
                            }
                            else
                            {
                                picturebox[i].Image = Properties.Resources.carro_vermelho2;
                            }
                            mudar_estado("OCUPADO", i);
                            retorna_id_quando_muda_estado(i);
                        }
                        else
                        {
                            if (deficiente == 1)
                            {
                                picturebox[i].Image = Properties.Resources.carro_amarelo_deficiente;
                            }
                            else
                            {
                                picturebox[i].Image = Properties.Resources.carro_amarelo2;
                            }
                            mudar_estado("RESERVADO", i);
                            retorna_id_quando_muda_estado(i);
                        }

                    }

                    for (int c = 0; c < ang; c++)
                    {
                        picturebox[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        picturebox[i].Refresh();
                    }

                }


            }
        }

        //Método usado para retornar o id da vaga alterada na rotina de entrada do estacionamento
        public int idDaVagaAlteradaEstacionar(int i)
        {
            Vaga va = new Vaga();
            va.identificador_vaga = i;
            return i;
        }

        public void mudar_estado(string situacao, int id)
        {

            MySqlConnection conn;

            conn = new MySqlConnection("Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento");
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE vaga SET situacao = '" + situacao + "' WHERE idVaga = " + id + "";

                cmd.ExecuteNonQuery();
            }

            finally
            {

                conn.Close();
            }

        }

        //Método criado para alterar o estado da vaga (ocupado para disponível) no término da rotina de estacionar
        public bool mudar_estado_vaga_estacionar(string situacao, int id)
        {

            MySqlConnection conn;

            conn = new MySqlConnection("Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento");
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE vaga SET situacao = '" + situacao + "' WHERE idVaga = " + id + "";

                cmd.ExecuteNonQuery();
            }

            finally
            {

                conn.Close();
            }

            return true;

        }

        public int retorna_id_quando_muda_estado(int id)
        {
            return id;
        }





















        public void alterar_vagas(int andar, Panel p)
        {

            abrir_conexao();
            comando.CommandText = "select vaga,situacao,posicao_x,posicao_y,angulo,remove,tipo from vaga where andar =" + andar + "";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    remove = Convert.ToInt32(leitor.GetString(5));
                    if (remove == 0)
                    {

                        //i = Convert.ToInt32(leitor.GetString(0));
                        vaga = leitor.GetString(0);
                        situacao_da_vaga = leitor.GetString(1);
                        x = Convert.ToInt32(leitor.GetString(2));
                        y = Convert.ToInt32(leitor.GetString(3));
                        angulo = Convert.ToInt32(leitor.GetString(4));
                        deficiente = Convert.ToInt32(leitor.GetString(6));

                        painel_da_vaga_alterar(contar_vagas, vaga, situacao_da_vaga, x, y, angulo, p, andar,deficiente);


                        contar_vagas = contar_vagas + 1;
                    }

                }
            }

            finally
            {

                conn.Close();
            }


            vg.consultar_quantidade_vaga = contar_vagas;

        }



        public void painel_da_vaga_alterar(int i, string nome_vaga, string situacao_da_vaga, int posicao_x, int posicao_y, int angulo, Panel p, int andares, int deficiente)
        {

            picturebox[i] = new PictureBox();
            picturebox[i].BackColor = Color.Transparent;
            picturebox[i].MouseMove += new MouseEventHandler((s, e) => painel_MouseMove(s, e, i));
            picturebox[i].MouseDown += new MouseEventHandler(painel_MouseDown);
            picturebox[i].MouseClick += new MouseEventHandler((s, e) => painel_MouseClick_alterar(s, e, nome_vaga, i, andares)); //,andares));
            picturebox[i].Location = new Point(posicao_x, posicao_y);

            if (situacao_da_vaga == "DISPONÍVEL")
            {
                if (deficiente == 1)
                {
                    picturebox[i].Image = Properties.Resources.carro_verde_deficiente;
                    calculo_deficiente(i);
                }
                else
                {
                    picturebox[i].Image = Properties.Resources.carro_verde2;
                    calculo_deficiente_inicial(i);
                }
                a_z[i].estado_vaga = situacao_da_vaga;

            }
            else
            {
                if (situacao_da_vaga == "OCUPADO")
                {
                    if (deficiente == 1)
                    {
                        picturebox[i].Image = Properties.Resources.carro_vermelho_deficiente;
                        calculo_deficiente(i);
                    }
                    else
                    {
                        picturebox[i].Image = Properties.Resources.carro_vermelho2;
                        calculo_deficiente_inicial(i);
                    }
                    a_z[i].estado_vaga = situacao_da_vaga;
                }
                else
                {
                    if (deficiente == 1)
                    {
                        picturebox[i].Image = Properties.Resources.carro_amarelo_deficiente;
                        calculo_deficiente(i);
                    }
                    else
                    {
                        picturebox[i].Image = Properties.Resources.carro_amarelo2;
                        calculo_deficiente_inicial(i);
                    }
                    a_z[i].estado_vaga = situacao_da_vaga;
                }

            }


            picturebox[i].Size = new Size(135, 180);
            picturebox[i].SizeMode = PictureBoxSizeMode.CenterImage;

            labels[i] = new Label();
            labels[i].Location = new Point(20, 155);
            labels[i].TextAlign = ContentAlignment.MiddleCenter;
            labels[i].Text = nome_vaga;
            labels[i].ForeColor = Color.White;
            labels[i].BackColor = Color.Transparent;
            labels[i].BringToFront();
            labels[i].Font = new Font("Arial", 16);

            p.Controls.Add(picturebox[i]);
            picturebox[i].Controls.Add(labels[i]);


            for (int c = 0; c < angulo; c++)
            {
                picturebox[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picturebox[i].Refresh();
                p.Refresh();
                calculo_rotacionar(i);

            }

            calculo_excluir_inicial(i);


        }


        public void painel_MouseClick_alterar(object sender, MouseEventArgs e, string vaga, int i, int andar)
        {


            if (e.Button == MouseButtons.Right)
            {


                CadVagaIncluirIdentificador cvi = new CadVagaIncluirIdentificador();

                DialogResult rs = cvi.ShowDialog();
                quantidade_de_vagas = vg.consultar_quantidade_vaga;

                if (rs == DialogResult.OK)
                {
                    identificador_vaga = vg.identificador_vaga;

                    if (!(retorna_vaga_existente(quantidade_de_vagas, identificador_vaga)))
                    {

                        MessageBox.Show("Vaga Existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        labels[i].Text = andar + " - " + identificador_vaga;
                        picturebox[i].Refresh();
                    }

                }

            }

        }

        public void excluir_tudo(int andar)
        {
            MySqlConnection conn;

            conn = new MySqlConnection("Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento");
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "DELETE FROM vaga WHERE andar = " + andar + ";";

                cmd.ExecuteNonQuery();
            }

            finally
            {

                conn.Close();
            }
        }




        public void salvar_bd_alterar(int quantidade_de_vagas, int andares)
        {

            MySqlConnection conn;

            conn = new MySqlConnection("Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento");

            try
            {
                conn.Open();
                for (int i = 0; i < quantidade_de_vagas; i++)
                {


                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "INSERT INTO vaga (andar,vaga,situacao,posicao_x,posicao_y,angulo,remove,tipo) VALUES(" + andares + ",'" + labels[i].Text + "','" + a_z[i].estado_vaga + "'," + picturebox[i].Location.X + "," + picturebox[i].Location.Y + ", " + a_z[i].vezes + ", " + a_z[i].excluido + ", " + a_z[i].deficiente + ")";

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Registro incluído com sucesso.");
            }

            finally
            {

                conn.Close();
            }
        }


        public void mudar_estado_alterar(ComboBox a, ComboBox b, int quantidade)
        {
            if (b.SelectedItem.ToString() == "DISPONÍVEL")
            {
                if (a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].deficiente == 1)
                {
                    picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image = Properties.Resources.carro_verde_deficiente;
                }
                else
                {
                    picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image = Properties.Resources.carro_verde2;
                }
                a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].estado_vaga = "DISPONÍVEL";

            }
            else
            {
                if (b.SelectedItem.ToString() == "OCUPADO")
                {
                    if (a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].deficiente == 1)
                    {
                        picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image = Properties.Resources.carro_vermelho_deficiente;
                    }
                    else
                    {
                        picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image = Properties.Resources.carro_vermelho2;
                    }
                    a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].estado_vaga = "OCUPADO";
                }
                else
                {
                    if (a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].deficiente == 1)
                    {
                        picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image = Properties.Resources.carro_amarelo_deficiente;
                    }
                    else
                    {
                        picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image = Properties.Resources.carro_amarelo2;
                    }
                    a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].estado_vaga = "RESERVADO";
                }

            }

            for (int z = 0; z < a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].vezes; z++)
            {
                picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picturebox[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].Refresh();
            }
        }

        public bool retorna_situacao_vaga(ComboBox a, int quantidade, string estado_da_vaga)
        {
            if (a_z[qual_vaga_combobox(a, quantidade, a.SelectedItem.ToString())].estado_vaga == estado_da_vaga)
            {
                return false;

            }
            else
            {
                return true;
            }

        }

        public string tratar_vaga(string v)
        {
            int z = v.IndexOf('-');
            string d = v.Substring(z + 2);
            return d;
        }


        bool a;
        public bool retorna_vaga_existente(int quantidade_de_vag, int vaga)
        {

            for (int i = 0; i < quantidade_de_vag; i++)
            {

                if (a_z[i].excluido == 0)
                {

                    if (Convert.ToInt16(tratar_vaga(labels[i].Text)) == vaga)
                    {

                        a = false;

                        break;
                    }
                    else
                    {
                        a = true;

                    }

                }
            }
            return a;

        }


    }
}
