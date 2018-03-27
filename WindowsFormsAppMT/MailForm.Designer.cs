namespace WindowsFormsAppMT
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelSuject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(261, 44);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(384, 20);
            this.textBoxTo.TabIndex = 3;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(261, 92);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(384, 20);
            this.textBoxSubject.TabIndex = 4;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(261, 377);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(384, 223);
            this.textBoxBody.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(261, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 147);
            this.listBox1.TabIndex = 7;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(166, 193);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(272, 652);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(373, 44);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "שלח";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(697, 51);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 13);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "אל";
            // 
            // labelSuject
            // 
            this.labelSuject.AutoSize = true;
            this.labelSuject.Location = new System.Drawing.Point(684, 99);
            this.labelSuject.Name = "labelSuject";
            this.labelSuject.Size = new System.Drawing.Size(34, 13);
            this.labelSuject.TabIndex = 13;
            this.labelSuject.Text = "נושא";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1076, 745);
            this.Controls.Add(this.labelSuject);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxTo);
            this.Name = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load_1);
            this.Controls.SetChildIndex(this.textBoxTo, 0);
            this.Controls.SetChildIndex(this.textBoxSubject, 0);
            this.Controls.SetChildIndex(this.textBoxBody, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.buttonBrowse, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.buttonSend, 0);
            this.Controls.SetChildIndex(this.labelTo, 0);
            this.Controls.SetChildIndex(this.labelSuject, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelSuject;
    }
}
