using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Control
{
    class Gerencia
    {
        public static int _idControleEstacionamento;
        public int idControleEstacionamento
        {
            get { return _idControleEstacionamento; }
            set { _idControleEstacionamento = value; }
        }

        public static DateTime _dataHoraEntrada;
        public DateTime dataHoraEntrada
        {
            get { return _dataHoraEntrada; }
            set { _dataHoraEntrada = value; }
        }

        public static DateTime _dataHoraSaida;
        public DateTime dataHoraSaida
        {
            get { return _dataHoraSaida; }
            set { _dataHoraSaida = value; }
        }

        public static float _valor;
        public float valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

    }
}
