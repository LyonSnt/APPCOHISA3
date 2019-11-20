using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{
    class AFD
    {

        public int[,] elementos;
        public string columnas;
        public string[] datos;

        public AFD()
        {
            this.elementos = null;
            //this.columnas = "abcdefghijklmnopqrstuvwxyz0123456789]+*-|();.'#/^!<>=:,@";
            this.columnas = null;
            this.datos = null;

        }

        private int getpos_columna(char simbolo)
        {
            //if (simbolo == '"')
            //simbolo = ']';
            if (simbolo == ' ')
                simbolo = '@';
            if (simbolo == ';')
                simbolo = '?';
            if (simbolo == '\n')
                simbolo = '@';
            if (simbolo == '\r')
                simbolo = '@';
            if (simbolo == '\t')
                simbolo = '@';
            if (simbolo == '\t')
                simbolo = ';';
            int numsimbolos = this.columnas.Length;
            for (int i = 0; i < numsimbolos; i++)
            {
                if (this.columnas[i] == simbolo)
                    return i;
            }
            return -1;
        }
        public int getEstado(int fila, char simbolo)

        {
            //Console.WriteLine("es simbolo : "+simbolo);

            return this.elementos[fila, getpos_columna(simbolo)];
        }
    }
}
