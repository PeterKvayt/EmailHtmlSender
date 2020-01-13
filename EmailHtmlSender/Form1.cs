using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailHtmlSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "HTML files(*.html)|*.html|All files(*.*)|*.*";

            checkBoxIsHtml.Checked = true;

            listBoxEmails.SelectedIndex = 0;

            listBoxSmtpClients.SelectedIndex = 1;
        }

        private void buttonSelectHtml_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            labelDocumentPath.Text = openFileDialog1.FileName;

            using (FileStream fstream = File.OpenRead(openFileDialog1.FileName))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                tabControl1.TabPages[1].Controls[0].Text = System.Text.Encoding.UTF8.GetString(array);
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            //if (buttonShowPassword.Text == "Show pass")
            //{
            //    buttonShowPassword.Text = "Hide pass";
            //    //textBoxPassword.PasswordChar = Convert.ToChar(" );
            //}
            //else
            //{
            //    textBoxPassword.PasswordChar = '*';
            //    buttonShowPassword.Text = "Show pass";
            //}

            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textBoxRecipientEmail.Text) || !string.IsNullOrWhiteSpace(textBoxRecipientEmail.Text))
            {
                if (!string.IsNullOrEmpty(textBoxPassword.Text) || !string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    if (!string.IsNullOrEmpty(labelDocumentPath.Text) || !string.IsNullOrWhiteSpace(labelDocumentPath.Text))
                    {
                        Mail mail = new Mail(
                        listBoxEmails.SelectedItem.ToString(),
                        textBoxPassword.Text,
                        textBoxRecipientEmail.Text,
                        textBoxSubject.Text,
                        richTextBoxDocument.Text,
                        checkBoxIsHtml.Checked,
                        listBoxSmtpClients.SelectedItem.ToString()
                    );

                        mail.Send();
                    }
                    else
                    {
                        MessageBox.Show("Emtpy document");
                    }
                }
                else
                {
                    MessageBox.Show("Emtpy password");
                }
            }
            else
            {
                MessageBox.Show("Emtpy mail");
            }
        }
    }
}
