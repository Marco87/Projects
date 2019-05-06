using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estacionamento.Model;


namespace Estacionamento.Control
{
    class Usuario
    {
        public static int _idUsuario;
        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
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

        public static string _tipoUsuario;
        public string tipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }

        public static string _login;
        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        public static string _senha;
        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        
    }
}
