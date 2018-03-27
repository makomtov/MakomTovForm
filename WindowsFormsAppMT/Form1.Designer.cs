namespace WindowsFormsAppMT
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.useraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDogs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReservationsNumber = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CreateOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.DogNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogShvav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogNeuter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogRabiesVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogFriendlyWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogDig = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogJump = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Manager_Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDogs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserFirstName,
            this.User,
            this.UserLastName,
            this.UserEmail,
            this.useraddress,
            this.UserPhones,
            this.UserDogs,
            this.ReservationsNumber,
            this.CreateOrder});
            this.dataGridView1.Location = new System.Drawing.Point(925, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(537, 198);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // UserFirstName
            // 
            this.UserFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserFirstName.DataPropertyName = "UserFirstName";
            this.UserFirstName.FillWeight = 45.57619F;
            this.UserFirstName.HeaderText = "שם פרטי";
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.ReadOnly = true;
            this.UserFirstName.Width = 70;
            // 
            // User
            // 
            this.User.DataPropertyName = "UserID";
            this.User.HeaderText = "Column1";
            this.User.Name = "User";
            this.User.Visible = false;
            // 
            // UserLastName
            // 
            this.UserLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserLastName.DataPropertyName = "UserLastName";
            this.UserLastName.FillWeight = 45.57619F;
            this.UserLastName.HeaderText = "שם משפחה";
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.ReadOnly = true;
            this.UserLastName.Width = 81;
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserEmail.DataPropertyName = "UserEmail";
            this.UserEmail.FillWeight = 45.57619F;
            this.UserEmail.HeaderText = "מייל";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UserEmail.Width = 56;
            // 
            // useraddress
            // 
            this.useraddress.HeaderText = "כתובת";
            this.useraddress.Name = "useraddress";
            // 
            // UserPhones
            // 
            this.UserPhones.HeaderText = "טלפונים";
            this.UserPhones.Name = "UserPhones";
            // 
            // UserDogs
            // 
            this.UserDogs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserDogs.DataPropertyName = "DogsNumber";
            this.UserDogs.HeaderText = "כלבים";
            this.UserDogs.Name = "UserDogs";
            this.UserDogs.Width = 46;
            // 
            // ReservationsNumber
            // 
            this.ReservationsNumber.DataPropertyName = "ReservationsNumber";
            this.ReservationsNumber.HeaderText = "הזמנות";
            this.ReservationsNumber.Name = "ReservationsNumber";
            // 
            // CreateOrder
            // 
            this.CreateOrder.HeaderText = "צור הזמנה";
            this.CreateOrder.Name = "CreateOrder";
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogNumber,
            this.DogName,
            this.DogComments,
            this.DogShvav,
            this.DogType,
            this.DogImage,
            this.DogGender,
            this.DogNeuter,
            this.DogRabiesVaccine,
            this.DogBirthDate,
            this.DogFriendlyWith,
            this.DogDig,
            this.DogJump,
            this.Manager_Comments});
            this.dataGridViewDogs.Location = new System.Drawing.Point(82, 185);
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewDogs.Size = new System.Drawing.Size(837, 150);
            this.dataGridViewDogs.TabIndex = 3;
            this.dataGridViewDogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // DogNumber
            // 
            this.DogNumber.DataPropertyName = "DogNumber";
            this.DogNumber.HeaderText = "Column1";
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Visible = false;
            // 
            // DogName
            // 
            this.DogName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DogName.DataPropertyName = "DogName";
            this.DogName.HeaderText = "שם כלב";
            this.DogName.Name = "DogName";
            this.DogName.Width = 72;
            // 
            // DogComments
            // 
            this.DogComments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DogComments.DataPropertyName = "DogComments";
            this.DogComments.HeaderText = "הערות";
            this.DogComments.Name = "DogComments";
            this.DogComments.Width = 64;
            // 
            // DogShvav
            // 
            this.DogShvav.DataPropertyName = "DogShvav";
            this.DogShvav.HeaderText = "שבב";
            this.DogShvav.Name = "DogShvav";
            // 
            // DogType
            // 
            this.DogType.DataPropertyName = "DogType";
            this.DogType.HeaderText = "גזע";
            this.DogType.Name = "DogType";
            // 
            // DogImage
            // 
            this.DogImage.DataPropertyName = "DogImage";
            this.DogImage.HeaderText = "תמונה";
            this.DogImage.Name = "DogImage";
            this.DogImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DogImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DogGender
            // 
            this.DogGender.DataPropertyName = "DogGender";
            this.DogGender.HeaderText = "מין";
            this.DogGender.Name = "DogGender";
            this.DogGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DogGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DogNeuter
            // 
            this.DogNeuter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DogNeuter.DataPropertyName = "DogNeuter";
            this.DogNeuter.HeaderText = "מסורס?";
            this.DogNeuter.Name = "DogNeuter";
            this.DogNeuter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DogNeuter.Width = 51;
            // 
            // DogRabiesVaccine
            // 
            this.DogRabiesVaccine.DataPropertyName = "DogRabiesVaccine";
            this.DogRabiesVaccine.HeaderText = "תאריך חיסון";
            this.DogRabiesVaccine.Name = "DogRabiesVaccine";
            // 
            // DogBirthDate
            // 
            this.DogBirthDate.DataPropertyName = "age";
            this.DogBirthDate.HeaderText = "גיל";
            this.DogBirthDate.Name = "DogBirthDate";
            // 
            // DogFriendlyWith
            // 
            this.DogFriendlyWith.DataPropertyName = "DogFriendlyWith";
            this.DogFriendlyWith.HeaderText = "מסתדר עם";
            this.DogFriendlyWith.Name = "DogFriendlyWith";
            // 
            // DogDig
            // 
            this.DogDig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DogDig.DataPropertyName = "DogDig";
            this.DogDig.HeaderText = "חופר?";
            this.DogDig.Name = "DogDig";
            this.DogDig.Width = 44;
            // 
            // DogJump
            // 
            this.DogJump.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DogJump.DataPropertyName = "DogJump";
            this.DogJump.HeaderText = "קופץ?";
            this.DogJump.Name = "DogJump";
            this.DogJump.Width = 46;
            // 
            // Manager_Comments
            // 
            this.Manager_Comments.HeaderText = "הערות מנהל";
            this.Manager_Comments.Name = "Manager_Comments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 751);
            this.Controls.Add(this.dataGridViewDogs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridViewDogs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewLinkColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn useraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhones;
        private System.Windows.Forms.DataGridViewButtonColumn UserDogs;
        private System.Windows.Forms.DataGridViewButtonColumn ReservationsNumber;
        private System.Windows.Forms.DataGridViewButtonColumn CreateOrder;
        private System.Windows.Forms.DataGridView dataGridViewDogs;
        private System.Windows.Forms.BindingSource bindingSourceDogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogShvav;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogGender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogNeuter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogRabiesVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogFriendlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogDig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogJump;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Comments;
    }
}

