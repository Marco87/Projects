using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ControleComissoes.Models
{
    class GerenciarCliPF
    {
        Validacoes val = new Validacoes();

        public bool inserirPF(string nome, string cpf, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    cliente_pf pf = new cliente_pf();
                    pessoa pessoa = new pessoa();

                    pf.nome = nome;
                    pf.cpf = val.MascaraCnpjCpf(cpf);
                    pessoa.endereco = endereco;
                    pessoa.telefone = telefone;
                    pessoa.tipo = 2;
                    pessoa.login = login;
                    pessoa.senha = senha;

                    controle.cliente_pf.AddObject(pf);
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


        public bool alterarPF(string codigo, string nome, string cpf, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<cliente_pf> clpf = from pf in controle.cliente_pf
                                                  where pf.codigo_pf == cod
                                                  select pf;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (cliente_pf pf in clpf)
                    {
                        pf.nome = nome;
                        pf.cpf = val.MascaraCnpjCpf(cpf);
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
                                           where pe.tipo == 2 && pe.codigo_pessoa == cod
                                           select pe;

                    return p.ToList();
                }
            }
            catch
            {
                return null;
            }
        }


        public List<cliente_pf> exibirClientePF(string codigo)
        {
            try
            {

                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    List<cliente_pf> listaclpf = new List<cliente_pf>();

                    int cod = Convert.ToInt32(codigo);

                    IQueryable<cliente_pf> c = from pf in controle.cliente_pf
                                               where pf.codigo_pf == cod && pf.nome != "nulo"
                                               select pf;

                    return c.ToList();
                }
            }
            catch
            {
                return null;
            }

        }



        public bool apagarClientePF(string codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<cliente_pf> c = from pf in controle.cliente_pf
                                               where pf.codigo_pf == cod
                                               select pf;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (pessoa pe in p)
                    {
                        controle.DeleteObject(pe);
                    }


                    foreach (cliente_pf pf in c)
                    {
                        controle.DeleteObject(pf);
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



        public List<string> preencherComboConsultaClientePF()
        {
            using (controle_comissoesEntities controle = new controle_comissoesEntities())
            {
                IQueryable<cliente_pf> c = from pf in controle.cliente_pf
                                           where pf.nome != "nulo"
                                           select pf;

                List<string> listaPF = new List<string>();

                foreach (cliente_pf pf in c)
                {
                    string clientePF = pf.codigo_pf.ToString() + " - " + pf.nome;
                    listaPF.Add(clientePF);
                }
                return listaPF;
            }
        }

        public string nomeCliPF(int codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    string nome = null;

                    IQueryable<cliente_pf> c = from pf in controle.cliente_pf
                                               where pf.codigo_pf == codigo && pf.nome != "nulo"
                                               select pf;

                    foreach (cliente_pf pf in c)
                    {
                        nome = pf.nome;
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
