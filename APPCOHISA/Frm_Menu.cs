using System;
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

      
        public Frm_Menu()
        {
            InitializeComponent();
            hideSubMenu();
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
            ///edito Edisonnnnn
           // openChildForm(new TablaCompacta());
            hideSubMenu();
        }

        private void BtnMenuAnalizador_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubmenuAnaliza);
        }

        private void BtnSubMovimiento_Click(object sender, EventArgs e)
        {
            //edismmnznxgxgxg
            openChildForm(new Frm_Movimientos());
            hideSubMenu();
        }

        private void btnSubTokenReconocido_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Token_Reconocidos());
            hideSubMenu();
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
            openChildForm(new Frm_Token_Reconocidos());
            hideSubMenu();
        }
    }
}