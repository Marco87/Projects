using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Estacionamento.Control;
using Estacionamento.Controller;

namespace Estacionamento.Model
{
    class GerenciarOperador
    {
        public bool inserirOperador(string nome, string telefone, string celular, string email, string endereco, string login, string senha, string tipo)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    usuario ope = new usuario();

                    ope.nome = nome;
                    ope.telefone = telefone;
                    ope.celular = celular;
                    ope.email = email;
                    ope.endereco = endereco;
                    ope.tipoUsuario = "OPE";
                    ope.login = login;
                    ope.senha = senha;

                    estrela.usuario.AddObject(ope);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool consultarLoginOperador(string loginDig, string senhaDig)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    Usuario ope = new Usuario();

                    string opeExistente = null;

                    IQueryable<usuario> op = from o in estrela.usuario
                                             where o.login == loginDig && o.senha == senhaDig
                                             select o;

                    foreach (usuario o in op)
                    {
                        opeExistente = o.login;
                        Globais._tipoConexao = o.tipoUsuario;
                    }

                    if (opeExistente == null)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public List<usuario> exibirOperador(string login)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<usuario> o = from op in estrela.usuario
                                            where op.login == login && op.tipoUsuario == "OPE"
                                            select op;

                    return o.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        //Altera os dados de um operador.
        public bool alterarOperador(string nome, string telefone, string celular, string email, string endereco, string login, string senha)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var o = (from op in estrela.usuario
                             where op.login == login && op.tipoUsuario == "OPE"
                             select op).FirstOrDefault();

                    o.nome = nome;
                    o.telefone = telefone;
                    o.celular = celular;
                    o.email = email;
                    o.endereco = endereco;
                    o.senha = senha;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Remove o operador que tiver o login passado como referência.
        public bool apagarOperador(string login)
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                try
                {
                    var o = (from op in estrela.usuario
                             where op.login == login && op.tipoUsuario == "OPE"
                             select op).FirstOrDefault();

                    estrela.DeleteObject(o);
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
