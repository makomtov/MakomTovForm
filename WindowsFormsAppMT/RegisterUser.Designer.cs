namespace WindowsFormsAppMT
{
    partial class RegisterUser
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
            this.labelUserFirstName = new System.Windows.Forms.Label();
            this.labelUserLastName = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.labelUserPaswrd = new System.Windows.Forms.Label();
            this.labelUserAddress = new System.Windows.Forms.Label();
            this.labelUserCity = new System.Windows.Forms.Label();
            this.labelUserComments = new System.Windows.Forms.Label();
            this.labelUserPhone1 = new System.Windows.Forms.Label();
            this.labelUserPhone2 = new System.Windows.Forms.Label();
            this.labelPassConfirm = new System.Windows.Forms.Label();
            this.textBoxuserFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserPaswrd = new System.Windows.Forms.TextBox();
            this.textBoxUserPhone2 = new System.Windows.Forms.TextBox();
            this.textBoxUserPhone1 = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxUserAddress = new System.Windows.Forms.TextBox();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserLastName = new System.Windows.Forms.TextBox();
            this.comboBoxUserCityName = new System.Windows.Forms.ComboBox();
            this.textBoxusercomments = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelVetName = new System.Windows.Forms.Label();
            this.textBoxVetName = new System.Windows.Forms.TextBox();
            this.labelVetPhone = new System.Windows.Forms.Label();
            this.textBoxVetPhone = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxAccept = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserFirstName
            // 
            this.labelUserFirstName.AutoSize = true;
            this.labelUserFirstName.Location = new System.Drawing.Point(488, 55);
            this.labelUserFirstName.Name = "labelUserFirstName";
            this.labelUserFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserFirstName.Size = new System.Drawing.Size(51, 13);
            this.labelUserFirstName.TabIndex = 3;
            this.labelUserFirstName.Text = "שם פרטי";
            // 
            // labelUserLastName
            // 
            this.labelUserLastName.AutoSize = true;
            this.labelUserLastName.Location = new System.Drawing.Point(488, 85);
            this.labelUserLastName.Name = "labelUserLastName";
            this.labelUserLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserLastName.Size = new System.Drawing.Size(63, 13);
            this.labelUserLastName.TabIndex = 4;
            this.labelUserLastName.Text = "שם משפחה";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Location = new System.Drawing.Point(488, 115);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserEmail.Size = new System.Drawing.Size(31, 13);
            this.labelUserEmail.TabIndex = 5;
            this.labelUserEmail.Text = "מייל";
            // 
            // labelUserPaswrd
            // 
            this.labelUserPaswrd.AutoSize = true;
            this.labelUserPaswrd.Location = new System.Drawing.Point(523, 497);
            this.labelUserPaswrd.Name = "labelUserPaswrd";
            this.labelUserPaswrd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserPaswrd.Size = new System.Drawing.Size(40, 13);
            this.labelUserPaswrd.TabIndex = 6;
            this.labelUserPaswrd.Text = "סיסמה";
            // 
            // labelUserAddress
            // 
            this.labelUserAddress.AutoSize = true;
            this.labelUserAddress.Location = new System.Drawing.Point(488, 145);
            this.labelUserAddress.Name = "labelUserAddress";
            this.labelUserAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserAddress.Size = new System.Drawing.Size(106, 13);
            this.labelUserAddress.TabIndex = 7;
            this.labelUserAddress.Text = "כתובת(רחוב ומספר)";
            // 
            // labelUserCity
            // 
            this.labelUserCity.AutoSize = true;
            this.labelUserCity.Location = new System.Drawing.Point(488, 175);
            this.labelUserCity.Name = "labelUserCity";
            this.labelUserCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserCity.Size = new System.Drawing.Size(25, 13);
            this.labelUserCity.TabIndex = 8;
            this.labelUserCity.Text = "עיר";
            // 
            // labelUserComments
            // 
            this.labelUserComments.AutoSize = true;
            this.labelUserComments.Location = new System.Drawing.Point(488, 403);
            this.labelUserComments.Name = "labelUserComments";
            this.labelUserComments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserComments.Size = new System.Drawing.Size(39, 13);
            this.labelUserComments.TabIndex = 9;
            this.labelUserComments.Text = "הערות";
            // 
            // labelUserPhone1
            // 
            this.labelUserPhone1.AutoSize = true;
            this.labelUserPhone1.Location = new System.Drawing.Point(488, 205);
            this.labelUserPhone1.Name = "labelUserPhone1";
            this.labelUserPhone1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserPhone1.Size = new System.Drawing.Size(47, 13);
            this.labelUserPhone1.TabIndex = 10;
            this.labelUserPhone1.Text = "טלפון 1";
            // 
            // labelUserPhone2
            // 
            this.labelUserPhone2.AutoSize = true;
            this.labelUserPhone2.Location = new System.Drawing.Point(488, 235);
            this.labelUserPhone2.Name = "labelUserPhone2";
            this.labelUserPhone2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserPhone2.Size = new System.Drawing.Size(47, 13);
            this.labelUserPhone2.TabIndex = 11;
            this.labelUserPhone2.Text = "טלפון 2";
            // 
            // labelPassConfirm
            // 
            this.labelPassConfirm.AutoSize = true;
            this.labelPassConfirm.Location = new System.Drawing.Point(488, 539);
            this.labelPassConfirm.Name = "labelPassConfirm";
            this.labelPassConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPassConfirm.Size = new System.Drawing.Size(75, 13);
            this.labelPassConfirm.TabIndex = 12;
            this.labelPassConfirm.Text = "אימות סיסמה";
            // 
            // textBoxuserFirstName
            // 
            this.textBoxuserFirstName.Location = new System.Drawing.Point(331, 52);
            this.textBoxuserFirstName.Name = "textBoxuserFirstName";
            this.textBoxuserFirstName.Size = new System.Drawing.Size(121, 20);
            this.textBoxuserFirstName.TabIndex = 13;
            this.textBoxuserFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxuserFirstName_Validating);
            // 
            // textBoxUserPaswrd
            // 
            this.textBoxUserPaswrd.Location = new System.Drawing.Point(331, 490);
            this.textBoxUserPaswrd.Name = "textBoxUserPaswrd";
            this.textBoxUserPaswrd.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserPaswrd.TabIndex = 14;
            this.textBoxUserPaswrd.UseSystemPasswordChar = true;
            this.textBoxUserPaswrd.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserPaswrd_Validating);
            // 
            // textBoxUserPhone2
            // 
            this.textBoxUserPhone2.Location = new System.Drawing.Point(331, 235);
            this.textBoxUserPhone2.Name = "textBoxUserPhone2";
            this.textBoxUserPhone2.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserPhone2.TabIndex = 15;
            this.textBoxUserPhone2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserPhone2_Validating);
            // 
            // textBoxUserPhone1
            // 
            this.textBoxUserPhone1.Location = new System.Drawing.Point(331, 205);
            this.textBoxUserPhone1.Name = "textBoxUserPhone1";
            this.textBoxUserPhone1.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserPhone1.TabIndex = 16;
            this.textBoxUserPhone1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserPhone1_Validating);
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Location = new System.Drawing.Point(331, 532);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(121, 20);
            this.textBoxConfirmPass.TabIndex = 17;
            this.textBoxConfirmPass.UseSystemPasswordChar = true;
            this.textBoxConfirmPass.TextChanged += new System.EventHandler(this.textBoxConfirmPass_TextChanged);
            // 
            // textBoxUserAddress
            // 
            this.textBoxUserAddress.Location = new System.Drawing.Point(331, 142);
            this.textBoxUserAddress.Name = "textBoxUserAddress";
            this.textBoxUserAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserAddress.TabIndex = 18;
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.Location = new System.Drawing.Point(331, 115);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserEmail.TabIndex = 19;
            this.textBoxUserEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserEmail_Validating);
            // 
            // textBoxUserLastName
            // 
            this.textBoxUserLastName.Location = new System.Drawing.Point(331, 82);
            this.textBoxUserLastName.Name = "textBoxUserLastName";
            this.textBoxUserLastName.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserLastName.TabIndex = 20;
            this.textBoxUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserLastName_Validating);
            // 
            // comboBoxUserCityName
            // 
            this.comboBoxUserCityName.FormattingEnabled = true;
            this.comboBoxUserCityName.Location = new System.Drawing.Point(331, 171);
            this.comboBoxUserCityName.Name = "comboBoxUserCityName";
            this.comboBoxUserCityName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserCityName.TabIndex = 21;
            // 
            // textBoxusercomments
            // 
            this.textBoxusercomments.Location = new System.Drawing.Point(331, 355);
            this.textBoxusercomments.Multiline = true;
            this.textBoxusercomments.Name = "textBoxusercomments";
            this.textBoxusercomments.Size = new System.Drawing.Size(121, 108);
            this.textBoxusercomments.TabIndex = 22;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(353, 598);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelError.Location = new System.Drawing.Point(132, 521);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 5;
            // 
            // labelVetName
            // 
            this.labelVetName.AutoSize = true;
            this.labelVetName.Location = new System.Drawing.Point(488, 282);
            this.labelVetName.Name = "labelVetName";
            this.labelVetName.Size = new System.Drawing.Size(60, 13);
            this.labelVetName.TabIndex = 24;
            this.labelVetName.Text = "שם וטרינר";
            // 
            // textBoxVetName
            // 
            this.textBoxVetName.Location = new System.Drawing.Point(331, 275);
            this.textBoxVetName.Name = "textBoxVetName";
            this.textBoxVetName.Size = new System.Drawing.Size(121, 20);
            this.textBoxVetName.TabIndex = 25;
            this.textBoxVetName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVetName_Validating);
            // 
            // labelVetPhone
            // 
            this.labelVetPhone.AutoSize = true;
            this.labelVetPhone.Location = new System.Drawing.Point(488, 313);
            this.labelVetPhone.Name = "labelVetPhone";
            this.labelVetPhone.Size = new System.Drawing.Size(75, 13);
            this.labelVetPhone.TabIndex = 26;
            this.labelVetPhone.Text = "טלפון וטרינר";
            // 
            // textBoxVetPhone
            // 
            this.textBoxVetPhone.Location = new System.Drawing.Point(331, 313);
            this.textBoxVetPhone.Name = "textBoxVetPhone";
            this.textBoxVetPhone.Size = new System.Drawing.Size(121, 20);
            this.textBoxVetPhone.TabIndex = 27;
            this.textBoxVetPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVetPhone_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Checked = true;
            this.checkBoxAccept.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAccept.Location = new System.Drawing.Point(437, 572);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAccept.TabIndex = 28;
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "אני מסכים לקבל דואר מהכלביה";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(711, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAccept);
            this.Controls.Add(this.textBoxVetPhone);
            this.Controls.Add(this.labelVetPhone);
            this.Controls.Add(this.textBoxVetName);
            this.Controls.Add(this.labelVetName);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxusercomments);
            this.Controls.Add(this.comboBoxUserCityName);
            this.Controls.Add(this.textBoxUserLastName);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.textBoxUserAddress);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.textBoxUserPhone1);
            this.Controls.Add(this.textBoxUserPhone2);
            this.Controls.Add(this.textBoxUserPaswrd);
            this.Controls.Add(this.textBoxuserFirstName);
            this.Controls.Add(this.labelPassConfirm);
            this.Controls.Add(this.labelUserPhone2);
            this.Controls.Add(this.labelUserPhone1);
            this.Controls.Add(this.labelUserComments);
            this.Controls.Add(this.labelUserCity);
            this.Controls.Add(this.labelUserAddress);
            this.Controls.Add(this.labelUserPaswrd);
            this.Controls.Add(this.labelUserEmail);
            this.Controls.Add(this.labelUserLastName);
            this.Controls.Add(this.labelUserFirstName);
            this.Name = "RegisterUser";
            this.Controls.SetChildIndex(this.labelUserFirstName, 0);
            this.Controls.SetChildIndex(this.labelUserLastName, 0);
            this.Controls.SetChildIndex(this.labelUserEmail, 0);
            this.Controls.SetChildIndex(this.labelUserPaswrd, 0);
            this.Controls.SetChildIndex(this.labelUserAddress, 0);
            this.Controls.SetChildIndex(this.labelUserCity, 0);
            this.Controls.SetChildIndex(this.labelUserComments, 0);
            this.Controls.SetChildIndex(this.labelUserPhone1, 0);
            this.Controls.SetChildIndex(this.labelUserPhone2, 0);
            this.Controls.SetChildIndex(this.labelPassConfirm, 0);
            this.Controls.SetChildIndex(this.textBoxuserFirstName, 0);
            this.Controls.SetChildIndex(this.textBoxUserPaswrd, 0);
            this.Controls.SetChildIndex(this.textBoxUserPhone2, 0);
            this.Controls.SetChildIndex(this.textBoxUserPhone1, 0);
            this.Controls.SetChildIndex(this.textBoxConfirmPass, 0);
            this.Controls.SetChildIndex(this.textBoxUserAddress, 0);
            this.Controls.SetChildIndex(this.textBoxUserEmail, 0);
            this.Controls.SetChildIndex(this.textBoxUserLastName, 0);
            this.Controls.SetChildIndex(this.comboBoxUserCityName, 0);
            this.Controls.SetChildIndex(this.textBoxusercomments, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.labelError, 0);
            this.Controls.SetChildIndex(this.labelVetName, 0);
            this.Controls.SetChildIndex(this.textBoxVetName, 0);
            this.Controls.SetChildIndex(this.labelVetPhone, 0);
            this.Controls.SetChildIndex(this.textBoxVetPhone, 0);
            this.Controls.SetChildIndex(this.checkBoxAccept, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserFirstName;
        private System.Windows.Forms.Label labelUserLastName;
        private System.Windows.Forms.Label labelUserEmail;
        private System.Windows.Forms.Label labelUserPaswrd;
        private System.Windows.Forms.Label labelUserAddress;
        private System.Windows.Forms.Label labelUserCity;
        private System.Windows.Forms.Label labelUserComments;
        private System.Windows.Forms.Label labelUserPhone1;
        private System.Windows.Forms.Label labelUserPhone2;
        private System.Windows.Forms.Label labelPassConfirm;
        private System.Windows.Forms.TextBox textBoxuserFirstName;
        private System.Windows.Forms.TextBox textBoxUserPaswrd;
        private System.Windows.Forms.TextBox textBoxUserPhone2;
        private System.Windows.Forms.TextBox textBoxUserPhone1;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.TextBox textBoxUserAddress;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.TextBox textBoxUserLastName;
        private System.Windows.Forms.ComboBox comboBoxUserCityName;
        private System.Windows.Forms.TextBox textBoxusercomments;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelVetName;
        private System.Windows.Forms.TextBox textBoxVetName;
        private System.Windows.Forms.Label labelVetPhone;
        private System.Windows.Forms.TextBox textBoxVetPhone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAccept;
    }
}
