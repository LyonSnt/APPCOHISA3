using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace APPCOHISA
{
    public partial class Frm_Menu : Form
    {

        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo .txt
        public string ARCHIVO = "";
        static private List<Rutas> rutas;
        public String Path_actual;
        public String nombre_acual;
        Frm_Movimientos movimiento = new Frm_Movimientos();
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

                //  Frm_Movimientos mo = new Frm_Movimientos();
                movimiento.richTextBox1.Text = texto;


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

      
        public Frm_Menu()
        {
            InitializeComponent();
            hideSubMenu();
            rutas = new List<Rutas>();
        }

        public void hideSubMenu()
        {
            PanelLexico.Visible = false;
            PanelSintactico.Visible = false;
            PanelSemantico.Visible = false;
            PanelSubmenuCargar.Visible = false;
            PanelSubmenuAnaliza.Visible = false;
        }

        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSemantico);
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelSubMenuLateral.Controls.Add(childForm);
            PanelSubMenuLateral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            logogeneral.Visible = true;
            //

        }






        private void btnAFD_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Frm_Load_AFD());
            hideSubMenu();
        }

       

        private void BtnAlfabeto_Click_1(object sender, EventArgs e)
        {

            //  cargarArchivo();

            openChildForm(new Frm_Load_Alfabeto2());
            hideSubMenu();

        }

        private void btnMenuTC_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Tabla_Compacta2());
            hideSubMenu();
        }

        private void BtnMenuAnalizador_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubmenuAnaliza);
        }

        private void BtnSubMovimiento_Click(object sender, EventArgs e)
        {
           // CargarMovimiento();
           // movimiento.Show();
            openChildForm(new Frm_Movimientos());
            hideSubMenu();
        }

        private void btnSubTokenReconocido_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1 ());
            hideSubMenu();
            /*openChildForm(new Frm_Token_Reconocidos());
            hideSubMenu();*/
        }

        private void btnSubTDS_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Load_TDS());
            hideSubMenu();
        }

        private void btnMenuCargar_Click(object sender, EventArgs e)
        {

            ///yo edite hoyyyyyyyyksksksksk
            showSubMenu(PanelSubmenuCargar);
        }

        private void BtnLexico_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelLexico);
        }

        private void btnSintactico_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSintactico);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}