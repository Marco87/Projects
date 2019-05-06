using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleComissoes.Controllers;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ControleComissoes.Models
{
    class GerenciarPlan
    {
        public bool inserirPlano(string descricao, int tipo, float valor)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    plano pl = new plano();

                    pl.descricao = descricao;
                    pl.tipo = tipo;
                    pl.valor = valor;

                    controle.plano.AddObject(pl);
                    controle.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void alterarPlano()
        {
            try
            {
            }
            catch { }
        }

        public List<plano> exibirPlano(string codigo)
        {
            try
            {

                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    List<plano> listaPlano = new List<plano>();

                    int cod = Convert.ToInt32(codigo);

                    IQueryable<plano> p = from pl in controle.plano
                                           where pl.codigo_plano == cod
                                           select pl;

                    return p.ToList();
                }
            }
            catch
            {
                return null;
            }
        

        }

        public void apagarPlano()
        {
            try
            {
            }
            catch { }
        }


        public bool inserirPlanoComissao(string codigo, int tipoCliente, float comissao, int faixaInicial, int faixaFinal)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    plano_comissao pl = new plano_comissao();

                    int cod = Convert.ToInt32(codigo);
                    DateTime dataAtual = DateTime.Now;

                    pl.cod_plano = cod;
                    pl.tipo_cliente = tipoCliente;
                    pl.comissao = comissao;
                    pl.data = dataAtual;
                    pl.faixa_inicial = faixaInicial;
                    pl.faixa_final = faixaFinal;

                    controle.plano_comissao.AddObject(pl);
                    controle.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void alterarPlanoComissao()
        {
            try
            {
            }
            catch { }
        }

        public void exibirPlanoComissao()
        {
            try
            {
            }
            catch { }
        }

        public void apagarPlanoComissao()
        {
            try
            {
            }
            catch { }
        }

        public List<string> preencherComboConsultaPlano()
        {
            using (controle_comissoesEntities controle = new controle_comissoesEntities())
            {
                IQueryable<plano> p = from pl in controle.plano
                                              select pl;

                List<string> listaPlano = new List<string>();

                foreach (plano pl in p)
                {
                    string plano = pl.codigo_plano.ToString() + " - " + pl.descricao;
                    listaPlano.Add(plano);
                }
                return listaPlano;
            }
        }



    }
}
