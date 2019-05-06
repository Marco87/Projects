using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComissoes.Controllers
{
    class ClientePJ
    {
        private static Pessoa pessoa;
        private static string razaoSocial;
        private static string cnpj;

        public static Pessoa Pessoa
        {
            get { return ClientePJ.pessoa; }
            set { ClientePJ.pessoa = value; }
        }

        public static string RazaoSocial
        {
            get { return ClientePJ.razaoSocial; }
            set { ClientePJ.razaoSocial = value; }
        }

        public static string Cnpj
        {
            get { return ClientePJ.cnpj; }
            set { ClientePJ.cnpj = value; }
        }
    }
}
