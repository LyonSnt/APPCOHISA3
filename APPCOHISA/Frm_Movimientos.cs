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
    public partial class Frm_Movimientos : Form
    {

        static private List<Rutas> rutas;
        public String Path_actual;
        public String nombre_acual;

        public Frm_Movimientos()
        {
            InitializeComponent();
            rutas = new List<Rutas>();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMovimiento_Click(object sender, EventArgs e)
        {
           // string line;
            string texto;
            texto = richTextBox1.Text;
            //  StreamReader r = new StreamReader(@"E:\test.txt");
            //line = r.ReadToEnd();
            if (texto != null)
            {
                Tablamovimiento.Rows.Clear(); //ESTA PARTE ES PARA LIMPIAR AL MOMENTO DE EJECUTAR NUEVAMENTE
                var chars = texto.ToCharArray();
                int ctr;
                for (ctr = 0; ctr < chars.Length; ctr++)
                    Tablamovimiento.Rows.Add(ctr, chars[ctr], ctr + 1);
                // r.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "[UTN]|*.utn";
            string texto = "";
            string fila = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string ruta1 = openFile.FileName;
                StreamReader streamReader = new StreamReader(ruta1, System.Text.Encoding.UTF8);
                string nombreC = Path.GetFileNameWithoutExtension(openFile.FileName);
                while ((fila = streamReader.ReadLine()) != null)
                {
                    texto += fila + System.Environment.NewLine;
                }
                richTextBox1.Text = texto; //esta es la que imprime los datos
                streamReader.Close();
                //MessageBox.Show(nombreC, "nombreC");
                //MessageBox.Show(ruta1, "ruta1");

                rutas.Clear();
                Rutas path = new Rutas(ruta1, nombreC);
                rutas.Add(path);

                //MessageBox.Show(rutas.Count.ToString() , "rutas.Count");
                Path_actual = ruta1;
                nombre_acual = nombreC;
                this.Text = nombre_acual;

            }
        }


        public void CargarMovimiento()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "[UTN]|*.utn";
            string texto = "";
            string fila = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string ruta1 = openFile.FileName;
                StreamReader streamReader = new StreamReader(ruta1, System.Text.Encoding.UTF8);
                string nombreC = Path.GetFileNameWithoutExtension(openFile.FileName);
                while ((fila = streamReader.ReadLine()) != null)
                {
                    texto += fila + System.Environment.NewLine;
                }
                richTextBox1.Text = texto; //esta es la que imprime los datos
                streamReader.Close();
                //MessageBox.Show(nombreC, "nombreC");
                //MessageBox.Show(ruta1, "ruta1");

                rutas.Clear();
                Rutas path = new Rutas(ruta1, nombreC);
                rutas.Add(path);

                //MessageBox.Show(rutas.Count.ToString() , "rutas.Count");
                Path_actual = ruta1;
                nombre_acual = nombreC;
                this.Text = nombre_acual;

            }
        }
        private void Frm_Movimientos_Load(object sender, EventArgs e)
        {
            this.Hide();
            CargarMovimiento();
            
        }
    }
}
