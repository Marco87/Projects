using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComissoes.Controllers
{
    class Plano
    {
        private static int codigoPlano;
        private static string descricao;
        private static int tipoPlano;
        private static float valor;

        public static int CodigoPlano
        {
            get { return Plano.codigoPlano; }
            set { Plano.codigoPlano = value; }
        }
        
        public static string Descricao
        {
            get { return Plano.descricao; }
            set { Plano.descricao = value; }
        }

        public static int TipoPlano
        {
            get { return Plano.tipoPlano; }
            set { Plano.tipoPlano = value; }
        }

        public static float Valor
        {
            get { return Plano.valor; }
            set { Plano.valor = value; }
        }
    }
}
