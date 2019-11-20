using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Frm_Tabla_Compacta2 : Form
    {
        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo
        public string ARCHIVO = "";
        public string ARCHIVO2 = "";

        //METODO PARA CARGAR EL ARCHIVO DE LA COMPUTADORA
        public void cargarArchivo()
        {
            try
            {
                //  this.openFileDialog1.ShowDialog();

                //if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                //{
                    ARCHIVO = @"E:\c#\APPCOHISA\APPCOHISA\Archivos\tablacompacta.csv";
                ARCHIVO2 = @"E:\c#\APPCOHISA\APPCOHISA\Archivos\Matriz.csv";
                l.lecturaArchivo(tabla1, ';', ARCHIVO);//EL PUNTO Y COMA ES PARA SEPARAR DEL ARCHIVO CSV
                l.lecturaArchivo(tabla2, ';', ARCHIVO2);
                //}

            }
            catch (Exception)
            {

                MessageBox.Show("NO se que pasaa...!");
                //lblErrorAlfabeto.Visible = true; //ESTE EN EL MESAJE QUE SALE CUANDO NO SE ESCOGE NINGUN ARCHIVO
                //ImgAlfabeto.Visible = false;


            }
        }
        public Frm_Tabla_Compacta2()
        {
            InitializeComponent();
        }



        private void Frm_Tabla_Compacta2_Load(object sender, EventArgs e)
        {
            cargarArchivo();
        }
    }
}
