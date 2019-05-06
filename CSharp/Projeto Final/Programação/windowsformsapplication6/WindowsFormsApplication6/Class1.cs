using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class Class1
    {
        static int vagas, andar;
        static string identificador_das_vagas;
        
        public static int quantidade_vaga
        {
            get
            {
                return vagas;
            }
            set
            {
                vagas = value;
            }
        }

        public static int andares
        {
            get
            {
                return andar;
            }
            set
            {
                andar = value;
            }
        }

        public static string identificador_vagas
        {
            get
            {
                return identificador_das_vagas;
            }
            set
            {
                identificador_das_vagas = value;
            }
        }

        /*public string FName
        {
            get
            {
                return lbl_firstname.Text;
            }

        
            set
            {
                lbl_firstname.Text = value;
            } 
        
        }*/
    }
}
