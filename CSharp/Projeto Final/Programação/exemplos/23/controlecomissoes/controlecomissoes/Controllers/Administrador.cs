using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleComissoes.Models;

namespace ControleComissoes.Controllers
{
    class Administrador
    {
        private static Pessoa pessoa;
        private static string nome;
        private static string cpf;

        public static Pessoa Pessoa
        {
            get { return Administrador.pessoa; }
            set { Administrador.pessoa = value; }
        }
        
        public static string Nome
        {
            get { return Administrador.nome; }
            set { Administrador.nome = value; }
        }

        public static string Cpf
        {
            get { return Administrador.cpf; }
            set { Administrador.cpf = value; }
        }

    }
}
