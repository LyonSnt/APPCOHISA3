using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{
    class Token
    {
        public int numeroToken;
        public String sinonimo;
        public String nombreToken;
        public String lexema;
        public int linea;
        public int columna;

        public Token(int numeroToken, String sinonimo, String nombreToken, String lexema, int linea, int columna)
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
        public String getSinonimo()
        {
            return this.sinonimo;
        }
        public String getNombreToken()
        {
            return this.nombreToken;
        }
        public String getLexema()
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
