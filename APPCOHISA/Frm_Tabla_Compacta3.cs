using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Frm_Tabla_Compacta3 : Form
    {

        public object[,] matriz = new object[177, 65];

        public Frm_Tabla_Compacta3()
        {
            InitializeComponent();
        }

        public void RetornarMatriz(StreamReader o)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string fila = o.ReadLine();
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    object[] arreglo = fila.Split(';');
                    matriz[i, j] = arreglo[j];

                }
            }
        }

        public void cargarArchivo()
        {
            string ruta = @"C:\Users\Lyon\source\repos\APPCOHISA3\APPCOHISA\Archivos\Matriz.csv";
            StreamReader archivocsvd = new StreamReader(ruta);
            RetornarMatriz(archivocsvd);

        }

        public void cargarTablaCompacta()
        {
            int cont = 0;
            object a = 0;
            int po = 0;
            List<object> Fil = new List<object>();
            List<object> Fil0 = new List<object>();
            List<object> valor = new List<object>();

            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                for (int j = 1; j < matriz.GetLength(1); j++)
                {

                    if (!matriz[i, j].Equals(""))
                    {

                        po = +Convert.ToInt32(matriz[i, j]);
                        valor.Add(po);
                        // tablacompac.Rows.Add(i, j);
                        // cont++;

                    }

                }
            }

            for (int i = 0; i < valor.Count - 1; i++)
            {
                //  listBox1.DataSource= Fil[j].ToString() ;
                listBox4.Items.Add(valor[i]);

            }
        }



        public void Prifil()

        {
            int cont = 0;
            object a = 0;

            List<object> Fil = new List<object>();
            List<object> Fil0 = new List<object>();

            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                for (int j = 1; j < matriz.GetLength(1); j++)
                {

                    if (!matriz[i, j].Equals(""))
                    {
                        cont++;

                    }


                }
                //Fil.Add(cont);
                Fil0.Add(cont);
                // Fil2.Add(Fil);
                cont = 0;
                //  b1 = 0;
            }
            Fil.Add(1);
            for (int i = 0; i < Fil0.Count; i++)
            {
                int pi = Convert.ToInt32(Fil0[i]) + Convert.ToInt32(Fil[i]);
                Fil.Add(pi);

            }


            //IMPRESIONES EN LISTA

            for (int j = 0; j < Fil.Count - 1; j++)
            {

                listBox3.Items.Add(j);

            }

            for (int j = 0; j < Fil.Count - 1; j++)
            {

                listBox1.Items.Add(Fil[j]);
               // tablacompac.Rows[0].Cells[0].Value = Fil[j];

            }


            for (int j = 0; j < Fil0.Count - 1; j++)
            {
                listBox2.Items.Add(Fil0[j]);
                // tablacompac.Rows[0][1] = Fil0[j];

                //  tablacompac.Cells[0].column[0].value = "Valor deseado".;
             //   tablacompac.Rows[0].Cells[0].Value = Fil0[j];


            }



            for (int j = 0; j < Fil0.Count - 1; j++)
            {
                // tablacompac.Rows.Add(Fil0[j]);
               // tablacompac.Rows[0].Cells[1].Value = Fil0[j];

                //int indice = 0;

                //this.dataGridView.Rows[indice].Cells["alimentacion"].Value = "patatas fritas";
                //this.dataGridView.Rows[0].Cells[1].Value = "patatas fritas";
            }


        }

        // fin tabla

        private void button1_Click(object sender, EventArgs e)
        {
            cargarArchivo();
            Prifil();
            cargarTablaCompacta();
        }
    }
}
