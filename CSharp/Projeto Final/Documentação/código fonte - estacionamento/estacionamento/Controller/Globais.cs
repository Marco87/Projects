using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estacionamento.View;

namespace Estacionamento.Controller
{
    public class Globais
    {
        public static string _usuario;
        public static string _senha;
        public static string _tipoConexao;
        public const string tipoAdministrador = "ADM";
        public const string tipoFuncionario = "OPE";
        public const string tipoCliente = "C";
        public static string sql;
        public static string idclientehist;
        public static string nomecliente;
  
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public string tipoConexao
        {
            get
            {
                return _tipoConexao;
            }
            set
            {
                _tipoConexao = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

    }
}
