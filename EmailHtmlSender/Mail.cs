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

        public Mail(string from, string password, string to, string subject, string body, bool isHtml, string smtp)
        {

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            //MailAddress From = new MailAddress(from);
            //// кому отправляем
            //MailAddress To = new MailAddress(to);
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
                Host = smtp,
                Port = 25,
                EnableSsl = true,
                Credentials = new NetworkCredential(from, password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            //client.DeliveryMethod = new SmtpDeliveryMethod();
            //client.Credentials = new NetworkCredential(from, password);
            //client.EnableSsl = true;

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
