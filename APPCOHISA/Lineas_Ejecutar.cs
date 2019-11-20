using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{
 
    public class Lineas_Ejecutar
    {
        String Token_nombre;
        long numeroToken;
        Object lin_senten;
        String cadena_oper;

        public Lineas_Ejecutar(long numeroToken, String Token_nombre, Object lin_senten, String cadena_oper )
        {

            this.Token_nombre = Token_nombre;
            this.numeroToken = numeroToken;
            this.lin_senten = lin_senten;
            this.cadena_oper = cadena_oper;

        }

        public String getCadena_oper()
        {
            return this.cadena_oper;
        }

        public String getToken_nombre()
        {
            return this.Token_nombre;
        }
        public long getNumeroToken()
        {
            return this.numeroToken;
        }
        public Object getlin_senten()
        {
            return this.lin_senten;
        }

  
    }


}
