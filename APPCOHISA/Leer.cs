using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    class Leer
    {


        public string cargar_archivo(string archivo)
        {
            string cad = "";
            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    cad = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error. El archivo no se pudo cargar");
            }
            return cad;
        }

        //Leer el archivo y llama al metodo agregarFilaDatagridview para que por cada linea del bloc agregue una linea en el datagridview'
        public void lecturaArchivo(DataGridView tabla, char caracter, string ruta)
        {
            StreamReader objReader = new StreamReader(ruta);
            string sLine = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                sLine = objReader.ReadLine();
                if ((sLine != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = sLine.Split(caracter).Length;
                        nombrarTitulo(tabla, sLine.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFilaDatagridview(tabla, sLine, caracter);
                        fila += 1;
                    }

                }
            }

            while (!(sLine == null));
           // objReader.Close();
        }

        //Agregar el HeaderText al datagridview(SON LOS TITULOS)'
        public static void nombrarTitulo(DataGridView tabla, string[] titulos)
        {
            int x = 0;
            for (x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }

        //Agrega una fila por cada linea de Bloc de notas :D'
        public static void agregarFilaDatagridview(DataGridView tabla, string linea, char caracter)
        {
            string[] arreglo = linea.Split(caracter);
            tabla.Rows.Add(arreglo);
        }

    }
}

