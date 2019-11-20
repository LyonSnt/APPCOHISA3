using MySql.Data.MySqlClient;
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
    public partial class Frm_Verificacion : Form
    {
       
        MySqlConnection conexion = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=bdd_appcohisa;UID=root;PASSWORD=;");
        public Frm_Verificacion()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            string bus = "select * from verificacion where codigoverificacion='" + txtverificar.Text + "'";
            MySqlCommand comando = new MySqlCommand(bus, conexion);
            conexion.Open();
            MySqlDataReader leeer = comando.ExecuteReader();
            if (leeer.Read() == true)
            {
                MessageBox.Show("Gracias código correcto");

                Frm_Menu me = new Frm_Menu();
                me.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El código es incorrecto");
            }

            conexion.Close();

        }

        private void Verificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
