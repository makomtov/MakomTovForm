namespace WindowsFormsAppMT
{
    partial class CreateOrder
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.comboBoxArrival = new System.Windows.Forms.ComboBox();
            this.labelExitTime = new System.Windows.Forms.Label();
            this.comboBoxExit = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogsInOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
           
            this.dateTimePickerFrom.Location = new System.Drawing.Point(508, 106);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(661, 68);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(47, 13);
            this.labelFrom.TabIndex = 4;
            this.labelFrom.Text = "מתאריך";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(398, 68);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(57, 13);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "עד תאריך";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(275, 106);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 6;
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Location = new System.Drawing.Point(635, 149);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(73, 13);
            this.labelArrivalTime.TabIndex = 7;
            this.labelArrivalTime.Text = "משמרת הגעה";
            // 
            // comboBoxArrival
            // 
            this.comboBoxArrival.DisplayMember = "1";
            this.comboBoxArrival.FormattingEnabled = true;
            this.comboBoxArrival.Location = new System.Drawing.Point(587, 184);
            this.comboBoxArrival.Name = "comboBoxArrival";
            this.comboBoxArrival.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArrival.TabIndex = 8;
            this.comboBoxArrival.ValueMember = "1";
            // 
            // labelExitTime
            // 
            this.labelExitTime.AutoSize = true;
            this.labelExitTime.Location = new System.Drawing.Point(398, 149);
            this.labelExitTime.Name = "labelExitTime";
            this.labelExitTime.Size = new System.Drawing.Size(77, 13);
            this.labelExitTime.TabIndex = 9;
            this.labelExitTime.Text = "משמרת עזיבה";
            // 
            // comboBoxExit
            // 
            this.comboBoxExit.FormattingEnabled = true;
            this.comboBoxExit.Location = new System.Drawing.Point(363, 184);
            this.comboBoxExit.Name = "comboBoxExit";
            this.comboBoxExit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExit.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(480, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 25);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "הזמנה ל ";
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
            this.dataGridViewDogsInOrder.Location = new System.Drawing.Point(178, 273);
            this.dataGridViewDogsInOrder.Name = "dataGridViewDogsInOrder";
            this.dataGridViewDogsInOrder.Size = new System.Drawing.Size(1143, 150);
            this.dataGridViewDogsInOrder.TabIndex = 13;
            this.dataGridViewDogsInOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogsInOrder_CellValueChanged);
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
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(570, 542);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "צור הזמנה";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(385, 542);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 15;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1464, 726);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridViewDogsInOrder);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxExit);
            this.Controls.Add(this.labelExitTime);
            this.Controls.Add(this.comboBoxArrival);
            this.Controls.Add(this.labelArrivalTime);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "CreateOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Controls.SetChildIndex(this.dateTimePickerFrom, 0);
            this.Controls.SetChildIndex(this.labelFrom, 0);
            this.Controls.SetChildIndex(this.labelTo, 0);
            this.Controls.SetChildIndex(this.dateTimePickerTo, 0);
            this.Controls.SetChildIndex(this.labelArrivalTime, 0);
            this.Controls.SetChildIndex(this.comboBoxArrival, 0);
            this.Controls.SetChildIndex(this.labelExitTime, 0);
            this.Controls.SetChildIndex(this.comboBoxExit, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.dataGridViewDogsInOrder, 0);
            this.Controls.SetChildIndex(this.buttonCreate, 0);
            this.Controls.SetChildIndex(this.labelError, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogsInOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelArrivalTime;
        private System.Windows.Forms.ComboBox comboBoxArrival;
        private System.Windows.Forms.Label labelExitTime;
        private System.Windows.Forms.ComboBox comboBoxExit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewDogsInOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogNeuter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogRabiesVaccine;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogDig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogJump;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogFriendlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DogTraining;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HomeFood;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderDogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogNumber;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelError;
    }
}
