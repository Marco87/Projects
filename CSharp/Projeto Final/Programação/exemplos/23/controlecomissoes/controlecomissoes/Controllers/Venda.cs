using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleComissoes.Controllers
{
    //Atalho para gerar get e set: ctrl + R e ctrl + E

    class Venda
    {
        private static int codigoVenda;
        private static DateTime dataVenda;
        private static Vendedor vendedor;
        private static ClientePF clientePF;
        private static ClientePJ clientePJ;
        private static float totalVenda;

        public static int CodigoVenda
        {
            get { return Venda.codigoVenda; }
            set { Venda.codigoVenda = value; }
        }
        
        public static DateTime DataVenda
        {
            get { return Venda.dataVenda; }
            set { Venda.dataVenda = value; }
        }
        
        public static Vendedor Vendedor
        {
            get { return Venda.vendedor; }
            set { Venda.vendedor = value; }
        }
        
        public static ClientePF ClientePF
        {
            get { return Venda.clientePF; }
            set { Venda.clientePF = value; }
        }

        public static ClientePJ ClientePJ
        {
            get { return Venda.clientePJ; }
            set { Venda.clientePJ = value; }
        }
        
        public static float TotalVenda
        {
            get { return Venda.totalVenda; }
            set { Venda.totalVenda = value; }
        }

        
    }
}
