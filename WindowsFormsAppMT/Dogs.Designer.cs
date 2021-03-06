﻿namespace WindowsFormsAppMT
{
    partial class Dogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dogs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.DogNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.DogComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogShvav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogNeuter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogRabiesVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogFriendlyWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogDig = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogJump = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ManagerComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSourceDogs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogNumber,
            this.DogImageUrl,
            this.DogName,
            this.DogImage,
            this.DogComments,
            this.DogShvav,
            this.DogType,
            this.DogGender,
            this.DogNeuter,
            this.DogRabiesVaccine,
            this.DogBirthDate,
            this.DogFriendlyWith,
            this.DogDig,
            this.DogJump,
            this.ManagerComments,
            this.Delete});
            this.dataGridViewDogs.Location = new System.Drawing.Point(-12, 214);
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewDogs.Size = new System.Drawing.Size(1370, 224);
            this.dataGridViewDogs.TabIndex = 4;
            this.dataGridViewDogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellContentClick);
            this.dataGridViewDogs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDogs_CellMouseDoubleClick);
            this.dataGridViewDogs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellValueChanged);
            this.dataGridViewDogs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDogs_DataBindingComplete);
            this.dataGridViewDogs.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewDogs_DefaultValuesNeeded);
            // 
            // DogNumber
            // 
            this.DogNumber.DataPropertyName = "DogNumber";
            this.DogNumber.HeaderText = "Column1";
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Visible = false;
            // 
            // DogImageUrl
            // 
            this.DogImageUrl.DataPropertyName = "DogImage";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.DogImageUrl.DefaultCellStyle = dataGridViewCellStyle1;
            this.DogImageUrl.HeaderText = "DogImageUrl";
            this.DogImageUrl.Name = "DogImageUrl";
            this.DogImageUrl.Visible = false;
            // 
            // DogName
            // 
            this.DogName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DogName.DataPropertyName = "DogName";
            this.DogName.HeaderText = "שם כלב";
            this.DogName.Name = "DogName";
            this.DogName.Width = 72;
            // 
            // DogImage
            // 
            this.DogImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DogImage.DataPropertyName = "DogImage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DogImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.DogImage.HeaderText = "תמונה";
            this.DogImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DogImage.MinimumWidth = 100;
            this.DogImage.Name = "DogImage";
            this.DogImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DogComments
            // 
            this.DogComments.DataPropertyName = "DogComments";
            this.DogComments.HeaderText = "הערות";
            this.DogComments.Name = "DogComments";
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
            this.DogBirthDate.DataPropertyName = "DogAge";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.DogBirthDate.DefaultCellStyle = dataGridViewCellStyle3;
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
            // ManagerComments
            // 
            this.ManagerComments.DataPropertyName = "ManagerComments";
            this.ManagerComments.HeaderText = "הערות מנהל";
            this.ManagerComments.Name = "ManagerComments";
            this.ManagerComments.Width = 250;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "בטל";
            this.Delete.Image = global::WindowsFormsAppMT.Properties.Resources.if_Delete_MT;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 50;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(718, 119);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "הכלבים של";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ImageIndex = 0;
            this.buttonUpdate.ImageList = this.imageList1;
            this.buttonUpdate.Location = new System.Drawing.Point(29, 104);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(127, 51);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Update.jpg");
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "בטל";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // Dogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewDogs);
            this.Name = "Dogs";
            this.Controls.SetChildIndex(this.dataGridViewDogs, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDogs;
        private System.Windows.Forms.BindingSource bindingSourceDogs;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogImageUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogName;
        private System.Windows.Forms.DataGridViewImageColumn DogImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogShvav;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogGender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogNeuter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogRabiesVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogFriendlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogDig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogJump;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerComments;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ImageList imageList1;
    }
}
