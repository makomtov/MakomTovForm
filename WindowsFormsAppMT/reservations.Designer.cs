using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new WindowsFormsAppMT.CalendarColumn();
            this.ShiftNumberFrom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ToDate = new WindowsFormsAppMT.CalendarColumn();
            this.ShiftNumberTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderconfirmationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogsInOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewDogsInOrder = new System.Windows.Forms.DataGridView();
            this.DogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogNeuter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogRabiesVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogDig = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogJump = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogFriendlyWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogTraining = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HomeFood = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderDogs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bindingSourceStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewStatus = new System.Windows.Forms.ListView();
            this.StatusName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxChooseDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelOR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogsInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(716, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "label1";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.OrderNumber,
            this.OrderDate,
            this.FromDate,
            this.ShiftNumberFrom,
            this.ToDate,
            this.ShiftNumberTo,
            this.OrderPrice,
            this.Discount,
            this.OrderconfirmationNumber,
            this.ManagerComments,
            this.DogsInOrder,
            this.OrderStatus});
            this.dataGridViewOrders.Location = new System.Drawing.Point(33, 476);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1168, 331);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick_1);
            this.dataGridViewOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellEnter);
            this.dataGridViewOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_CellMouseClick);
            this.dataGridViewOrders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_CellMouseDoubleClick);
            this.dataGridViewOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellValueChanged);
            this.dataGridViewOrders.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewOrders_CurrentCellDirtyStateChanged);
            this.dataGridViewOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewOrders_DataBindingComplete);
            this.dataGridViewOrders.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridViewOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_RowEnter);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "שם המזמין";
            this.UserName.Name = "UserName";
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.FillWeight = 147.2626F;
            this.OrderNumber.HeaderText = "מספר הזמנה";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.OrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDate.FillWeight = 96.33428F;
            this.OrderDate.HeaderText = "תאריך הזמנה";
            this.OrderDate.Name = "OrderDate";
            // 
            // FromDate
            // 
            this.FromDate.DataPropertyName = "FromDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "1";
            this.FromDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.FromDate.HeaderText = "מתאריך";
            this.FromDate.Name = "FromDate";
            this.FromDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FromDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ShiftNumberFrom
            // 
            dataGridViewCellStyle3.NullValue = "1";
            this.ShiftNumberFrom.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShiftNumberFrom.HeaderText = "משמרת הגעה";
            this.ShiftNumberFrom.Name = "ShiftNumberFrom";
            this.ShiftNumberFrom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShiftNumberFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ToDate
            // 
            this.ToDate.DataPropertyName = "ToDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "1";
            this.ToDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ToDate.HeaderText = "עד תאריך";
            this.ToDate.Name = "ToDate";
            this.ToDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ToDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ShiftNumberTo
            // 
            dataGridViewCellStyle5.NullValue = "1";
            this.ShiftNumberTo.DefaultCellStyle = dataGridViewCellStyle5;
            this.ShiftNumberTo.HeaderText = "משמרת הוצאה";
            this.ShiftNumberTo.Name = "ShiftNumberTo";
            this.ShiftNumberTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShiftNumberTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OrderPrice
            // 
            this.OrderPrice.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.OrderPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderPrice.FillWeight = 96.33428F;
            this.OrderPrice.HeaderText = "מחיר";
            this.OrderPrice.Name = "OrderPrice";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            this.Discount.DefaultCellStyle = dataGridViewCellStyle7;
            this.Discount.HeaderText = "הנחה מיוחדת";
            this.Discount.Name = "Discount";
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
            this.DogsInOrder.Text = "צפה";
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
            this.buttonUpdate.Location = new System.Drawing.Point(1271, 457);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewDogsInOrder
            // 
            this.dataGridViewDogsInOrder.AllowUserToAddRows = false;
            this.dataGridViewDogsInOrder.AllowUserToDeleteRows = false;
            this.dataGridViewDogsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogsInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DogName,
            this.DogType,
            this.DogNeuter,
            this.DogRabiesVaccine,
            this.DogDig,
            this.DogJump,
            this.DogFriendlyWith,
            this.DogTraining,
            this.HomeFood,
            this.OrderDogs,
            this.OrderNum,
            this.DogNumber});
            this.dataGridViewDogsInOrder.Location = new System.Drawing.Point(47, 288);
            this.dataGridViewDogsInOrder.Name = "dataGridViewDogsInOrder";
            this.dataGridViewDogsInOrder.Size = new System.Drawing.Size(1154, 150);
            this.dataGridViewDogsInOrder.TabIndex = 3;
            this.dataGridViewDogsInOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogsInOrder_CellClick);
            this.dataGridViewDogsInOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogsInOrder_CellContentClick);
            this.dataGridViewDogsInOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDogsInOrder_CellFormatting);
            this.dataGridViewDogsInOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogsInOrder_CellValueChanged);
            this.dataGridViewDogsInOrder.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDogsInOrder_CurrentCellDirtyStateChanged);
            this.dataGridViewDogsInOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDogsInOrder_DataBindingComplete);
            // 
            // DogName
            // 
            this.DogName.DataPropertyName = "DogName";
            this.DogName.HeaderText = "שם כלב";
            this.DogName.Name = "DogName";
            this.DogName.ReadOnly = true;
            // 
            // DogType
            // 
            this.DogType.DataPropertyName = "DogType";
            this.DogType.HeaderText = "סוג";
            this.DogType.Name = "DogType";
            this.DogType.ReadOnly = true;
            // 
            // DogNeuter
            // 
            this.DogNeuter.DataPropertyName = "DogNeuter";
            this.DogNeuter.HeaderText = "מסורס?";
            this.DogNeuter.Name = "DogNeuter";
            this.DogNeuter.ReadOnly = true;
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
            this.DogDig.ReadOnly = true;
            // 
            // DogJump
            // 
            this.DogJump.DataPropertyName = "DogJump";
            this.DogJump.HeaderText = "קופץ?";
            this.DogJump.Name = "DogJump";
            this.DogJump.ReadOnly = true;
            // 
            // DogFriendlyWith
            // 
            this.DogFriendlyWith.DataPropertyName = "DogFriendlyWith";
            this.DogFriendlyWith.HeaderText = "מסתדר עם";
            this.DogFriendlyWith.Name = "DogFriendlyWith";
            this.DogFriendlyWith.ReadOnly = true;
            // 
            // DogTraining
            // 
            this.DogTraining.DataPropertyName = "DogTraining";
            this.DogTraining.HeaderText = "אילוף?";
            this.DogTraining.Name = "DogTraining";
            // 
            // HomeFood
            // 
            this.HomeFood.DataPropertyName = "HomeFood";
            this.HomeFood.HeaderText = "אוכל בית?";
            this.HomeFood.Name = "HomeFood";
            // 
            // OrderDogs
            // 
            this.OrderDogs.DataPropertyName = "OrderDogs";
            this.OrderDogs.HeaderText = "בהזמנה?";
            this.OrderDogs.Name = "OrderDogs";
            // 
            // OrderNum
            // 
            this.OrderNum.DataPropertyName = "OrderNum";
            this.OrderNum.HeaderText = "מספר הזמנה";
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.ReadOnly = true;
            // 
            // DogNumber
            // 
            this.DogNumber.DataPropertyName = "DogNumber";
            this.DogNumber.HeaderText = "Column1";
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Visible = false;
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
            this.dateTimePickerFrom.CustomFormat = "dd - MM - yyyy , dddd ";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(336, 104);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 6;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "מתאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "עד תאריך";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd - MM - yyyy , dddd ";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(581, 104);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 9;
            this.dateTimePickerTo.Value = new System.DateTime(2019, 4, 10, 16, 10, 49, 734);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(813, 105);
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
            this.listViewStatus.Location = new System.Drawing.Point(33, 68);
            this.listViewStatus.Name = "listViewStatus";
            this.listViewStatus.RightToLeftLayout = true;
            this.listViewStatus.Size = new System.Drawing.Size(150, 197);
            this.listViewStatus.TabIndex = 12;
            this.listViewStatus.UseCompatibleStateImageBehavior = false;
            this.listViewStatus.View = System.Windows.Forms.View.Details;
            this.listViewStatus.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewStatus_ItemChecked);
            // 
            // StatusName
            // 
            this.StatusName.Width = 141;
            // 
            // comboBoxChooseDate
            // 
            this.comboBoxChooseDate.FormattingEnabled = true;
            this.comboBoxChooseDate.Items.AddRange(new object[] {
            "תאריך הזמנה",
            "תאריך הגעה",
            "תאריך עזיבה",
            "ללא תאריך"});
            this.comboBoxChooseDate.Location = new System.Drawing.Point(198, 103);
            this.comboBoxChooseDate.Name = "comboBoxChooseDate";
            this.comboBoxChooseDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseDate.TabIndex = 14;
            this.comboBoxChooseDate.Text = "ללא תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "מספר הזמנה";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(336, 177);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderNumber.TabIndex = 15;
            // 
            // labelOR
            // 
            this.labelOR.AutoSize = true;
            this.labelOR.Location = new System.Drawing.Point(345, 143);
            this.labelOR.Name = "labelOR";
            this.labelOR.Size = new System.Drawing.Size(20, 13);
            this.labelOR.TabIndex = 17;
            this.labelOR.Text = "או";
            // 
            // reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 728);
            this.Controls.Add(this.labelOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.comboBoxChooseDate);
            this.Controls.Add(this.listViewStatus);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dataGridViewDogsInOrder);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reservations";
            this.RightToLeftLayout = true;
            this.Text = "הזמנות";
            this.Load += new System.EventHandler(this.reservations_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.labelUser, 0);
            this.Controls.SetChildIndex(this.dataGridViewOrders, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.Controls.SetChildIndex(this.dataGridViewDogsInOrder, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFrom, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePickerTo, 0);
            this.Controls.SetChildIndex(this.buttonSearch, 0);
            this.Controls.SetChildIndex(this.listViewStatus, 0);
            this.Controls.SetChildIndex(this.comboBoxChooseDate, 0);
            this.Controls.SetChildIndex(this.textBoxOrderNumber, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelOR, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogsInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewDogsInOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSourceStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listViewStatus;
        private System.Windows.Forms.ColumnHeader StatusName;
        private ComboBox comboBoxChooseDate;
        private DataGridViewTextBoxColumn DogName;
        private DataGridViewTextBoxColumn DogType;
        private DataGridViewCheckBoxColumn DogNeuter;
        private DataGridViewTextBoxColumn DogRabiesVaccine;
        private DataGridViewCheckBoxColumn DogDig;
        private DataGridViewCheckBoxColumn DogJump;
        private DataGridViewTextBoxColumn DogFriendlyWith;
        private DataGridViewCheckBoxColumn DogTraining;
        private DataGridViewCheckBoxColumn HomeFood;
        private DataGridViewCheckBoxColumn OrderDogs;
        private DataGridViewTextBoxColumn OrderNum;
        private DataGridViewTextBoxColumn DogNumber;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn OrderDate;
        private CalendarColumn FromDate;
        private DataGridViewComboBoxColumn ShiftNumberFrom;
        private CalendarColumn ToDate;
        private DataGridViewComboBoxColumn ShiftNumberTo;
        private DataGridViewTextBoxColumn OrderPrice;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn OrderconfirmationNumber;
        private DataGridViewTextBoxColumn ManagerComments;
        private DataGridViewButtonColumn DogsInOrder;
        private DataGridViewComboBoxColumn OrderStatus;
        private Label label3;
        private TextBox textBoxOrderNumber;
        private Label labelOR;
    }
}