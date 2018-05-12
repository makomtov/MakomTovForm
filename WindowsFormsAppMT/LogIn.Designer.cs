namespace WindowsFormsAppMT
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.buttonlogIn = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEmail.Location = new System.Drawing.Point(399, 73);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 25);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "מייל";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPassWord.Location = new System.Drawing.Point(399, 139);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(61, 25);
            this.labelPassWord.TabIndex = 1;
            this.labelPassWord.Text = "סיסמא";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(218, 73);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(147, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(218, 139);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(147, 20);
            this.textBoxPassWord.TabIndex = 3;
            this.textBoxPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassWord_Validating);
            // 
            // buttonlogIn
            // 
            this.buttonlogIn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonlogIn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonlogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonlogIn.Location = new System.Drawing.Point(262, 239);
            this.buttonlogIn.Name = "buttonlogIn";
            this.buttonlogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonlogIn.TabIndex = 4;
            this.buttonlogIn.Text = "התחבר";
            this.buttonlogIn.UseVisualStyleBackColor = false;
            this.buttonlogIn.Click += new System.EventHandler(this.buttonlogIn_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelError.Location = new System.Drawing.Point(150, 315);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 445);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonlogIn);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.labelEmail);
            this.Name = "LogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button buttonlogIn;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}