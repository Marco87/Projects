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
using Estacionamento.Control;
using Estacionamento.Controller;
using System.Globalization;


namespace Estacionamento.Model
{
    class GerenciarRelatorios
    {
        string Conexao;
        MySqlConnection conn;
        MySqlCommand comando;

        public void abrir_conexao()
        {
            Conexao = "Server=186.202.152.106;Database=estrelaoriental3;Uid=estrelaoriental3;Pwd=estacionamento";
            conn = new MySqlConnection(Conexao);
            comando = conn.CreateCommand();
        }

        public bool GeraRelatorioCliente(string tipo, DataGridView grid)
        {
            abrir_conexao();
            int cont = 0;
            comando.CommandText = "select distinct nome, telefone, celular, endereco, c.idcliente \n";
            if (tipo == "")
            {
                comando.CommandText = comando.CommandText + "from cliente c left join gerenciar_situacao_pagamento g" + "\n";
            }
            else
            {
                comando.CommandText = comando.CommandText + "from cliente c join gerenciar_situacao_pagamento g" + "\n";
            }
            comando.CommandText = comando.CommandText + "on c.idcliente = g.idcliente \n";
            if (tipo != "")
            {
                comando.CommandText = comando.CommandText + "and idTipoPlanoEstacionamento = " + tipo + "\n";
            }
            comando.CommandText = comando.CommandText + "order by nome \n";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    grid.Rows.Add();
                    grid.Rows[cont].Cells[0].Value = leitor.GetString(0);
                    grid.Rows[cont].Cells[1].Value = leitor.GetString(1);
                    grid.Rows[cont].Cells[2].Value = leitor.GetString(2);
                    grid.Rows[cont].Cells[3].Value = leitor.GetString(3);
                    grid.Rows[cont].Cells[4].Value = leitor.GetString(4);
                    cont = cont + 1;
                }

            }
            catch
            {
                conn.Close();
                return false;
            }

            finally
            {
                conn.Close();
            }

            return true;
        }


        public bool GeraRelatorioFinanceiro(string dataInicio, string dataFim, DataGridView grid)
        {
            decimal total = 0;   
            abrir_conexao();
            int cont = 0;
            comando.CommandText = "select DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y'), convert(sum(valor),decimal(10,2)) " + "\n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c, gerenciar_situacao_pagamento g" + "\n";
            comando.CommandText = comando.CommandText + "where valor is not null" + "\n";
            comando.CommandText = comando.CommandText + "and valor > 0" + "\n";
            comando.CommandText = comando.CommandText + "and dataHoraEntrada between '" + dataInicio + "' and '" + dataFim + "'\n";
            comando.CommandText = comando.CommandText + "and c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento" + "\n";
            comando.CommandText = comando.CommandText + "and idTipoPlanoEstacionamento in(1,2)" + "\n";
            comando.CommandText = comando.CommandText + "group by DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') order by dataHoraEntrada" + "\n";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    grid.Rows.Add();
                    grid.Rows[cont].Cells[0].Value = leitor.GetString(0);
                    grid.Rows[cont].Cells[1].Value = leitor.GetString(1);
                    total = total + Convert.ToDecimal(grid.Rows[cont].Cells[1].Value);
                    cont = cont + 1;                   
                }
                grid.Rows.Add();
                grid.Rows[cont].Cells[0].Value = "TOTAL:";
                grid.Rows[cont].Cells[1].Value = total;
            }
            catch
            {
                conn.Close();
                return false;
            }

            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool CarregaComboPlano(ComboBox combo)
        {
            abrir_conexao();
            int cont = 0;
            comando.CommandText = "select idTipoEstacionamento, descricao" + "\n";
            comando.CommandText = comando.CommandText + "from tipo_plano_estacionamento \n";
            comando.CommandText = comando.CommandText + "order by idTipoEstacionamento";
            
            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    combo.Items.Add(leitor.GetString(0) + " - " + leitor.GetString(1));
                }

            }
            catch
            {
                conn.Close();
                return false;
            }

            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool GeraRelatorioHistoricoCliente(DataGridView grid)
        {
            abrir_conexao();
            int cont = 0;
            comando.CommandText = "select placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), ifnull(convert(valor,decimal(10,2)),0) \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in (1,2) \n";
            comando.CommandText = comando.CommandText + "and g.idCliente = " + Globais.idclientehist + "\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(3,4,5,6,7,8) \n";
            comando.CommandText = comando.CommandText + "and g.idCliente = " + Globais.idclientehist + "\n";

            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    grid.Rows.Add();
                    grid.Rows[cont].Cells[0].Value = leitor.GetString(0);
                    grid.Rows[cont].Cells[1].Value = leitor.GetString(1);
                    grid.Rows[cont].Cells[2].Value = leitor.GetString(2);
                    grid.Rows[cont].Cells[3].Value = leitor.GetString(3);
                    cont = cont + 1;
                }

            }
            catch
            {
                conn.Close();
                return false;
            }

            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool GeraRelatorioDiario(DataGridView grid, string dataInicio)
        {
            abrir_conexao();
            int cont = 0;
            string tipo, tipo_anterior;
            tipo_anterior = "";
            decimal total = 0;
            grid.Rows.Clear();

            comando.CommandText = "select  'ROTATIVO', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), ifnull(convert(valor,decimal(10,2)),0.00) \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in (1) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'DIARIO', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 15.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(2) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'MENSAL', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(3) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'BIMESTRAL', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(5) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'TRIMESTRAL', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(6) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'QUADRIMESTRAL', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(8) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'SEMESTRAL', placa, dataHoraEntrada,ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(7) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            comando.CommandText = comando.CommandText + "Union all \n";

            comando.CommandText = comando.CommandText + "select  'ANUAL', placa, dataHoraEntrada, ifnull(dataHoraSaida,dataHoraEntrada), 0.00  \n";
            comando.CommandText = comando.CommandText + "from controle_estacionar c join gerenciar_situacao_pagamento g \n";
            comando.CommandText = comando.CommandText + "on c.idGerenciarSituacaoPagamento = g.idGerenciarSituacaoPagamento \n";
            comando.CommandText = comando.CommandText + "join veiculo v \n";
            comando.CommandText = comando.CommandText + "on g.idVeiculo = v.idVeiculo \n";
            comando.CommandText = comando.CommandText + "where idTipoPlanoEstacionamento in(4) \n";
            comando.CommandText = comando.CommandText + "and DATE_FORMAT(dataHoraEntrada,'%d/%m/%Y') = '" + dataInicio + "'\n";

            //comando.CommandText = comando.CommandText + "order by tipo, dataHoraEntrada";


            try
            {

                conn.Open();
                MySqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    tipo = leitor.GetString(0);
                    if (tipo != tipo_anterior)
                    {    
                        tipo_anterior = tipo;
                        if (total != 0)
                        {
                            grid.Rows.Add();
                            grid.Rows[cont].Cells[3].Value = "TOTAL: ";
                            grid.Rows[cont].Cells[4].Value = total;
                            grid.Rows.Add();
                            cont = cont + 1;
                            grid.Rows.Add();
                            cont = cont + 1;
                            total = 0;
                        }
                        grid.Rows.Add();
                        grid.Rows[cont].Cells[0].Value = leitor.GetString(0);
                        grid.Rows[cont].Cells[1].Value = leitor.GetString(1);
                        grid.Rows[cont].Cells[2].Value = leitor.GetString(2);
                        grid.Rows[cont].Cells[3].Value = leitor.GetString(3);
                        grid.Rows[cont].Cells[4].Value = leitor.GetString(4);
                        total = total + Convert.ToDecimal(grid.Rows[cont].Cells[4].Value);
                        cont = cont + 1;

                    }
                    else
                    {
                        grid.Rows.Add();
                        grid.Rows[cont].Cells[1].Value = leitor.GetString(1);
                        grid.Rows[cont].Cells[2].Value = leitor.GetString(2);
                        grid.Rows[cont].Cells[3].Value = leitor.GetString(3);
                        grid.Rows[cont].Cells[4].Value = leitor.GetString(4);
                        total = total + Convert.ToDecimal(grid.Rows[cont].Cells[4].Value);
                        cont = cont + 1;
                    }
                   
                        
                   
                }

            }
            catch
            {
                conn.Close();
                return false;
            }

            finally
            {
                conn.Close();
            }

            return true;
        }

    }
}
