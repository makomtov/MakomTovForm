namespace WindowsFormsAppMT
{
    partial class InsertNewDogForUser
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDogName = new System.Windows.Forms.Label();
            this.labelDogShvav = new System.Windows.Forms.Label();
            this.labelDogType = new System.Windows.Forms.Label();
            this.labelDogGender = new System.Windows.Forms.Label();
            this.labelDogRabiesVaccine = new System.Windows.Forms.Label();
            this.labelDogBirthDate = new System.Windows.Forms.Label();
            this.labelDogFriendlyWith = new System.Windows.Forms.Label();
            this.labelDogDig = new System.Windows.Forms.Label();
            this.labelDogJump = new System.Windows.Forms.Label();
            this.labelDogComments = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.textBoxDogShvav = new System.Windows.Forms.TextBox();
            this.comboBoxDogType = new System.Windows.Forms.ComboBox();
            this.comboBoxDogGender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDogRabiesVaccine = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDogBirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDogFriendlyWith = new System.Windows.Forms.ComboBox();
            this.checkBoxDogDig = new System.Windows.Forms.CheckBox();
            this.checkBoxDogJump = new System.Windows.Forms.CheckBox();
            this.textBoxusercomments = new System.Windows.Forms.TextBox();
            this.checkBoxDogNeuter = new System.Windows.Forms.CheckBox();
            this.labelDogNeuter = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(808, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 25);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "כלב חדש ל";
            // 
            // labelDogName
            // 
            this.labelDogName.AutoSize = true;
            this.labelDogName.Location = new System.Drawing.Point(951, 106);
            this.labelDogName.Name = "labelDogName";
            this.labelDogName.Size = new System.Drawing.Size(47, 13);
            this.labelDogName.TabIndex = 14;
            this.labelDogName.Text = "שם כלב";
            // 
            // labelDogShvav
            // 
            this.labelDogShvav.AutoSize = true;
            this.labelDogShvav.Location = new System.Drawing.Point(950, 146);
            this.labelDogShvav.Name = "labelDogShvav";
            this.labelDogShvav.Size = new System.Drawing.Size(60, 13);
            this.labelDogShvav.TabIndex = 15;
            this.labelDogShvav.Text = "מספר שבב";
            // 
            // labelDogType
            // 
            this.labelDogType.AutoSize = true;
            this.labelDogType.Location = new System.Drawing.Point(950, 184);
            this.labelDogType.Name = "labelDogType";
            this.labelDogType.Size = new System.Drawing.Size(25, 13);
            this.labelDogType.TabIndex = 16;
            this.labelDogType.Text = "גזע";
            // 
            // labelDogGender
            // 
            this.labelDogGender.AutoSize = true;
            this.labelDogGender.Location = new System.Drawing.Point(951, 228);
            this.labelDogGender.Name = "labelDogGender";
            this.labelDogGender.Size = new System.Drawing.Size(24, 13);
            this.labelDogGender.TabIndex = 17;
            this.labelDogGender.Text = "מין";
            // 
            // labelDogRabiesVaccine
            // 
            this.labelDogRabiesVaccine.AutoSize = true;
            this.labelDogRabiesVaccine.Location = new System.Drawing.Point(950, 320);
            this.labelDogRabiesVaccine.Name = "labelDogRabiesVaccine";
            this.labelDogRabiesVaccine.Size = new System.Drawing.Size(103, 13);
            this.labelDogRabiesVaccine.TabIndex = 19;
            this.labelDogRabiesVaccine.Text = "תאריך חיסון כלבת";
            // 
            // labelDogBirthDate
            // 
            this.labelDogBirthDate.AutoSize = true;
            this.labelDogBirthDate.Location = new System.Drawing.Point(953, 361);
            this.labelDogBirthDate.Name = "labelDogBirthDate";
            this.labelDogBirthDate.Size = new System.Drawing.Size(69, 13);
            this.labelDogBirthDate.TabIndex = 20;
            this.labelDogBirthDate.Text = "תאריך לידה";
            // 
            // labelDogFriendlyWith
            // 
            this.labelDogFriendlyWith.AutoSize = true;
            this.labelDogFriendlyWith.Location = new System.Drawing.Point(953, 270);
            this.labelDogFriendlyWith.Name = "labelDogFriendlyWith";
            this.labelDogFriendlyWith.Size = new System.Drawing.Size(58, 13);
            this.labelDogFriendlyWith.TabIndex = 21;
            this.labelDogFriendlyWith.Text = "מסתדר עם";
            // 
            // labelDogDig
            // 
            this.labelDogDig.AutoSize = true;
            this.labelDogDig.Location = new System.Drawing.Point(953, 451);
            this.labelDogDig.Name = "labelDogDig";
            this.labelDogDig.Size = new System.Drawing.Size(38, 13);
            this.labelDogDig.TabIndex = 22;
            this.labelDogDig.Text = "?חופר";
            // 
            // labelDogJump
            // 
            this.labelDogJump.AutoSize = true;
            this.labelDogJump.Location = new System.Drawing.Point(953, 493);
            this.labelDogJump.Name = "labelDogJump";
            this.labelDogJump.Size = new System.Drawing.Size(40, 13);
            this.labelDogJump.TabIndex = 23;
            this.labelDogJump.Text = "?קופץ";
            // 
            // labelDogComments
            // 
            this.labelDogComments.AutoSize = true;
            this.labelDogComments.Location = new System.Drawing.Point(953, 547);
            this.labelDogComments.Name = "labelDogComments";
            this.labelDogComments.Size = new System.Drawing.Size(39, 13);
            this.labelDogComments.TabIndex = 24;
            this.labelDogComments.Text = "הערות";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(813, 672);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Location = new System.Drawing.Point(807, 103);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDogName.TabIndex = 26;
            this.textBoxDogName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDogName_Validating);
            // 
            // textBoxDogShvav
            // 
            this.textBoxDogShvav.Location = new System.Drawing.Point(807, 143);
            this.textBoxDogShvav.Name = "textBoxDogShvav";
            this.textBoxDogShvav.Size = new System.Drawing.Size(100, 20);
            this.textBoxDogShvav.TabIndex = 27;
            // 
            // comboBoxDogType
            // 
            this.comboBoxDogType.FormattingEnabled = true;
            this.comboBoxDogType.Location = new System.Drawing.Point(786, 181);
            this.comboBoxDogType.Name = "comboBoxDogType";
            this.comboBoxDogType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDogType.TabIndex = 28;
            this.comboBoxDogType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // comboBoxDogGender
            // 
            this.comboBoxDogGender.FormattingEnabled = true;
            this.comboBoxDogGender.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.comboBoxDogGender.Location = new System.Drawing.Point(786, 225);
            this.comboBoxDogGender.Name = "comboBoxDogGender";
            this.comboBoxDogGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDogGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDogGender.TabIndex = 29;
            this.comboBoxDogGender.Text = "בחר";
            this.comboBoxDogGender.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // dateTimePickerDogRabiesVaccine
            // 
            this.dateTimePickerDogRabiesVaccine.Location = new System.Drawing.Point(707, 313);
            this.dateTimePickerDogRabiesVaccine.Name = "dateTimePickerDogRabiesVaccine";
            this.dateTimePickerDogRabiesVaccine.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDogRabiesVaccine.TabIndex = 31;
            // 
            // dateTimePickerDogBirthDate
            // 
            this.dateTimePickerDogBirthDate.Location = new System.Drawing.Point(707, 355);
            this.dateTimePickerDogBirthDate.Name = "dateTimePickerDogBirthDate";
            this.dateTimePickerDogBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDogBirthDate.TabIndex = 32;
            // 
            // comboBoxDogFriendlyWith
            // 
            this.comboBoxDogFriendlyWith.FormattingEnabled = true;
            this.comboBoxDogFriendlyWith.Location = new System.Drawing.Point(786, 270);
            this.comboBoxDogFriendlyWith.Name = "comboBoxDogFriendlyWith";
            this.comboBoxDogFriendlyWith.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDogFriendlyWith.TabIndex = 33;
            this.comboBoxDogFriendlyWith.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // checkBoxDogDig
            // 
            this.checkBoxDogDig.AutoSize = true;
            this.checkBoxDogDig.Location = new System.Drawing.Point(892, 450);
            this.checkBoxDogDig.Name = "checkBoxDogDig";
            this.checkBoxDogDig.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDogDig.TabIndex = 34;
            this.checkBoxDogDig.UseVisualStyleBackColor = true;
            // 
            // checkBoxDogJump
            // 
            this.checkBoxDogJump.AutoSize = true;
            this.checkBoxDogJump.Location = new System.Drawing.Point(892, 493);
            this.checkBoxDogJump.Name = "checkBoxDogJump";
            this.checkBoxDogJump.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDogJump.TabIndex = 35;
            this.checkBoxDogJump.UseVisualStyleBackColor = true;
            // 
            // textBoxusercomments
            // 
            this.textBoxusercomments.Location = new System.Drawing.Point(786, 531);
            this.textBoxusercomments.Multiline = true;
            this.textBoxusercomments.Name = "textBoxusercomments";
            this.textBoxusercomments.Size = new System.Drawing.Size(121, 108);
            this.textBoxusercomments.TabIndex = 36;
            // 
            // checkBoxDogNeuter
            // 
            this.checkBoxDogNeuter.AutoSize = true;
            this.checkBoxDogNeuter.Location = new System.Drawing.Point(892, 414);
            this.checkBoxDogNeuter.Name = "checkBoxDogNeuter";
            this.checkBoxDogNeuter.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDogNeuter.TabIndex = 38;
            this.checkBoxDogNeuter.UseVisualStyleBackColor = true;
            // 
            // labelDogNeuter
            // 
            this.labelDogNeuter.AutoSize = true;
            this.labelDogNeuter.Location = new System.Drawing.Point(950, 415);
            this.labelDogNeuter.Name = "labelDogNeuter";
            this.labelDogNeuter.Size = new System.Drawing.Size(82, 13);
            this.labelDogNeuter.TabIndex = 37;
            this.labelDogNeuter.Text = "?מסורס/מעוקר";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InsertNewDogForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1370, 719);
            this.Controls.Add(this.checkBoxDogNeuter);
            this.Controls.Add(this.labelDogNeuter);
            this.Controls.Add(this.textBoxusercomments);
            this.Controls.Add(this.checkBoxDogJump);
            this.Controls.Add(this.checkBoxDogDig);
            this.Controls.Add(this.comboBoxDogFriendlyWith);
            this.Controls.Add(this.dateTimePickerDogBirthDate);
            this.Controls.Add(this.dateTimePickerDogRabiesVaccine);
            this.Controls.Add(this.comboBoxDogGender);
            this.Controls.Add(this.comboBoxDogType);
            this.Controls.Add(this.textBoxDogShvav);
            this.Controls.Add(this.textBoxDogName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDogComments);
            this.Controls.Add(this.labelDogJump);
            this.Controls.Add(this.labelDogDig);
            this.Controls.Add(this.labelDogFriendlyWith);
            this.Controls.Add(this.labelDogBirthDate);
            this.Controls.Add(this.labelDogRabiesVaccine);
            this.Controls.Add(this.labelDogGender);
            this.Controls.Add(this.labelDogType);
            this.Controls.Add(this.labelDogShvav);
            this.Controls.Add(this.labelDogName);
            this.Controls.Add(this.labelName);
            this.Name = "InsertNewDogForUser";
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.labelDogName, 0);
            this.Controls.SetChildIndex(this.labelDogShvav, 0);
            this.Controls.SetChildIndex(this.labelDogType, 0);
            this.Controls.SetChildIndex(this.labelDogGender, 0);
            this.Controls.SetChildIndex(this.labelDogRabiesVaccine, 0);
            this.Controls.SetChildIndex(this.labelDogBirthDate, 0);
            this.Controls.SetChildIndex(this.labelDogFriendlyWith, 0);
            this.Controls.SetChildIndex(this.labelDogDig, 0);
            this.Controls.SetChildIndex(this.labelDogJump, 0);
            this.Controls.SetChildIndex(this.labelDogComments, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.textBoxDogName, 0);
            this.Controls.SetChildIndex(this.textBoxDogShvav, 0);
            this.Controls.SetChildIndex(this.comboBoxDogType, 0);
            this.Controls.SetChildIndex(this.comboBoxDogGender, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDogRabiesVaccine, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDogBirthDate, 0);
            this.Controls.SetChildIndex(this.comboBoxDogFriendlyWith, 0);
            this.Controls.SetChildIndex(this.checkBoxDogDig, 0);
            this.Controls.SetChildIndex(this.checkBoxDogJump, 0);
            this.Controls.SetChildIndex(this.textBoxusercomments, 0);
            this.Controls.SetChildIndex(this.labelDogNeuter, 0);
            this.Controls.SetChildIndex(this.checkBoxDogNeuter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDogName;
        private System.Windows.Forms.Label labelDogShvav;
        private System.Windows.Forms.Label labelDogType;
        private System.Windows.Forms.Label labelDogGender;
        private System.Windows.Forms.Label labelDogRabiesVaccine;
        private System.Windows.Forms.Label labelDogBirthDate;
        private System.Windows.Forms.Label labelDogFriendlyWith;
        private System.Windows.Forms.Label labelDogDig;
        private System.Windows.Forms.Label labelDogJump;
        private System.Windows.Forms.Label labelDogComments;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDogName;
        private System.Windows.Forms.TextBox textBoxDogShvav;
        private System.Windows.Forms.ComboBox comboBoxDogType;
        private System.Windows.Forms.ComboBox comboBoxDogGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogRabiesVaccine;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogBirthDate;
        private System.Windows.Forms.ComboBox comboBoxDogFriendlyWith;
        private System.Windows.Forms.CheckBox checkBoxDogDig;
        private System.Windows.Forms.CheckBox checkBoxDogJump;
        private System.Windows.Forms.TextBox textBoxusercomments;
        private System.Windows.Forms.CheckBox checkBoxDogNeuter;
        private System.Windows.Forms.Label labelDogNeuter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
