using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ControleComissoes.Models
{
    class GerenciarVend
    {
        public bool inserirVendaPF(string codVend, string codClientePF, float total)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    venda ven = new venda();

                    int codV = Convert.ToInt32(codVend);
                    int codPF = Convert.ToInt32(codClientePF);

                    DateTime dataAtual = DateTime.Now;

                    ven.data = dataAtual;
                    ven.cod_vendedor = codV;
                    ven.cod_pf = codPF;
                    ven.cod_pj = 19;
                    ven.total = total;

                    controle.venda.AddObject(ven);
                    controle.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool inserirVendaPJ(string codVend, string codClientePJ, float total)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    venda ven = new venda();

                    int codV = Convert.ToInt32(codVend);
                    int codPJ = Convert.ToInt32(codClientePJ);

                    DateTime dataAtual = DateTime.Now;

                    ven.data = dataAtual;
                    ven.cod_vendedor = codV;
                    ven.cod_pf = 18;
                    ven.cod_pj = codPJ;
                    ven.total = total;

                    controle.venda.AddObject(ven);
                    controle.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool inserirItemVenda(int codVenda, string codPlano, int qtd, float valorItem)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    item_venda item = new item_venda();

                    int codigoPlano = Convert.ToInt32(codPlano);

                    item.codigo_venda = codVenda;
                    item.codigo_plano = codigoPlano;
                    item.quantidade = qtd;
                    item.valor = valorItem;

                    controle.item_venda.AddObject(item);
                    controle.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int retornaUltimoCodigoVenda()
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    venda venda = new venda();

                    IQueryable<venda> v = from ve in controle.venda
                                          select ve;

                    int codigo = -1;

                    foreach (venda ve in v)
                    {
                        codigo = ve.codigo_venda;
                    }

                    return codigo;
                }
            }
            catch
            {
                return -1;
            }

        }

        public float retornarValorComissao(string codigoPlano, int tipoCliente, string qtd)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    plano_comissao planoComis = new plano_comissao();

                    int codPlano = Convert.ToInt32(codigoPlano);

                    int quantidade = Convert.ToInt32(qtd);

                    IQueryable<plano_comissao> p = from pl in controle.plano_comissao
                                                   where pl.cod_plano == codPlano && pl.tipo_cliente == tipoCliente
                                                   select pl;

                    float valorComissao = -1;

                    foreach (plano_comissao pl in p)
                    {
                        if((quantidade >= pl.faixa_inicial) && (quantidade <= pl.faixa_final))
                        valorComissao = Convert.ToInt64(pl.comissao);
                    }

                    return valorComissao * quantidade;
                }
            }
            catch
            {
                return -1;
            }
        }

        public bool inserirComissaoVendedor(int codVenda, string codVendedor, float valorComissao)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    vendedor_comissao ven_comis = new vendedor_comissao();

                    int codVend = Convert.ToInt32(codVendedor);

                    ven_comis.codigo_venda = codVenda;
                    ven_comis.codigo_vendedor = codVend;
                    ven_comis.valor_comissao = valorComissao;

                    controle.vendedor_comissao.AddObject(ven_comis);
                    controle.SaveChanges();

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
