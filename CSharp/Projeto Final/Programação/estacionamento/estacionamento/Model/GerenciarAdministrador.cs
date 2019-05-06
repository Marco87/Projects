using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Estacionamento.Control;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Estacionamento.Model
{
    class GerenciarAdministrador
    {
        public bool inserirAdministrador(string nome, string telefone, string celular, string email, string endereco, string login, string senha)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    usuario adm = new usuario();

                    adm.nome = nome;
                    adm.telefone = telefone;
                    adm.celular = celular;
                    adm.email = email;
                    adm.endereco = endereco;
                    adm.tipoUsuario = "ADM";
                    adm.login = login;
                    adm.senha = senha;

                    estrela.usuario.AddObject(adm);
                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Consulta o sistema e verifica se o login passado como referência já foi cadastrado.
        public bool consultarLoginAdministrador(string loginDig)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    Usuario adm = new Usuario();

                    string adminExistente = null;

                    IQueryable<usuario> ad = from a in estrela.usuario
                                             where a.login == loginDig && a.tipoUsuario == "ADM"
                                             select a;

                    foreach (usuario a in ad)
                    {
                        adminExistente = a.login;
                    }

                    if (adminExistente == null)
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

        //Exibe os dados do administrador que tiver o login passado como referência.
        public List<usuario> exibirAdministrador(string login)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<usuario> a = from ad in estrela.usuario
                                            where ad.login == login && ad.tipoUsuario == "ADM"
                                            select ad;

                    return a.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        //Altera os dados de um administrador.
        public bool alterarAdministrador(string nome, string telefone, string celular, string email, string endereco, string login, string senha)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var a = (from ad in estrela.usuario
                             where ad.login == login && ad.tipoUsuario == "ADM"
                             select ad).FirstOrDefault();

                    a.nome = nome;
                    a.telefone = telefone;
                    a.celular = celular;
                    a.email = email;
                    a.endereco = endereco;
                    a.senha = senha;

                    estrela.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Remove o administrador que tiver o login passado como referência.
        public bool apagarAdministrador(string login)
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                try
                {
                    var a = (from ad in estrela.usuario
                             where ad.login == login && ad.tipoUsuario == "ADM"
                             select ad).FirstOrDefault();

                    estrela.DeleteObject(a);
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
