using MySql.Data.MySqlClient;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Frm_Login : Form
    {
        MySqlConnection conexion = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=bdd_appcohisa;UID=root;PASSWORD=;");

        BaseDeDatos bd = new BaseDeDatos();

        private string correo;
        private string Subject;
        private string Body;
        private MailMessage mail;
       // private Attachment Data;


        public Frm_Login()
        {
            InitializeComponent();
        }

      

        private void btningesar_Click(object sender, EventArgs e)
        {
            //COMENTARIO DEEE
            Random rad = new Random();
            // Entre 1000 y 8988
            int aleato = rad.Next(1000, 8988);
            //  Console.WriteLine(aleato);
            string usuario = bd.selectstring("select correo from usuario where correo = '" + txtusuario.Text + "'");
            string contraseña = bd.selectstring("select password from usuario where password = '" + txtpassword.Text + "'");

            if (txtusuario.TextLength > 0 && txtpassword.TextLength > 0)
            {
                if (usuario == txtusuario.Text && contraseña == txtpassword.Text)
                {
                    correo = txtusuario.Text;
                    Subject = "APPCOHISA.SA";
                    Body = " Numero de verificación: " + aleato;

                    mail = new MailMessage();
                    mail.To.Add(new MailAddress(this.correo));
                    mail.From = new MailAddress("lyon12189@gmail.com");
                    mail.Subject = Subject;
                    mail.Body = Body;
                    mail.IsBodyHtml = false;

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    using (client)
                    {
                        client.Credentials = new System.Net.NetworkCredential("lyon12189@gmail.com", "cinthiagm31032014");
                        client.EnableSsl = true;
                        client.Send(mail);
                    }
                    //  MessageBox.Show("Mensaje enviado");

                    string agregar = "insert into verificacion values (" + 0 + ",'" + aleato + "')";
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Revise su correo y valide");

                        Frm_Verificacion veri = new Frm_Verificacion();
                        veri.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar a la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario/contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("llene todos los campos");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Registro regis = new Frm_Registro();
            regis.Show();
            this.Hide();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
