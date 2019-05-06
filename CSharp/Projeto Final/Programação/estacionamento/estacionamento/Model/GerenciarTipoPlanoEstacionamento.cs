using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Estacionamento.Model
{
    class GerenciarTipoPlanoEstacionamento
    {
        //Método usado para inserir um novo tipo de estacionamento, onde os valores digitados pelo usuário são passados como parâmetro
        public bool inserirTipoEstacionamento(string descricao, string valor, string meses)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    float valorConv = float.Parse(valor);

                    tipo_plano_estacionamento tipo = new tipo_plano_estacionamento();

                    tipo.descricao = descricao;
                    tipo.valor = valorConv;
                    tipo.mesesPlano = Convert.ToInt32(meses);

                    estrela.tipo_plano_estacionamento.AddObject(tipo);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<string> preencherComboCunsultaTipoEstacionamento()
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                IQueryable<tipo_plano_estacionamento> listaPlano = from tipoest in estrela.tipo_plano_estacionamento
                                                             select tipoest;

                List<string> listaPlanoEst = new List<string>();

                foreach (tipo_plano_estacionamento tipoest in listaPlano)
                {
                    string planos = tipoest.idTipoEstacionamento + " - " + tipoest.descricao;
                    listaPlanoEst.Add(planos);
                }

                return listaPlanoEst;
            }
        }

        //Verifica se o tipo de estacionamento (descrição) fornecido como parâmetro já foi cadastrado no sistema
        public bool consultarTipoEstacionamento(string tipoDig)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    string tipoExistente = null;

                    IQueryable<tipo_plano_estacionamento> te = from t in estrela.tipo_plano_estacionamento
                                                         where t.descricao == tipoDig
                                                         select t;

                    foreach (tipo_plano_estacionamento t in te)
                    {
                        tipoExistente = t.descricao;
                    }

                    if (tipoExistente == null)
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

        //Retorna a descrição do estacionamento mediante um id passado como parâmetro
        public string retornarDescricaoTipoEstacionamentoPorId(int id)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var t = (from te in estrela.tipo_plano_estacionamento
                             where te.idTipoEstacionamento == id
                             select te).FirstOrDefault();

                    return t.descricao;
                }
            }
            catch
            {
                return null;
            }
        }

        //Retorna o valor do tipo de estacionamento mediante um id passado como parâmetro
        public float retornarValorTipoEstacionamentoPorId(int id)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var t = (from te in estrela.tipo_plano_estacionamento
                             where te.idTipoEstacionamento == id
                             select te).FirstOrDefault();

                    return Convert.ToInt64(t.valor);
                }
            }
            catch
            {
                return 0;
            }
        }

        //Retorna a quantidade de meses a serem pagos de um tipo de plano de estacionamento mediante um id passado como parâmetro
        public int retornarQuantidadeMesesTipoEstacionamentoPorId(int id)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var t = (from te in estrela.tipo_plano_estacionamento
                             where te.idTipoEstacionamento == id
                             select te).FirstOrDefault();

                    return Convert.ToInt32(t.mesesPlano);
                }
            }
            catch
            {
                return 0;
            }
        }

    }
}
