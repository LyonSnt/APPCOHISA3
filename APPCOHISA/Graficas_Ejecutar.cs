using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{
 
    public class Graficas_Ejecutar
    {
        private String nombreToke;
        private long numeroToken;
        private Object lin_senten;
        private String cadena_oper;

        public Graficas_Ejecutar(long numeroToken, String nombreToke, Object lin_senten, String cadena_oper )
        {

            this.nombreToke = nombreToke;
            this.numeroToken = numeroToken;
            this.lin_senten = lin_senten;
            this.cadena_oper = cadena_oper;

        }

        public String getCadena_oper()
        {
            return this.cadena_oper;
        }

        public String getToken_n()
        {
            return this.nombreToke;
        }
        public long getIdToken()
        {
            return this.numeroToken;
        }
        public Object getlin_senten()
        {
            return this.lin_senten;
        }
    }
}
