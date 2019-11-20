using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class FrmPortada : Form
    {
        int x = 2255, y = 1;
        int a = 2255, b = 610;

        public FrmPortada()
        {
            InitializeComponent();
        }

        private void FrmPortada_Load(object sender, EventArgs e)
        {
            label1.Text = "COMPILADORES";
            label1.Font = new Font("Elephant", 30, FontStyle.Bold);
            timerSuperior.Interval = 1;
            timerSuperior.Start();

            label3.Text = "ANALIZADOR:LÉXICO-SINTÁCTICO-SEMÁNTICO";
            label3.Font = new Font("Times New Roman", 30, FontStyle.Bold);
            timerInferior.Interval = 50;
            timerInferior.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            this.Hide();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Está seguro de que desea salir", "Programa", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x, y, 1, 1);
            x++;
            if (x >= 1200)
            {
                x = 1;
            }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TimerInferior_Tick(object sender, EventArgs e)
        {
            label3.SetBounds(a, b, 1, 1);
            a++;
            if (a >= 1300)
            {
                a = 1;
            }
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
        
        }
    }

    internal class mensajes
    {
        internal static DialogResult PreguntaSiNo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
