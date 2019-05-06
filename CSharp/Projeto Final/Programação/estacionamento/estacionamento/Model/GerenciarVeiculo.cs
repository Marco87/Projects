using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Estacionamento.Control;

namespace Estacionamento.Model
{
    class GerenciarVeiculo
    {
        Cliente clie = new Cliente();
        TipoEstacionamento tipoEst = new TipoEstacionamento();
        Veiculo ve = new Veiculo();

        public bool inserirVeiculo(string placa, string marca, string modelo, string ano)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    veiculo vei = new veiculo();

                    vei.placa = placa;
                    vei.marca = marca;
                    vei.modelo = modelo;
                    vei.ano = ano;
                    vei.idCliente = clie.idCliente;

                    estrela.veiculo.AddObject(vei);
                    estrela.SaveChanges();

                    ve.idVeiculo = vei.idVeiculo;

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Altera os dados de um veículo.
        public bool alterarVeiculo(string placa, string marca, string modelo, string ano, int idCliente)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var v = (from ve in estrela.veiculo
                             where ve.placa == placa
                             select ve).FirstOrDefault();


                    v.placa = placa;
                    v.marca = marca;
                    v.modelo = modelo;
                    v.ano = ano;
                    v.idCliente = idCliente;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Verifica se a placa digitada consta no sistema, e retorna true caso não conste
        public bool consultarPlaca(string placaDig)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    Veiculo vei = new Veiculo();

                    var ve = (from v in estrela.veiculo
                              where v.placa == placaDig
                              select v).FirstOrDefault();

                    if (ve == null)
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Exibe os dados do veículo que tiver a placa passada como referência.
        public List<veiculo> exibirVeiculoPorPlaca(string placa)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<veiculo> v = from ve in estrela.veiculo
                                            where ve.placa == placa
                                            select ve;

                    return v.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        //Retorna o id do cliente mediante a placa usada como parâmetro
        public int retornarIdClientePorPlaca(string placa)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from cl in estrela.veiculo
                             where cl.placa == placa
                             select cl).FirstOrDefault();
                    if (c != null)
                    {
                        clie.idCliente = c.idCliente;
                        return c.idCliente;
                    }
                    else
                        return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        //Retorna o id do veículo mediante a placa usada como parâmetro
        public int retornarIdVeiculoPorPlaca(string placa)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {

                    //Veiculo ve = new Veiculo();

                    var veic = (from vei in estrela.veiculo
                                where vei.placa == placa
                                select vei).FirstOrDefault();

                    if (veic != null)
                    {
                        ve.idVeiculo = veic.idVeiculo;
                        return veic.idVeiculo;
                    }
                    else
                        return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        //Exclui um veículo do sistema mediante a passagem de uma placa como referência
        public bool apagarVeiculo(string placa)
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                try
                {
                    var v = (from ve in estrela.veiculo
                             where ve.placa == placa
                             select ve).FirstOrDefault();

                    estrela.DeleteObject(v);
                    estrela.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }

        //Retorna as placas cadastradas para um usuário, tendo como parâmetro o seu id
        public List<string> preencherComboPlaca(int id)
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                IQueryable<veiculo> listaPlaca = from pl in estrela.veiculo
                                                 where pl.idCliente == id
                                                 select pl;

                List<string> listaPla = new List<string>();

                foreach (veiculo v in listaPlaca)
                {
                    string placa = v.placa;
                    listaPla.Add(placa);
                }

                return listaPla;
            }
        }

        //Remove o veículo que tiver o id do cliente passado como referência.
        public bool apagarVeiculoPorIdCliente(int idCliente)
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                try
                {
                    var v = (from ve in estrela.veiculo
                             where ve.idCliente == idCliente
                             select ve).FirstOrDefault();

                    estrela.DeleteObject(v);
                    estrela.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
