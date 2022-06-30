using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using ClasesBase;
using System.Net;

namespace Vistas
{
    public partial class FrmCorreo : Form
    {
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("lpoo1.unju@gmail.com", "lktlhngpncsttabg");

        public FrmCorreo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "" || !txtCorreo.Text.Contains('@'))
                MessageBox.Show("Debe ingresar un correo electrónico válido");
            else
            {
                string body = "";
                DataTable usuarios = TrabajarUsuario.buscarPorCorreo(txtCorreo.Text);
                
                foreach (DataRow row in usuarios.Rows)
                {
                    string usuario = row["usu_NombreUsuario"].ToString();
                    string pwd = row["usu_Contrasenia"].ToString();
                    body += string.Format("Usuario: {1}{0}Contraseña: {2}{0}{0}", Environment.NewLine, usuario, pwd);
                }
                Send(txtCorreo.Text, "lpoo1.unju@gmail.com", "Recuperación de usuario y contraseña", body);
                this.Close();
            }
        }

        public void Send(string sendTo, string sendFrom, string subject, string body)
        {
            try
            {
                //setup SMTP Host Here
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smtpCreds;
                client.EnableSsl = true;

                //converte string to MailAdress
                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress(sendFrom);

                //set up message settings
                msg.Subject = subject;
                msg.Body = body;
                msg.From = from;
                msg.To.Add(to);

                // Enviar E-mail
                client.Send(msg);
                MessageBox.Show("Si su correo se encuentra registrado, \nle llegará el nombre de usuario \ny contraseña asociado al mismo");

            }
            catch (Exception error)
            {
                MessageBox.Show("Unexpected Error: " + error);
            }
        }

    }
}
