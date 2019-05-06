using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComissoes.Controllers
{
    class ClientePF
    {
        private static Pessoa pessoa;
        private static string nome;
        private static string cpf;

        public static Pessoa Pessoa
        {
            get { return ClientePF.pessoa; }
            set { ClientePF.pessoa = value; }
        }
        
        public static string Nome
        {
            get { return ClientePF.nome; }
            set { ClientePF.nome = value; }
        }

        public static string Cpf
        {
            get { return ClientePF.cpf; }
            set { ClientePF.cpf = value; }
        }


    }
}
