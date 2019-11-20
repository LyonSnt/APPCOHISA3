using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{
    class Error
    {
        public int numeroToken;
        public string sinonimo;
        public string nombreToken;
        public string lexema;
        public int linea;
        public int columna;

        public Error(int numeroToken, string sinonimo, string nombreToken, string lexema, int linea, int columna)
        {
            this.numeroToken = numeroToken;
            this.sinonimo = sinonimo;
            this.nombreToken = nombreToken;
            this.lexema = lexema;
            this.linea = linea;
            this.columna = columna;
        }
        public int getNumeroToken()
        {
            return this.numeroToken;
        }
        public string getSinonimo()
        {
            return this.sinonimo;
        }
        public string getNombreToken()
        {
            return this.nombreToken;
        }
        public string getLexema()
        {
            return this.lexema;
        }
        public int getLinea()
        {
            return this.linea;
        }
        public int getColumna()
        {
            return this.columna;
        }
    }
}
