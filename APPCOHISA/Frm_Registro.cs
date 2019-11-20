using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Frm_Registro : Form
    {
        private string correo;
        private string Subject;
        private string Body;

        private MailMessage mail;
        BaseDeDatos bd = new BaseDeDatos();
        public Frm_Registro()
        {
            InitializeComponent();
        }

        private void btnguardarr_Click(object sender, EventArgs e)
        {
            //  string correo = txtcorreor.Text;
            // string password = txtpasswordr.Text;
            // string confpassword = txtconfpasswordr.Text;
            Random rad = new Random();
            // Entre 1000 y 8988
            int aleato = rad.Next(1000, 8988);
            //  Console.WriteLine(aleato);
            if (txtcorreor.TextLength > 0 && txtpasswordr.TextLength > 0 && txtconfpasswordr.TextLength > 0)
            {
                if (txtpasswordr.Text.Equals(txtconfpasswordr.Text))
                {
                    correo = txtcorreor.Text;
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


                    string agregarusu = "insert into usuario values (" + 0 + ",'" + correo + "','" + txtpasswordr.Text + "','" + txtconfpasswordr.Text + "')";
                    string agregar = "insert into verificacion values (" + 0 + ",'" + aleato + "')";
                    if (bd.executecommand(agregarusu) && bd.executecommand(agregar))
                    {
                        // MessageBox.Show("Registro generado");
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
                    MessageBox.Show("La contraseña con coincide");
                }




            }
            else
            {



                MessageBox.Show("llene todos los campos");
            }

        }    
        private void linkr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Login log = new Frm_Login();
            log.Show();
            this.Hide();
        }

        private void Frm_Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
