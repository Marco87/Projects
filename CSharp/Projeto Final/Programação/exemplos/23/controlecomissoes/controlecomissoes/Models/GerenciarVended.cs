using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ControleComissoes.Models
{
    class GerenciarVended
    {
        Validacoes val = new Validacoes();

        public bool inserirVendedor(string nome, string cpf, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    vendedor ve = new vendedor();
                    pessoa pessoa = new pessoa();

                    ve.nome = nome;
                    ve.cpf = val.MascaraCnpjCpf(cpf);
                    pessoa.endereco = endereco;
                    pessoa.telefone = telefone;
                    pessoa.tipo = 4;
                    pessoa.login = login;
                    pessoa.senha = senha;

                    controle.vendedor.AddObject(ve);
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


        public bool alterarVendedor(string codigo, string nome, string cpf, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<vendedor> vend = from ve in controle.vendedor
                                                where ve.codigo_vendedor == cod
                                                select ve;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (vendedor ve in vend)
                    {
                        ve.nome = nome;
                        ve.cpf = val.MascaraCnpjCpf(cpf);
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
                                           where pe.tipo == 4 && pe.codigo_pessoa == cod
                                           select pe;

                    return p.ToList();
                }
            }
            catch
            {
                return null;
            }
        }


        public List<vendedor> exibirVendedor(string codigo)
        {
            try
            {

                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    List<vendedor> vend = new List<vendedor>();

                    int cod = Convert.ToInt32(codigo);

                    IQueryable<vendedor> v = from ve in controle.vendedor
                                             where ve.codigo_vendedor == cod
                                             select ve;

                    return v.ToList();
                }
            }
            catch
            {
                return null;
            }

        }



        public bool apagarVendedor(string codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<vendedor> v = from ve in controle.vendedor
                                             where ve.codigo_vendedor == cod
                                             select ve;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (pessoa pe in p)
                    {
                        controle.DeleteObject(pe);
                    }


                    foreach (vendedor vend in v)
                    {
                        controle.DeleteObject(vend);
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



        public List<string> preencherComboConsultaVendedor()
        {
            using (controle_comissoesEntities controle = new controle_comissoesEntities())
            {
                IQueryable<vendedor> v = from ve in controle.vendedor
                                         select ve;

                List<string> listaVend = new List<string>();

                foreach (vendedor vend in v)
                {
                    string vendedor = vend.codigo_vendedor.ToString() + " - " + vend.nome;
                    listaVend.Add(vendedor);
                }
                return listaVend;
            }
        }


        public string nomeVend(int codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    string nome = null;

                    IQueryable<vendedor> v = from ve in controle.vendedor
                                             where ve.codigo_vendedor == codigo
                                             select ve;

                    foreach (vendedor ve in v)
                    {
                        nome = ve.nome;
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
