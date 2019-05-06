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
    class GerenciarCliente
    {

        GerenciarVeiculo gerVeiculo = new GerenciarVeiculo();
        Cliente clie = new Cliente();

        public bool inserirCliente(string nome, string telefone, string celular, string email, string endereco, string login, string tipocliente)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    cliente cli = new cliente();

                    cli.nome = nome;
                    cli.telefone = telefone;
                    cli.Celular = celular;
                    cli.email = email;
                    cli.endereco = endereco;
                    cli.login = login;
                    cli.tipoCliente = tipocliente;
                    
                    estrela.cliente.AddObject(cli);
                    estrela.SaveChanges();

                    clie.idCliente = cli.idCliente;

                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        //Verifica se o login passado como referência já foi cadastrado no sistema.
        public bool consultarLoginCliente(string loginDig)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    Cliente cli = new Cliente();

                    string cliExistente = null;

                    IQueryable<cliente> cl = from c in estrela.cliente
                                             where c.login == loginDig
                                             select c;

                    foreach (cliente c in cl)
                    {
                        cliExistente = c.login;
                    }

                    if (cliExistente == null)
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

        //Exibe os dados do cliente que tiver o login passado como referência.
        public List<cliente> exibirClientePorLogin(string login)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<cliente> c = from cl in estrela.cliente
                                            where cl.login == login
                                            select cl;

                    return c.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        //Exibe os dados do cliente que tiver o login passado como referência.
        public List<cliente> exibirClientePorId(int id)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    IQueryable<cliente> c = from cl in estrela.cliente
                                            where cl.idCliente == id
                                            select cl;

                    return c.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        //Retorna o id do cliente mediante um login passado como referência.
        public int retornarIdClientePorLogin(string login)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from cl in estrela.cliente
                             where cl.login == login
                             select cl).FirstOrDefault();

                    clie.idCliente = c.idCliente;

                    return c.idCliente;
                }
            }
            catch
            {
                return -1;
            }
        }

        //Retorna o nome do cliente mediante um id passado como referência.
        public string retornarNomeClientePorId(int id)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from cl in estrela.cliente
                             where cl.idCliente == id
                             select cl).FirstOrDefault();

                    return c.nome;
                }
            }
            catch
            {
                return null;
            }
        }

        //Remove o cliente que tiver o id passado como referência.
        public bool apagarCliente(int id)
        {
            using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
            {
                try
                {
                    var c = (from cl in estrela.cliente
                             where cl.idCliente == id
                             select cl).FirstOrDefault();

                    estrela.DeleteObject(c);
                    estrela.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool alterarCliente(int idCliente, string nome, string telefone, string celular, string email, string endereco)
        {
            try
            {
                using (estrelaoriental3Entities1 estrela = new estrelaoriental3Entities1())
                {
                    var c = (from cl in estrela.cliente
                             where cl.idCliente == idCliente
                             select cl).FirstOrDefault();

                    c.nome = nome;
                    c.telefone = telefone;
                    c.Celular = celular;
                    c.email = email;
                    c.endereco = endereco;
                    
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
