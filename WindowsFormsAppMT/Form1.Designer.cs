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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceDogs = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxFindUser = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.useraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysSumForDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptMessages = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogsWatch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReservationsNumber = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CreateOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Vet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UserComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDog = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateDtails = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserFirstName,
            this.User,
            this.UserLastName,
            this.UserEmail,
            this.useraddress,
            this.UserPhones,
            this.DaysSumForDiscount,
            this.AcceptMessages,
            this.DogsWatch,
            this.ReservationsNumber,
            this.CreateOrder,
            this.Vet,
            this.UserComments,
            this.AddDog,
            this.UpdateDtails});
            this.dataGridView1.Location = new System.Drawing.Point(-12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 725);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSourceDogs;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1370, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelError.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelError.Location = new System.Drawing.Point(89, 82);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 5;
            // 
            // comboBoxFindUser
            // 
            this.comboBoxFindUser.FormattingEnabled = true;
            this.comboBoxFindUser.Location = new System.Drawing.Point(1188, 108);
            this.comboBoxFindUser.Name = "comboBoxFindUser";
            this.comboBoxFindUser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFindUser.TabIndex = 6;
            this.comboBoxFindUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindUser_SelectedIndexChanged);
            this.comboBoxFindUser.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFindUser_SelectionChangeCommitted);
            this.comboBoxFindUser.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxFindUser_Format);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserFirstName";
            this.dataGridViewTextBoxColumn1.FillWeight = 45.57619F;
            this.dataGridViewTextBoxColumn1.HeaderText = "שם פרטי";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserLastName";
            this.dataGridViewTextBoxColumn3.FillWeight = 45.57619F;
            this.dataGridViewTextBoxColumn3.HeaderText = "שם משפחה";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "כתובת";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "טלפונים";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DaysSumForDiscount";
            this.dataGridViewTextBoxColumn6.HeaderText = "ימים צבורים";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 115;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "הערות";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // UserFirstName
            // 
            this.UserFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserFirstName.DataPropertyName = "UserFirstName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserFirstName.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserFirstName.FillWeight = 45.57619F;
            this.UserFirstName.Frozen = true;
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
            this.UserEmail.ReadOnly = true;
            this.UserEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UserEmail.Width = 56;
            // 
            // useraddress
            // 
            this.useraddress.HeaderText = "כתובת";
            this.useraddress.Name = "useraddress";
            this.useraddress.ReadOnly = true;
            this.useraddress.Width = 200;
            // 
            // UserPhones
            // 
            this.UserPhones.HeaderText = "טלפונים";
            this.UserPhones.Name = "UserPhones";
            this.UserPhones.ReadOnly = true;
            this.UserPhones.Width = 106;
            // 
            // DaysSumForDiscount
            // 
            this.DaysSumForDiscount.DataPropertyName = "DaysSumForDiscount";
            this.DaysSumForDiscount.HeaderText = "ימים צבורים";
            this.DaysSumForDiscount.Name = "DaysSumForDiscount";
            this.DaysSumForDiscount.ReadOnly = true;
            this.DaysSumForDiscount.Width = 50;
            // 
            // AcceptMessages
            // 
            this.AcceptMessages.DataPropertyName = "Acceptmessages";
            this.AcceptMessages.HeaderText = "מקבל הודעות?";
            this.AcceptMessages.Name = "AcceptMessages";
            this.AcceptMessages.ReadOnly = true;
            this.AcceptMessages.Width = 106;
            // 
            // DogsWatch
            // 
            this.DogsWatch.DataPropertyName = "DogsNumber";
            this.DogsWatch.HeaderText = "הכלבים";
            this.DogsWatch.Name = "DogsWatch";
            this.DogsWatch.ReadOnly = true;
            this.DogsWatch.Width = 50;
            // 
            // ReservationsNumber
            // 
            this.ReservationsNumber.DataPropertyName = "ReservationsNumber";
            this.ReservationsNumber.HeaderText = "הזמנות";
            this.ReservationsNumber.Name = "ReservationsNumber";
            this.ReservationsNumber.ReadOnly = true;
            this.ReservationsNumber.Width = 50;
            // 
            // CreateOrder
            // 
            this.CreateOrder.HeaderText = "צור הזמנה";
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.ReadOnly = true;
            this.CreateOrder.Width = 50;
            // 
            // Vet
            // 
            this.Vet.HeaderText = "וטרינר";
            this.Vet.Name = "Vet";
            this.Vet.Width = 50;
            // 
            // UserComments
            // 
            this.UserComments.DataPropertyName = "UserComments";
            this.UserComments.HeaderText = "הערות";
            this.UserComments.Name = "UserComments";
            this.UserComments.Width = 200;
            // 
            // AddDog
            // 
            this.AddDog.HeaderText = "הוסף כלב";
            this.AddDog.Name = "AddDog";
            this.AddDog.Width = 50;
            // 
            // UpdateDtails
            // 
            this.UpdateDtails.HeaderText = "עדכן";
            this.UpdateDtails.Name = "UpdateDtails";
            this.UpdateDtails.Text = "עדכן";
            this.UpdateDtails.ToolTipText = "עדכן";
            this.UpdateDtails.UseColumnTextForButtonValue = true;
            this.UpdateDtails.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.comboBoxFindUser);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.bindingNavigator1, 0);
            this.Controls.SetChildIndex(this.labelError, 0);
            this.Controls.SetChildIndex(this.comboBoxFindUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceDogs;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ComboBox comboBoxFindUser;
        private System.Windows.Forms.BindingSource bindingSource1 = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewLinkColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn useraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysSumForDiscount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AcceptMessages;
        private System.Windows.Forms.DataGridViewButtonColumn DogsWatch;
        private System.Windows.Forms.DataGridViewButtonColumn ReservationsNumber;
        private System.Windows.Forms.DataGridViewButtonColumn CreateOrder;
        private System.Windows.Forms.DataGridViewButtonColumn Vet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserComments;
        private System.Windows.Forms.DataGridViewButtonColumn AddDog;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateDtails;
    }
}

