using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailHtmlSender
{
    class Mail
    {
        private SmtpClient client;

        private MailMessage message;

        public Mail(string from, string password, string to, string subject, string body, bool isHtml)
        {
            // создаем объект сообщения
            message = new MailMessage(from, to);
            // тема письма
            message.Subject = subject;
            // текст письма
            message.Body = body;
            // письмо представляет код html
            message.IsBodyHtml = isHtml;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            client = new SmtpClient
            {
                Host = "smtp." + from.Split('@')[1],
                Port = 25,
                EnableSsl = true,
                Credentials = new NetworkCredential(from, password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
        }

        public void Send()
        {
            try
            {
                client.Send(message);
                message.Dispose();
                MessageBox.Show("Delivered", "Succes", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
    }
}
