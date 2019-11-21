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
    public partial class Frm_Load_AFD : Form
    {
        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo
        public string ARCHIVO = "";

        public Frm_Load_AFD()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Load_AFD_Load(object sender, EventArgs e)
        {
            this.Hide();
            cargarArchivo();

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
                    l.lecturaArchivo(TablaAFD, ';', ARCHIVO);//EL PUNTO Y COMA ES PARA SEPARAR DEL ARCHIVO CSV

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Debe escoger un archivo...!");
                lblErrorAFD.Visible = true; //ESTE EN EL MESAJE QUE SALE CUANDO NO SE ESCOGE NINGUN ARCHIVO
                                            // ImgAlfabeto.Visible = false;


            }

        }
    }
}
