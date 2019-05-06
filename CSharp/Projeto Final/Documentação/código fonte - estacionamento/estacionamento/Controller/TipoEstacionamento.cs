using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Control
{
    class TipoEstacionamento
    {
        public static int _idTipoEstacionamento;
        public int idTipoEstacionamento
        {
            get { return _idTipoEstacionamento; }
            set { _idTipoEstacionamento = value; }
        }

        public static string _descricao;
        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public static float _valor;
        public float valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

    }
}
