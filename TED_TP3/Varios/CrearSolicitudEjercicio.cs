using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TED_TP3.Login;

namespace TED_TP3.Varios
{
    public partial class CrearSolicitudEjercicio : Form
    {
        private Main main;
        private LoginCrear loginCrear;
        public CrearSolicitudEjercicio(Docente doc, Main main, LoginCrear loginCrear)
        {
            InitializeComponent();
            lblIngresado.Text = "Docente: " + doc.usuario + ".";
            this.main = main;
            this.loginCrear = loginCrear;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (hayCamposVacios())
            {
                MessageBox.Show("Por favor, cargue todos los campos primero", "Atención", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreDocente.Focus();
            }
            else
            {
                string mensaje = generarMensaje();
                enviarCorreo(mensaje);
                Close();
            }
        }

        private bool hayCamposVacios()
        {
            return (txtNombreDocente.Text == "" || txtCorreoDocente.Text == "" ||
                txtTipoActividad.Text == "" || txtTipoActividad.Text == "" ||
                txtDescripcion.Text == "");
        }

        private string generarMensaje()
        {
            return "Nueva solicitud de creación de actividad Todo química.\n\n" +
                "* Docente: " + txtNombreDocente.Text + ". Correo electrónico: " + txtCorreoDocente.Text
                + "\n\n* Título de actividad: \"" + txtTituloActividad.Text + "\". Tipo de actividad: "
                + txtTipoActividad.Text + "\n\n* Descripción:\n" + txtDescripcion.Text;
        }

        private void enviarCorreo(string mensaje)
        {
            try
            {
                string to = "leandrogabrielgor@gmail.com";
                string from = "lgg.serviceinformatic@gmail.com";
                MailAddress fromEmail = new MailAddress(from);
                MailAddress toEmail = new MailAddress(to);

                MailMessage message = new MailMessage(fromEmail, toEmail);
                message.IsBodyHtml = false;

                message.Subject = "Todo Química - Solicitud Actividad";
                message.Body = mensaje;

                string smtpServer = "smtp.gmail.com";
                int puerto = 587;

                SmtpClient client = new SmtpClient(smtpServer, puerto);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromEmail.Address, "fmfpimddmrtfsnfq");
                client.Send(message);

                MessageBox.Show("Se ha enviado un mail a: " + to + "\n\n\nMensaje:\n\n" + mensaje, 
                    "Envío de correo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex);
            }
        }
    }
}
