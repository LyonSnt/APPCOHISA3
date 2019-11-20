using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace APPCOHISA
{
    public partial class FormAntiguo : Form
    {
        public FormAntiguo()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Frm_Menu m = new Frm_Menu();
            m.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Left -= 8;
            if (label2.Left <= -Width)
            {
                label2.Left = Width;
            };
            //hhhh hhhh
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
                label3.Text = "Cargando el sistema al" + progressBar1.Value + "%";
                
            }
            else
            {
                timer2.Enabled=false;
                FormAntiguo f = new FormAntiguo();
                f.Hide();
                Frm_Login m = new Frm_Login();
                m.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer2.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
