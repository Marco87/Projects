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
    class GerenciarSituacaoPagamento
    {
        Cliente clie = new Cliente();
        Veiculo vei = new Veiculo();
        TipoEstacionamento tip = new TipoEstacionamento();


        public bool inserirSituacaoPagamento(int tipoEstacionamento, string situacapPagamento, DateTime vencimentoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    gerenciar_situacao_pagamento ger = new gerenciar_situacao_pagamento();

                    ger.idCliente = clie.idCliente;
                    ger.idVeiculo = vei.idVeiculo;
                    ger.idTipoPlanoEstacionamento = tipoEstacionamento;
                    ger.situacaoPagamento = situacapPagamento;
                    ger.vencimentoPagamento = vencimentoPagamento;

                    estrela.gerenciar_situacao_pagamento.AddObject(ger);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<gerenciar_situacao_pagamento> exibirSituacaoPagamento()
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<gerenciar_situacao_pagamento> g = from ge in estrela.gerenciar_situacao_pagamento
                                                                 where ge.idCliente == clie.idCliente && ge.idVeiculo == vei.idVeiculo
                                                                 select ge;

                    return g.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<gerenciar_situacao_pagamento> exibirSituacaoPagamento(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<gerenciar_situacao_pagamento> g = from ge in estrela.gerenciar_situacao_pagamento
                                                                 where ge.idCliente == idCliente && ge.idVeiculo == idVeiculo
                                                                 select ge;

                    return g.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        //Retorna o id da situação do pagamento pelo id do cliente e do veículo passados como parâmetro
        public int retornarIdSituacaoPorIdClienteIdVeiculo(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var g = (from ge in estrela.gerenciar_situacao_pagamento
                             where ge.idCliente == idCliente && ge.idVeiculo == idVeiculo
                             select ge).FirstOrDefault();


                    if (g != null)
                        return g.idGerenciarSituacaoPagamento;
                    else
                        return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        //Retorna o id do tipo de estacionamento pelo id do cliente e do veículo passados como parâmetro
        public int retornarIdTipoEstacionamentoPorIdClienteIdVeiculo(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var t = (from ti in estrela.gerenciar_situacao_pagamento
                             where ti.idCliente == idCliente && ti.idVeiculo == idVeiculo
                             select ti).FirstOrDefault();

                    if (t != null)
                        return t.idTipoPlanoEstacionamento;
                    else
                        return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        //Retorna a data de vencimento do pagamento pelo id do cliente e do veículo passados como parâmetro
        public DateTime retornarDataDeVencimentoPorIdClienteIdVeiculo(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var g = (from ge in estrela.gerenciar_situacao_pagamento
                             where ge.idCliente == idCliente && ge.idVeiculo == idVeiculo
                             select ge).FirstOrDefault();

                    if (g != null)
                        return Convert.ToDateTime(g.vencimentoPagamento);
                    else
                        return Convert.ToDateTime(null);
                }
            }
            catch
            {
                return Convert.ToDateTime(null);
            }
        }

        //Retorna os meses pagos pelo id do cliente e do veículo passados como parâmetro
        public int retornarMesesPagosPorIdClienteIdVeiculo(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var g = (from ge in estrela.gerenciar_situacao_pagamento
                             where ge.idCliente == idCliente && ge.idVeiculo == idVeiculo
                             select ge).FirstOrDefault();

                    if (g != null)
                        return Convert.ToInt32(g.mesesPagos);
                    else
                        return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        //Exclui as informações de pagamento da ligação de um cliente e seu veículo mediante seus ids
        public bool apagarSituacaoPagamento(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var g = (from ge in estrela.gerenciar_situacao_pagamento
                             where ge.idCliente == idCliente && ge.idVeiculo == idVeiculo
                             select ge);

                    estrela.DeleteObject(g);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Exclui as informações de pagamento da ligação de um cliente e seu veículo mediante seus ids
        public bool apagarSituacaoPagamento()
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var g = (from ge in estrela.gerenciar_situacao_pagamento
                             where ge.idCliente == clie.idCliente && ge.idVeiculo == vei.idVeiculo
                             select ge);

                    estrela.DeleteObject(g);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Exclui as informações de pagamento da ligação de um cliente e seu veículo mediante seus ids
        public bool apagarSituacaoPagamentoPorIdCliente(int idCliente)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<gerenciar_situacao_pagamento> g = (from ge in estrela.gerenciar_situacao_pagamento
                                                                  where ge.idCliente == idCliente
                                                                  select ge);

                    estrela.DeleteObject(g);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Altera os dados relativos ao gerenciamento do pagamento mediante os dados passados como parâmetro
        public bool alterarSituacaoPagamento(int idTipoPlano, string situacaoPagamento, DateTime vencimentoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var s = (from st in estrela.gerenciar_situacao_pagamento
                             where st.idCliente == clie.idCliente && st.idVeiculo == vei.idVeiculo
                             select st).FirstOrDefault();

                    s.idTipoPlanoEstacionamento = idTipoPlano;
                    s.idCliente = clie.idCliente;
                    s.idVeiculo = vei.idVeiculo;
                    s.situacaoPagamento = situacaoPagamento;
                    //s.vencimentoPagamento = vencimentoPagamento;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Altera os dados relativos ao gerenciamento do pagamento mediante os dados passados como parâmetro
        public bool alterarSituacaoPagamento(int idCliente, int idVeiculo, int idTipoPlano, string situacaoPagamento, DateTime vencimentoPagamento)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var s = (from st in estrela.gerenciar_situacao_pagamento
                             where st.idCliente == idCliente && st.idVeiculo == idVeiculo
                             select st).FirstOrDefault();

                    s.idTipoPlanoEstacionamento = idTipoPlano;
                    s.idCliente = idCliente;
                    s.idVeiculo = idVeiculo;
                    s.situacaoPagamento = situacaoPagamento;
                    s.vencimentoPagamento = vencimentoPagamento;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Atualiza os meses que já foram pagos pelo cliente.
        public bool atualizarMesesPagos(int idCliente, int idVeiculo, int mesesPagos)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var s = (from st in estrela.gerenciar_situacao_pagamento
                             where st.idCliente == idCliente && st.idVeiculo == idVeiculo
                             select st).FirstOrDefault();

                    int meses;
                    meses = Convert.ToInt32(s.mesesPagos);

                    s.mesesPagos = meses + mesesPagos;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Zera os meses que já foram pagos pelo cliente (usado quando uma data de vencimento for alterada).
        public bool zerarMesesPagos(int idCliente, int idVeiculo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var s = (from st in estrela.gerenciar_situacao_pagamento
                             where st.idCliente == idCliente && st.idVeiculo == idVeiculo
                             select st).FirstOrDefault();

                    s.mesesPagos = null;

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
