using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Control
{
    class Cliente
    {
        public static int _idCliente;
        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        
        public static string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public static string _telefone;
        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        
        public static string _celular;
        public string celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public static string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public static string _endereco;
        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public static string _situacao;
        public string situacao
        {
            get { return _situacao; }
            set { _situacao = value; }
        }

        public static DateTime _primeiroVencimento;
        public DateTime primeiroVencimento
        {
            get { return _primeiroVencimento; }
            set { _primeiroVencimento = value; }
        }

        public static string _tipoUsuario;
        public string tipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }

    }
}
