using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using ControleComissoes.Controllers;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ControleComissoes.Models
{
    class GerenciarAdministrador
    {
        Validacoes val = new Validacoes();

        public bool inserirAdm(string nome, string cpf, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    administrador adm = new administrador();
                    pessoa pessoa = new pessoa();


                    adm.nome = nome;
                    adm.cpf = val.MascaraCnpjCpf(cpf);
                    pessoa.endereco = endereco;
                    pessoa.telefone = telefone;
                    pessoa.tipo = 1;
                    pessoa.login = login;
                    pessoa.senha = senha;

                    controle.administrador.AddObject(adm);
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


        public bool alterarAdm(string codigo, string nome, string cpf, string endereco, string telefone, string login, string senha)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<administrador> a = from ad in controle.administrador
                                                  where ad.codigo_adm == cod
                                                  select ad;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (administrador ad in a)
                    {
                        ad.nome = nome;
                        ad.cpf = val.MascaraCnpjCpf(cpf);
                        //controle.administrador.ApplyCurrentValues(ad);
                        controle.SaveChanges();
                    }

                    foreach (pessoa pe in p)
                    {
                        pe.endereco = endereco;
                        pe.telefone = telefone;
                        pe.login = login;
                        pe.senha = senha;
                        //controle.pessoa.ApplyCurrentValues(pe);
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
                                           where pe.tipo == 1 && pe.codigo_pessoa == cod
                                           select pe;

                    return p.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<administrador> exibirAdministrador(string codigo)
        {
            try
            {

                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    List<administrador> listaAdm = new List<administrador>();

                    int cod = Convert.ToInt32(codigo);

                    IQueryable<administrador> a = from ad in controle.administrador
                                                  where ad.codigo_adm == cod
                                                  select ad;

                    return a.ToList();
                }
            }
            catch
            {
                return null;
            }

        }

        public bool apagarAdm(string codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    int cod = Convert.ToInt32(codigo);

                    IQueryable<administrador> a = from ad in controle.administrador
                                                  where ad.codigo_adm == cod
                                                  select ad;

                    IQueryable<pessoa> p = from pe in controle.pessoa
                                           where pe.codigo_pessoa == cod
                                           select pe;

                    foreach (pessoa pe in p)
                    {
                        controle.DeleteObject(pe);
                    }


                    foreach (administrador ad in a)
                    {
                        controle.DeleteObject(ad);
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


        public List<string> preencherComboConsultaAdm()
        {
            using (controle_comissoesEntities controle = new controle_comissoesEntities())
            {
                IQueryable<administrador> a = from ad in controle.administrador
                                              select ad;

                List<string> listaAdm = new List<string>();

                foreach (administrador ad in a)
                {
                    string admin = ad.codigo_adm.ToString() + " - " + ad.nome;
                    listaAdm.Add(admin);
                }
                return listaAdm;
            }
        }

        public string nomeAdm(int codigo)
        {
            try
            {
                using (controle_comissoesEntities controle = new controle_comissoesEntities())
                {
                    string nome = null;

                    IQueryable<administrador> a = from ad in controle.administrador
                                                  where ad.codigo_adm == codigo
                                                  select ad;

                    foreach (administrador ad in a)
                    {
                        nome = ad.nome;
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
