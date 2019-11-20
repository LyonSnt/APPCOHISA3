using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOHISA
{
    class Rutas
    {

        private readonly string path;
        private readonly string Nombre;

        public Rutas(string path, string Nombre)
        {

            this.path = path;
            this.Nombre = Nombre;
        }
        public string getPath()
        {
            return path;
        }
        public string getNombre()
        {
            return Nombre;
        }
      
    }
}
