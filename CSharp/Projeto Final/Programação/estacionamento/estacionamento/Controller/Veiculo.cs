using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Control
{
    class Veiculo
    {
        public static int _idVeiculo;
        public int idVeiculo
        {
            get { return _idVeiculo; }
            set { _idVeiculo = value; }
        }

        public static string _placa;
        public string placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public static string _marca;
        public string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public static string _modelo;
        public string modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public static string _ano;
        public string ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

    }
}
