using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComissoes.Controllers
{
    class Vendedor
    {
        private static Pessoa pessoa;
        private static string nome;
        private static string cpf;

        public static Pessoa Pessoa
        {
            get { return Vendedor.pessoa; }
            set { Vendedor.pessoa = value; }
        }

        public static string Nome
        {
            get { return Vendedor.nome; }
            set { Vendedor.nome = value; }
        }

        public static string Cpf
        {
            get { return Vendedor.cpf; }
            set { Vendedor.cpf = value; }
        }

    }
}
