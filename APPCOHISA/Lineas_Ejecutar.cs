using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{

    public class Lineas_Ejecutar
    {
        readonly string Token_nombre;
        readonly long numeroToken;
        readonly object lin_senten;
        readonly string cadena_oper;

        public Lineas_Ejecutar(long numeroToken, string Token_nombre, object lin_senten, string cadena_oper)
        {

            this.Token_nombre = Token_nombre;
            this.numeroToken = numeroToken;
            this.lin_senten = lin_senten;
            this.cadena_oper = cadena_oper;

        }

        public string getCadena_oper()
        {
            return cadena_oper;
        }

        public string getToken_nombre()
        {
            return Token_nombre;
        }
        public long getNumeroToken()
        {
            return numeroToken;
        }
        public object getlin_senten()
        {
            return lin_senten;
        }


    }


}
