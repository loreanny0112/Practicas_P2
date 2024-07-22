using System;
using System.Net;
using System.Net.Mail;

namespace Principio_SRP.Services
{
    public class EmailService
    {
        private readonly string smtpServer;
        private readonly int smtpPort;
        private readonly string smtpUser;
        private readonly string smtpPass;

        public EmailService(string server, int port, string user, string pass)
        {
            smtpServer = server;
            smtpPort = port;
            smtpUser = user;
            smtpPass = pass;
        }

        public void EnviarCorreoElectronico(string destinatario, string asunto, string mensaje)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtpServer);

                mail.From = new MailAddress(smtpUser);
                mail.To.Add(destinatario);
                mail.Subject = asunto;
                mail.Body = mensaje;

                SmtpServer.Port = smtpPort;
                SmtpServer.Credentials = new NetworkCredential(smtpUser, smtpPass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar correo: " + ex.Message);
            }
        }
    }
}