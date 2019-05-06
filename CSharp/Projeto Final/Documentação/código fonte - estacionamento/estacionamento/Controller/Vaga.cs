using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Control
{
    class Vaga
    {
        public static int _quantidade_vaga;
        public int quantidade_vaga
        {
            get { return _quantidade_vaga; }
            set { _quantidade_vaga = value; }
        }

        public static int _andar;
        public int andar
        {
            get { return _andar; }
            set { _andar = value; }
        }

        public static int _identificador_vaga;
        public int identificador_vaga
        {
            get { return _identificador_vaga; }
            set { _identificador_vaga = value; }
        }

        public static string _estado_vaga;
        public string estado_vaga
        {
            get { return _estado_vaga; }
            set { _estado_vaga = value; }
        }

        public static int _consultar_quantidade_vaga;
        public int consultar_quantidade_vaga
        {
            get { return _consultar_quantidade_vaga; }
            set { _consultar_quantidade_vaga = value; }
        }

    }
}
