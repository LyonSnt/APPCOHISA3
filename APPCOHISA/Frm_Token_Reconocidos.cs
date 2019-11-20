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
    public partial class Frm_Token_Reconocidos : Form
    {
        public Frm_Token_Reconocidos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceptar", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje de aceptar y cancelar", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje de si y no", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("si, no y cancelar", "Mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("reiniciar y canclear", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aborat, reintentar y cancelar", "Mensaje", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);

        }
    }
}
