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
    class GerenciarControleEstacionamento
    {
        public bool inserirEntradaEstacionamento(int idGerenciarSituacaoPagamento, DateTime dataHoraEntrada, int idVaga)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    controle_estacionar contEst = new controle_estacionar();

                    contEst.idGerenciarSituacaoPagamento = idGerenciarSituacaoPagamento;
                    contEst.dataHoraEntrada = dataHoraEntrada;
                    contEst.idVaga = idVaga;

                    estrela.controle_estacionar.AddObject(contEst);
                    estrela.SaveChanges();

                    return true;

                }
            }
            catch
            {
                return false;
            }
        }

        //Verifica se o cliente entrou no estacionamento
        public bool verificarSeVeiculoEstacionou(int idGerenciarSituacaoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from co in estrela.controle_estacionar
                             where (co.idGerenciarSituacaoPagamento == idGerenciarSituacaoPagamento) && (co.dataHoraSaida == null)
                             select co).FirstOrDefault();


                    if (c != null)
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            catch
            {
                return false;
            }
        }

        //Insere os dados relativos ao pagamento de um plano de estacionamento (mensal, trimestral, semestral, etc)
        public bool inserirPagamentoEstacionamento(int idGerenciarSituacaoPagamento, DateTime dataHoraEntrada, DateTime dataHoraSaida, float valor)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    controle_estacionar contEst = new controle_estacionar();

                    contEst.idGerenciarSituacaoPagamento = idGerenciarSituacaoPagamento;
                    contEst.dataHoraEntrada = dataHoraEntrada;
                    contEst.dataHoraSaida = dataHoraSaida;
                    contEst.valor = valor;

                    estrela.controle_estacionar.AddObject(contEst);
                    estrela.SaveChanges();

                    return true;

                }
            }
            catch
            {
                return false;
            }
        }

        //Retorna a entrada de um estacionamento para que os dados sejam exibidos e a rotina finalizada
        public List<string> retornarEntradaEstacionamento(int idGerenciarSituacaoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    List<controle_estacionar> listContEst = new List<controle_estacionar>();

                    var c = (from co in estrela.controle_estacionar
                             where co.idGerenciarSituacaoPagamento == idGerenciarSituacaoPagamento
                             select co).LastOrDefault();


                    if (c != null)
                    {
                        //return c.ToList();
                        return null;
                    }
                    else
                        return null;
                }
            }
            catch
            {
                return null;
            }
        }

        //Retorna a hora da entrada de um veículo no estacionamento
        public DateTime retornarDataHoraEntradaEstacionamento(int idGerenciarSituacaoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    DateTime dataEntrada = Convert.ToDateTime(null);

                    IQueryable<controle_estacionar> c = from co in estrela.controle_estacionar
                                                        where co.idGerenciarSituacaoPagamento == idGerenciarSituacaoPagamento
                                                        select co;

                    foreach (controle_estacionar ce in c)
                    {
                        dataEntrada = Convert.ToDateTime(ce.dataHoraEntrada);
                    }
                    return dataEntrada;
                }
            }
            catch
            {
                return Convert.ToDateTime(null);
            }
        }

        //Retorna o id da vaga da entrada de um veículo no estacionamento
        public int retornarIdVagaEntradaEstacionamento(int idGerenciarSituacaoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    int vaga = -1;

                    IQueryable<controle_estacionar> c = from co in estrela.controle_estacionar
                                                        where co.idGerenciarSituacaoPagamento == idGerenciarSituacaoPagamento
                                                        select co;

                    foreach (controle_estacionar ce in c)
                    {
                        vaga = Convert.ToInt32(ce.idVaga);
                    }
                    return vaga;
                }
            }
            catch
            {
                return -1;
            }
        }

        //Complementa os dados relativos a rotina de estacionar.
        public bool inserirSaidaEstacionamento(int idGerenciarSituacaoPagamento, DateTime dataHoraEntrada, DateTime dataHoraSaida, float valor)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from co in estrela.controle_estacionar
                             where (co.idGerenciarSituacaoPagamento == idGerenciarSituacaoPagamento) && (co.dataHoraEntrada == dataHoraEntrada)
                             select co).FirstOrDefault();

                    c.dataHoraSaida = dataHoraSaida;
                    c.valor = valor;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Exclui as informações de um controle de pagamento
        public bool apagarControleEstacionarPorIdSituacaoPagamento(int sitPag)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from ce in estrela.controle_estacionar
                             where ce.idGerenciarSituacaoPagamento == sitPag
                             select ce);

                    estrela.DeleteObject(c);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
