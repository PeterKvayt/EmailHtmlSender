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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.labelDocumentPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonSelectCss = new System.Windows.Forms.Button();
            this.buttonDelEmail = new System.Windows.Forms.Button();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.tabPageDocument = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelHtmlDoc = new System.Windows.Forms.ToolStripLabel();
            this.richTextBoxHtmlDoc = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelCssDoc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonGetClasses = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxCssDoc = new System.Windows.Forms.RichTextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectHtml
            // 
            this.buttonSelectHtml.Location = new System.Drawing.Point(247, 292);
            this.buttonSelectHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectHtml.Name = "buttonSelectHtml";
            this.buttonSelectHtml.Size = new System.Drawing.Size(233, 41);
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
            this.buttonSend.Location = new System.Drawing.Point(486, 337);
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
            this.textBoxRecipientEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxRecipientEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxRecipientEmail.Location = new System.Drawing.Point(247, 37);
            this.textBoxRecipientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRecipientEmail.Name = "textBoxRecipientEmail";
            this.textBoxRecipientEmail.Size = new System.Drawing.Size(357, 22);
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
            this.textBoxSubject.Size = new System.Drawing.Size(357, 22);
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
            this.checkBoxIsHtml.Location = new System.Drawing.Point(247, 187);
            this.checkBoxIsHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsHtml.Name = "checkBoxIsHtml";
            this.checkBoxIsHtml.Size = new System.Drawing.Size(136, 21);
            this.checkBoxIsHtml.TabIndex = 13;
            this.checkBoxIsHtml.Text = "Is html document";
            this.checkBoxIsHtml.UseVisualStyleBackColor = true;
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
            this.tabControl1.Size = new System.Drawing.Size(739, 423);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.buttonSelectCss);
            this.tabPageMain.Controls.Add(this.buttonDelEmail);
            this.tabPageMain.Controls.Add(this.buttonShowPassword);
            this.tabPageMain.Controls.Add(this.listBoxEmails);
            this.tabPageMain.Controls.Add(this.labelDocumentPath);
            this.tabPageMain.Controls.Add(this.textBoxSubject);
            this.tabPageMain.Controls.Add(this.buttonSelectHtml);
            this.tabPageMain.Controls.Add(this.label2);
            this.tabPageMain.Controls.Add(this.label4);
            this.tabPageMain.Controls.Add(this.checkBoxIsHtml);
            this.tabPageMain.Controls.Add(this.buttonAddEmail);
            this.tabPageMain.Controls.Add(this.label1);
            this.tabPageMain.Controls.Add(this.buttonSend);
            this.tabPageMain.Controls.Add(this.textBoxPassword);
            this.tabPageMain.Controls.Add(this.textBoxNewEmail);
            this.tabPageMain.Controls.Add(this.label5);
            this.tabPageMain.Controls.Add(this.label3);
            this.tabPageMain.Controls.Add(this.textBoxRecipientEmail);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMain.Size = new System.Drawing.Size(731, 394);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // buttonSelectCss
            // 
            this.buttonSelectCss.Location = new System.Drawing.Point(247, 337);
            this.buttonSelectCss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectCss.Name = "buttonSelectCss";
            this.buttonSelectCss.Size = new System.Drawing.Size(233, 41);
            this.buttonSelectCss.TabIndex = 23;
            this.buttonSelectCss.Text = "Select css document";
            this.buttonSelectCss.UseVisualStyleBackColor = true;
            this.buttonSelectCss.Click += new System.EventHandler(this.buttonSelectCss_Click);
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
            // buttonShowPassword
            // 
            this.buttonShowPassword.Location = new System.Drawing.Point(451, 145);
            this.buttonShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(136, 31);
            this.buttonShowPassword.TabIndex = 20;
            this.buttonShowPassword.Text = "Show password";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // tabPageDocument
            // 
            this.tabPageDocument.Controls.Add(this.splitContainer1);
            this.tabPageDocument.Location = new System.Drawing.Point(4, 25);
            this.tabPageDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDocument.Name = "tabPageDocument";
            this.tabPageDocument.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDocument.Size = new System.Drawing.Size(800, 531);
            this.tabPageDocument.TabIndex = 1;
            this.tabPageDocument.Text = "Document";
            this.tabPageDocument.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxHtmlDoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxCssDoc);
            this.splitContainer1.Size = new System.Drawing.Size(794, 527);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelHtmlDoc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelHtmlDoc
            // 
            this.toolStripLabelHtmlDoc.Name = "toolStripLabelHtmlDoc";
            this.toolStripLabelHtmlDoc.Size = new System.Drawing.Size(0, 22);
            // 
            // richTextBoxHtmlDoc
            // 
            this.richTextBoxHtmlDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHtmlDoc.BackColor = System.Drawing.Color.Navy;
            this.richTextBoxHtmlDoc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxHtmlDoc.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxHtmlDoc.Location = new System.Drawing.Point(0, 27);
            this.richTextBoxHtmlDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxHtmlDoc.Name = "richTextBoxHtmlDoc";
            this.richTextBoxHtmlDoc.Size = new System.Drawing.Size(392, 498);
            this.richTextBoxHtmlDoc.TabIndex = 0;
            this.richTextBoxHtmlDoc.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCssDoc,
            this.toolStripButtonGetClasses});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(398, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabelCssDoc
            // 
            this.toolStripLabelCssDoc.Name = "toolStripLabelCssDoc";
            this.toolStripLabelCssDoc.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripButtonGetClasses
            // 
            this.toolStripButtonGetClasses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGetClasses.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGetClasses.Image")));
            this.toolStripButtonGetClasses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGetClasses.Name = "toolStripButtonGetClasses";
            this.toolStripButtonGetClasses.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonGetClasses.Text = "Get classes";
            this.toolStripButtonGetClasses.Click += new System.EventHandler(this.toolStripButtonGetClasses_Click);
            // 
            // richTextBoxCssDoc
            // 
            this.richTextBoxCssDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCssDoc.BackColor = System.Drawing.Color.Navy;
            this.richTextBoxCssDoc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCssDoc.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCssDoc.Location = new System.Drawing.Point(3, 27);
            this.richTextBoxCssDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxCssDoc.Name = "richTextBoxCssDoc";
            this.richTextBoxCssDoc.Size = new System.Drawing.Size(395, 495);
            this.richTextBoxCssDoc.TabIndex = 1;
            this.richTextBoxCssDoc.Text = "";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 423);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageDocument.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.Label labelDocumentPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageDocument;
        private System.Windows.Forms.RichTextBox richTextBoxHtmlDoc;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Button buttonDelEmail;
        private System.Windows.Forms.Button buttonSelectCss;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxCssDoc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelHtmlDoc;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCssDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripButton toolStripButtonGetClasses;
    }
}

