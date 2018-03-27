namespace WindowsFormsAppMT
{
    partial class reservations
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
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderconfirmationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogsInOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewDogsInOrder = new System.Windows.Forms.DataGridView();
            this.DogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogNeuter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogRabiesVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogDig = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogJump = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogFriendlyWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogTraining = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bindingSourceStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewStatus = new System.Windows.Forms.ListView();
            this.StatusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogsInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(679, 153);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.OrderNumber,
            this.OrderDate,
            this.OrderPrice,
            this.OrderconfirmationNumber,
            this.ManagerComments,
            this.DogsInOrder,
            this.OrderStatus});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(31, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(699, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "שם המזמין";
            this.UserName.Name = "UserName";
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.FillWeight = 147.2626F;
            this.OrderNumber.HeaderText = "מספר הזמנה";
            this.OrderNumber.Name = "OrderNumber";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.FillWeight = 96.33428F;
            this.OrderDate.HeaderText = "תאריך הזמנה";
            this.OrderDate.Name = "OrderDate";
            // 
            // OrderPrice
            // 
            this.OrderPrice.DataPropertyName = "Price";
            this.OrderPrice.FillWeight = 96.33428F;
            this.OrderPrice.HeaderText = "מחיר";
            this.OrderPrice.Name = "OrderPrice";
            // 
            // OrderconfirmationNumber
            // 
            this.OrderconfirmationNumber.DataPropertyName = "OrderconfirmationNumber";
            this.OrderconfirmationNumber.FillWeight = 96.33428F;
            this.OrderconfirmationNumber.HeaderText = "מספר אישור תשלום";
            this.OrderconfirmationNumber.Name = "OrderconfirmationNumber";
            // 
            // ManagerComments
            // 
            this.ManagerComments.DataPropertyName = "ManagerComments";
            this.ManagerComments.HeaderText = "הערות";
            this.ManagerComments.Name = "ManagerComments";
            // 
            // DogsInOrder
            // 
            this.DogsInOrder.FillWeight = 71.06599F;
            this.DogsInOrder.HeaderText = "צפה בכלבים";
            this.DogsInOrder.Name = "DogsInOrder";
            this.DogsInOrder.Text = "+";
            // 
            // OrderStatus
            // 
            this.OrderStatus.FillWeight = 96.33428F;
            this.OrderStatus.HeaderText = "מצב הזמנה";
            this.OrderStatus.MaxDropDownItems = 10;
            this.OrderStatus.Name = "OrderStatus";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1098, 571);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewDogsInOrder
            // 
            this.dataGridViewDogsInOrder.AutoGenerateColumns = false;
            this.dataGridViewDogsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogsInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogName,
            this.DogType,
            this.FromDate,
            this.ToDate,
            this.DogNeuter,
            this.DogRabiesVaccine,
            this.DogDig,
            this.DogJump,
            this.DogFriendlyWith,
            this.DogTraining});
            this.dataGridViewDogsInOrder.DataSource = this.bindingSource2;
            this.dataGridViewDogsInOrder.Location = new System.Drawing.Point(728, 365);
            this.dataGridViewDogsInOrder.Name = "dataGridViewDogsInOrder";
            this.dataGridViewDogsInOrder.Size = new System.Drawing.Size(1043, 150);
            this.dataGridViewDogsInOrder.TabIndex = 3;
            this.dataGridViewDogsInOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDogsInOrder_CellFormatting);
            this.dataGridViewDogsInOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDogsInOrder_DataBindingComplete);
            // 
            // DogName
            // 
            this.DogName.DataPropertyName = "DogName";
            this.DogName.HeaderText = "שם כלב";
            this.DogName.Name = "DogName";
            // 
            // DogType
            // 
            this.DogType.DataPropertyName = "DogType";
            this.DogType.HeaderText = "סוג";
            this.DogType.Name = "DogType";
            // 
            // FromDate
            // 
            this.FromDate.DataPropertyName = "FromDate";
            this.FromDate.HeaderText = "מתאריך";
            this.FromDate.Name = "FromDate";
            // 
            // ToDate
            // 
            this.ToDate.DataPropertyName = "ToDate";
            this.ToDate.HeaderText = "עד תאריך";
            this.ToDate.Name = "ToDate";
            // 
            // DogNeuter
            // 
            this.DogNeuter.DataPropertyName = "DogNeuter";
            this.DogNeuter.HeaderText = "מסורס?";
            this.DogNeuter.Name = "DogNeuter";
            // 
            // DogRabiesVaccine
            // 
            this.DogRabiesVaccine.DataPropertyName = "DogRabiesVaccine";
            this.DogRabiesVaccine.HeaderText = "תאריך חיסון כלבת";
            this.DogRabiesVaccine.Name = "DogRabiesVaccine";
            // 
            // DogDig
            // 
            this.DogDig.DataPropertyName = "DogDig";
            this.DogDig.HeaderText = "חופר?";
            this.DogDig.Name = "DogDig";
            // 
            // DogJump
            // 
            this.DogJump.DataPropertyName = "DogJump";
            this.DogJump.HeaderText = "קופץ?";
            this.DogJump.Name = "DogJump";
            // 
            // DogFriendlyWith
            // 
            this.DogFriendlyWith.DataPropertyName = "DogFriendlyWith";
            this.DogFriendlyWith.HeaderText = "מסתדר עם";
            this.DogFriendlyWith.Name = "DogFriendlyWith";
            // 
            // DogTraining
            // 
            this.DogTraining.DataPropertyName = "DogTraining";
            this.DogTraining.HeaderText = "אילוף?";
            this.DogTraining.Name = "DogTraining";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1483, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(262, 185);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "מתאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "עד תאריך";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(568, 185);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(779, 185);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "חפש";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listViewStatus
            // 
            this.listViewStatus.CheckBoxes = true;
            this.listViewStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StatusName});
            this.listViewStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStatus.Location = new System.Drawing.Point(12, 153);
            this.listViewStatus.Name = "listViewStatus";
            this.listViewStatus.RightToLeftLayout = true;
            this.listViewStatus.Size = new System.Drawing.Size(150, 197);
            this.listViewStatus.TabIndex = 12;
            this.listViewStatus.UseCompatibleStateImageBehavior = false;
            this.listViewStatus.View = System.Windows.Forms.View.Details;
            // 
            // StatusName
            // 
            this.StatusName.Width = 141;
            // 
            // reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 728);
            this.Controls.Add(this.listViewStatus);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dataGridViewDogsInOrder);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reservations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הזמנות";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reservations_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.labelUser, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.Controls.SetChildIndex(this.dataGridViewDogsInOrder, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFrom, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePickerTo, 0);
            this.Controls.SetChildIndex(this.buttonSearch, 0);
            this.Controls.SetChildIndex(this.listViewStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogsInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewDogsInOrder;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSourceStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogNeuter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogRabiesVaccine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogDig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogJump;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogFriendlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogTraining;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderconfirmationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerComments;
        private System.Windows.Forms.DataGridViewButtonColumn DogsInOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrderStatus;
        private System.Windows.Forms.ListView listViewStatus;
        private System.Windows.Forms.ColumnHeader StatusName;
    }
}