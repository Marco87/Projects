using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


namespace ControleComissoes.Models
{
    class GerenciarCliPJ
    {
        Validacoes val = new Validacoes();

        public bool inserirPJ(string razao, string cnpj, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    cliente_pj pj = new cliente_pj();
                    pessoa pessoa = new pessoa();

                    pj.razao_social = razao;
                    pj.cnpj = val.MascaraCnpjCpf(cnpj);
                    pessoa.endereco = endereco;
                    pessoa.telefone = telefone;
                    pessoa.tipo = 3;
                    pessoa.login = login;
                    pessoa.senha = senha;

                    controle.cliente_pj.AddObject(pj);
                    controle.pessoa.AddObject(pessoa);

                    controle.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool alterarPJ(string codigo, string razao, string cnpj, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<cliente_pj> clpj = from pj in controle.cliente_pj
                                                  where pj.codigo_pj == cod
                                                  select pj;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (cliente_pj pj in clpj)
                    {
                        pj.razao_social = razao;
                        pj.cnpj = val.MascaraCnpjCpf(cnpj);
                        controle.AcceptAllChanges();
                        controle.SaveChanges();
                    }

                    foreach (pessoa pe in p)
                    {
                        pe.endereco = endereco;
                        pe.telefone = telefone;
                        pe.login = login;
                        pe.senha = senha;
                        //controle.AcceptAllChanges();
                        controle.SaveChanges();
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public List<pessoa> exibirPessoa(string codigo)
        {
            try
            {

                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    List<pessoa> listaPessoa = new List<pessoa>();

                    int cod = Convert.ToInt32(codigo);

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.tipo == 3 && pe.codigo_pessoa == cod
                                           select pe;

                    return p.ToList();
                }
            }
            catch
            {
                return null;
            }
        }


        public List<cliente_pj> exibirClientePJ(string codigo)
        {
            try
            {

                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    List<cliente_pj> listaclpj = new List<cliente_pj>();

                    int cod = Convert.ToInt32(codigo);

                    IQueryable<cliente_pj> c = from pj in controle.cliente_pj
                                               where pj.codigo_pj == cod && pj.razao_social != "nulo"
                                               select pj;

                    return c.ToList();
                }
            }
            catch
            {
                return null;
            }

        }



        public bool apagarClientePJ(string codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<cliente_pj> c = from pj in controle.cliente_pj
                                               where pj.codigo_pj == cod
                                               select pj;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (pessoa pe in p)
                    {
                        controle.DeleteObject(pe);
                    }


                    foreach (cliente_pj pj in c)
                    {
                        controle.DeleteObject(pj);
                    }

                    controle.SaveChanges();
                }
                return true;
            }

            catch
            {
                return false;
            }
        }



        public List<string> preencherComboConsultaClientePJ()
        {
            using (controle_comissoesEntities controle = new controle_comissoesEntities())
            {
                IQueryable<cliente_pj> c = from pj in controle.cliente_pj
                                           where pj.razao_social != "nulo"
                                           select pj;

                List<string> listaPJ = new List<string>();

                foreach (cliente_pj pj in c)
                {
                    string clientePJ = pj.codigo_pj.ToString() + " - " + pj.razao_social;
                    listaPJ.Add(clientePJ);
                }
                return listaPJ;
            }
        }


        public string nomeCliPJ(int codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    string nome = null;

                    IQueryable<cliente_pj> p = from pj in controle.cliente_pj
                                               where pj.codigo_pj == codigo && pj.razao_social != "nulo"
                                               select pj;

                    foreach (cliente_pj pj in p)
                    {
                        nome = pj.razao_social;
                    }
                    return nome;
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
