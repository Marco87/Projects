using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComissoes.Controllers
{
    class Pessoa
    {
        private static int codigoPessoa;
        private static string endereco;
        private static string telefone;
        private static int tipoPessoa;
        private static string login;
        private static string senha;

        public static int CodigoPessoa
        {
            get { return Pessoa.codigoPessoa; }
            set { Pessoa.codigoPessoa = value; }
        }

        public static string Endereco
        {
            get { return Pessoa.endereco; }
            set { Pessoa.endereco = value; }
        }
        
        public static string Telefone
        {
            get { return Pessoa.telefone; }
            set { Pessoa.telefone = value; }
        }
        
        public static int TipoPessoa
        {
            get { return Pessoa.tipoPessoa; }
            set { Pessoa.tipoPessoa = value; }
        }

        
        public static string Login
        {
            get { return Pessoa.login; }
            set { Pessoa.login = value; }
        }

        public static string Senha
        {
            get { return Pessoa.senha; }
            set { Pessoa.senha = value; }
        }

    }
}
