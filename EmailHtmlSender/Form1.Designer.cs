namespace EmailHtmlSender
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectHtml = new System.Windows.Forms.Button();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxRecipientEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAddEmail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewEmail = new System.Windows.Forms.TextBox();
            this.checkBoxIsHtml = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxSmtpClients = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonAddSmtpClient = new System.Windows.Forms.Button();
            this.labelDocumentPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.tabPageDocument = new System.Windows.Forms.TabPage();
            this.richTextBoxDocument = new System.Windows.Forms.RichTextBox();
            this.buttonDelEmail = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageDocument.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectHtml
            // 
            this.buttonSelectHtml.Location = new System.Drawing.Point(247, 292);
            this.buttonSelectHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectHtml.Name = "buttonSelectHtml";
            this.buttonSelectHtml.Size = new System.Drawing.Size(305, 41);
            this.buttonSelectHtml.TabIndex = 0;
            this.buttonSelectHtml.Text = "Select html document";
            this.buttonSelectHtml.UseVisualStyleBackColor = true;
            this.buttonSelectHtml.Click += new System.EventHandler(this.buttonSelectHtml_Click);
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.ItemHeight = 16;
            this.listBoxEmails.Location = new System.Drawing.Point(8, 37);
            this.listBoxEmails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(233, 196);
            this.listBoxEmails.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(281, 337);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(233, 41);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxRecipientEmail
            // 
            this.textBoxRecipientEmail.Location = new System.Drawing.Point(247, 37);
            this.textBoxRecipientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRecipientEmail.Name = "textBoxRecipientEmail";
            this.textBoxRecipientEmail.Size = new System.Drawing.Size(305, 22);
            this.textBoxRecipientEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recipient email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(247, 91);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(305, 22);
            this.textBoxSubject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(247, 146);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(199, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // buttonAddEmail
            // 
            this.buttonAddEmail.Location = new System.Drawing.Point(8, 292);
            this.buttonAddEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEmail.Name = "buttonAddEmail";
            this.buttonAddEmail.Size = new System.Drawing.Size(233, 41);
            this.buttonAddEmail.TabIndex = 9;
            this.buttonAddEmail.Text = "Add email";
            this.buttonAddEmail.UseVisualStyleBackColor = true;
            this.buttonAddEmail.Click += new System.EventHandler(this.buttonAddEmail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "My email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "New email";
            // 
            // textBoxNewEmail
            // 
            this.textBoxNewEmail.Location = new System.Drawing.Point(8, 263);
            this.textBoxNewEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewEmail.Name = "textBoxNewEmail";
            this.textBoxNewEmail.Size = new System.Drawing.Size(233, 22);
            this.textBoxNewEmail.TabIndex = 11;
            // 
            // checkBoxIsHtml
            // 
            this.checkBoxIsHtml.AutoSize = true;
            this.checkBoxIsHtml.Location = new System.Drawing.Point(251, 212);
            this.checkBoxIsHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsHtml.Name = "checkBoxIsHtml";
            this.checkBoxIsHtml.Size = new System.Drawing.Size(136, 21);
            this.checkBoxIsHtml.TabIndex = 13;
            this.checkBoxIsHtml.Text = "Is html document";
            this.checkBoxIsHtml.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "My email";
            // 
            // listBoxSmtpClients
            // 
            this.listBoxSmtpClients.FormattingEnabled = true;
            this.listBoxSmtpClients.ItemHeight = 16;
            this.listBoxSmtpClients.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.mail.ru"});
            this.listBoxSmtpClients.Location = new System.Drawing.Point(559, 37);
            this.listBoxSmtpClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSmtpClients.Name = "listBoxSmtpClients";
            this.listBoxSmtpClients.Size = new System.Drawing.Size(233, 196);
            this.listBoxSmtpClients.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "New smtp client";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(563, 263);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 22);
            this.textBox5.TabIndex = 17;
            // 
            // buttonAddSmtpClient
            // 
            this.buttonAddSmtpClient.Location = new System.Drawing.Point(563, 292);
            this.buttonAddSmtpClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSmtpClient.Name = "buttonAddSmtpClient";
            this.buttonAddSmtpClient.Size = new System.Drawing.Size(233, 41);
            this.buttonAddSmtpClient.TabIndex = 16;
            this.buttonAddSmtpClient.Text = "Add client";
            this.buttonAddSmtpClient.UseVisualStyleBackColor = true;
            // 
            // labelDocumentPath
            // 
            this.labelDocumentPath.AutoSize = true;
            this.labelDocumentPath.Location = new System.Drawing.Point(11, 383);
            this.labelDocumentPath.Name = "labelDocumentPath";
            this.labelDocumentPath.Size = new System.Drawing.Size(0, 17);
            this.labelDocumentPath.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageDocument);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 452);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.buttonDelEmail);
            this.tabPageMain.Controls.Add(this.buttonShowPassword);
            this.tabPageMain.Controls.Add(this.listBoxEmails);
            this.tabPageMain.Controls.Add(this.listBoxSmtpClients);
            this.tabPageMain.Controls.Add(this.labelDocumentPath);
            this.tabPageMain.Controls.Add(this.textBoxSubject);
            this.tabPageMain.Controls.Add(this.buttonSelectHtml);
            this.tabPageMain.Controls.Add(this.label2);
            this.tabPageMain.Controls.Add(this.label4);
            this.tabPageMain.Controls.Add(this.label6);
            this.tabPageMain.Controls.Add(this.label7);
            this.tabPageMain.Controls.Add(this.checkBoxIsHtml);
            this.tabPageMain.Controls.Add(this.buttonAddEmail);
            this.tabPageMain.Controls.Add(this.label1);
            this.tabPageMain.Controls.Add(this.buttonSend);
            this.tabPageMain.Controls.Add(this.textBoxPassword);
            this.tabPageMain.Controls.Add(this.textBoxNewEmail);
            this.tabPageMain.Controls.Add(this.buttonAddSmtpClient);
            this.tabPageMain.Controls.Add(this.textBox5);
            this.tabPageMain.Controls.Add(this.label5);
            this.tabPageMain.Controls.Add(this.label3);
            this.tabPageMain.Controls.Add(this.textBoxRecipientEmail);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMain.Size = new System.Drawing.Size(800, 423);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Location = new System.Drawing.Point(451, 145);
            this.buttonShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(101, 25);
            this.buttonShowPassword.TabIndex = 20;
            this.buttonShowPassword.Text = "Show pass";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // tabPageDocument
            // 
            this.tabPageDocument.Controls.Add(this.richTextBoxDocument);
            this.tabPageDocument.Location = new System.Drawing.Point(4, 25);
            this.tabPageDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDocument.Name = "tabPageDocument";
            this.tabPageDocument.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDocument.Size = new System.Drawing.Size(800, 423);
            this.tabPageDocument.TabIndex = 1;
            this.tabPageDocument.Text = "Document";
            this.tabPageDocument.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDocument
            // 
            this.richTextBoxDocument.BackColor = System.Drawing.Color.Navy;
            this.richTextBoxDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDocument.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDocument.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxDocument.Location = new System.Drawing.Point(3, 2);
            this.richTextBoxDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDocument.Name = "richTextBoxDocument";
            this.richTextBoxDocument.Size = new System.Drawing.Size(794, 419);
            this.richTextBoxDocument.TabIndex = 0;
            this.richTextBoxDocument.Text = "";
            // 
            // buttonDelEmail
            // 
            this.buttonDelEmail.Location = new System.Drawing.Point(8, 337);
            this.buttonDelEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelEmail.Name = "buttonDelEmail";
            this.buttonDelEmail.Size = new System.Drawing.Size(233, 41);
            this.buttonDelEmail.TabIndex = 21;
            this.buttonDelEmail.Text = "Delete email";
            this.buttonDelEmail.UseVisualStyleBackColor = true;
            this.buttonDelEmail.Click += new System.EventHandler(this.buttonDelEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageDocument.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectHtml;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxRecipientEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAddEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewEmail;
        private System.Windows.Forms.CheckBox checkBoxIsHtml;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxSmtpClients;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonAddSmtpClient;
        private System.Windows.Forms.Label labelDocumentPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageDocument;
        private System.Windows.Forms.RichTextBox richTextBoxDocument;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Button buttonDelEmail;
    }
}

