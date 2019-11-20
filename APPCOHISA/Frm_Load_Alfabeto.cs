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
using Microsoft.Win32;

namespace APPCOHISA
{
    public partial class Frm_Load_Alfabeto2 : Form 
    {
        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo
        public string ARCHIVO = "";
       
        public Frm_Load_Alfabeto2()
        {
            InitializeComponent();
          
        }

        //METODO PARA CARGAR EL ARCHIVO DE LA COMPUTADORA
        public void cargarArchivo()
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ARCHIVO = this.openFileDialog1.FileName;
                    l.lecturaArchivo(tablaAlfabeto, ';', ARCHIVO);//EL PUNTO Y COMA ES PARA SEPARAR DEL ARCHIVO CSV
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Debe escoger un archivo...!");
                lblErrorAlfabeto.Visible = true; //ESTE EN EL MESAJE QUE SALE CUANDO NO SE ESCOGE NINGUN ARCHIVO
                ImgAlfabeto.Visible = false;

               
            }
        }

        //ESTAMOS CARGANDO EL ARCHIVO AUTOMATICAMENTE
        private void Frm_Load_Alfabeto_Load(object sender, EventArgs e)
        {
            this.Hide();
            cargarArchivo();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
