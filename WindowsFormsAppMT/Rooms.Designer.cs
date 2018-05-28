﻿using System;

namespace WindowsFormsAppMT
{
    partial class Rooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewDog = new System.Windows.Forms.DataGridView();
            this.DogNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.VetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VetTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDateInPension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.buttonChooseDates = new System.Windows.Forms.Button();
            this.bindingSourceDogs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(49, 39);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewDog
            // 
            this.dataGridViewDog.AllowUserToAddRows = false;
            this.dataGridViewDog.AllowUserToDeleteRows = false;
            this.dataGridViewDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogNumber,
            this.DogName,
            this.DogImageUrl,
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
            this.VetName,
            this.VetTel,
            this.OrderNumber,
            this.Owner,
            this.ToDateInPension});
            this.dataGridViewDog.Location = new System.Drawing.Point(5, 78);
            this.dataGridViewDog.Name = "dataGridViewDog";
            this.dataGridViewDog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewDog.Size = new System.Drawing.Size(1743, 71);
            this.dataGridViewDog.TabIndex = 10;
            this.dataGridViewDog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDog_CellContentClick);
            // 
            // DogNumber
            // 
            this.DogNumber.DataPropertyName = "DogNumber";
            this.DogNumber.Frozen = true;
            this.DogNumber.HeaderText = "Column1";
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Visible = false;
            // 
            // DogName
            // 
            this.DogName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DogName.DataPropertyName = "DogName";
            this.DogName.Frozen = true;
            this.DogName.HeaderText = "שם כלב";
            this.DogName.Name = "DogName";
            this.DogName.Width = 72;
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
            // DogImage
            // 
            this.DogImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DogImage.DataPropertyName = "DogImage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
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
            this.DogType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.ManagerComments.Width = 300;
            // 
            // VetName
            // 
            this.VetName.DataPropertyName = "VeterinarName";
            this.VetName.HeaderText = "שם וטרינר";
            this.VetName.Name = "VetName";
            this.VetName.ReadOnly = true;
            // 
            // VetTel
            // 
            this.VetTel.DataPropertyName = "VeterinarPhone1";
            this.VetTel.HeaderText = "טלפון וטרינר";
            this.VetTel.Name = "VetTel";
            this.VetTel.ReadOnly = true;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "מספר הזמנה";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "Owner";
            this.Owner.HeaderText = "...אני של";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            // 
            // ToDateInPension
            // 
            this.ToDateInPension.DataPropertyName = "ToDateInPension";
            this.ToDateInPension.HeaderText = "...אני פה עד";
            this.ToDateInPension.Name = "ToDateInPension";
            this.ToDateInPension.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1061, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(672, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Visible = false;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFrom.Location = new System.Drawing.Point(1277, 39);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(47, 18);
            this.labelFrom.TabIndex = 13;
            this.labelFrom.Text = "תאריך";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTo.Location = new System.Drawing.Point(888, 37);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(68, 18);
            this.labelTo.TabIndex = 14;
            this.labelTo.Text = "עד תאריך";
            this.labelTo.Visible = false;
            // 
            // buttonChooseDates
            // 
            this.buttonChooseDates.Location = new System.Drawing.Point(951, 34);
            this.buttonChooseDates.Name = "buttonChooseDates";
            this.buttonChooseDates.Size = new System.Drawing.Size(104, 23);
            this.buttonChooseDates.TabIndex = 16;
            this.buttonChooseDates.Text = "בחר";
            this.buttonChooseDates.UseVisualStyleBackColor = true;
            this.buttonChooseDates.Click += new System.EventHandler(this.buttonChooseDates_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DogNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DogImage";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "DogImageUrl";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DogName";
            this.dataGridViewTextBoxColumn3.HeaderText = "שם כלב";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DogComments";
            this.dataGridViewTextBoxColumn4.HeaderText = "הערות";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DogShvav";
            this.dataGridViewTextBoxColumn5.HeaderText = "שבב";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DogType";
            this.dataGridViewTextBoxColumn6.HeaderText = "גזע";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DogGender";
            this.dataGridViewTextBoxColumn7.HeaderText = "מין";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DogRabiesVaccine";
            this.dataGridViewTextBoxColumn8.HeaderText = "תאריך חיסון";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DogAge";
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn9.HeaderText = "גיל";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DogFriendlyWith";
            this.dataGridViewTextBoxColumn10.HeaderText = "מסתדר עם";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ManagerComments";
            this.dataGridViewTextBoxColumn11.HeaderText = "הערות מנהל";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 300;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "VeterinarName";
            this.dataGridViewTextBoxColumn12.HeaderText = "שם וטרינר";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "VeterinarPhone1";
            this.dataGridViewTextBoxColumn13.HeaderText = "טלפון וטרינר";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn14.HeaderText = "מספר הזמנה";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn15.HeaderText = "...אני של";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ToDateInPension";
            this.dataGridViewTextBoxColumn16.HeaderText = "...אני פה עד";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1469, 755);
            this.Controls.Add(this.buttonChooseDates);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewDog);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "Rooms";
            this.RightToLeftLayout = true;
            this.Resize += new System.EventHandler(this.Rooms_Resize);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.Controls.SetChildIndex(this.dataGridViewDog, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.labelFrom, 0);
            this.Controls.SetChildIndex(this.labelTo, 0);
            this.Controls.SetChildIndex(this.buttonChooseDates, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewDog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button buttonChooseDates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource bindingSourceDogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogImageUrl;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn VetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VetTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDateInPension;
    }
}
