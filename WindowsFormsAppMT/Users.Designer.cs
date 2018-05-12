namespace WindowsFormsAppMT
{
    partial class Users
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
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.buttonIshur = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserEmail,
            this.Choose});
            this.dataGridViewContacts.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.Size = new System.Drawing.Size(293, 150);
            this.dataGridViewContacts.TabIndex = 0;
            this.dataGridViewContacts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContacts_CellValueChanged);
            this.dataGridViewContacts.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewContacts_CurrentCellDirtyStateChanged);
            // 
            // buttonIshur
            // 
            this.buttonIshur.Location = new System.Drawing.Point(230, 12);
            this.buttonIshur.Name = "buttonIshur";
            this.buttonIshur.Size = new System.Drawing.Size(75, 23);
            this.buttonIshur.TabIndex = 1;
            this.buttonIshur.Text = "אשר";
            this.buttonIshur.UseVisualStyleBackColor = true;
            this.buttonIshur.Click += new System.EventHandler(this.buttonIshur_Click);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "שם";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.DataPropertyName = "UserEmail";
            this.UserEmail.HeaderText = "מייל";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // Choose
            // 
            this.Choose.HeaderText = "בחר";
            this.Choose.Name = "Choose";
            this.Choose.Width = 50;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 398);
            this.Controls.Add(this.buttonIshur);
            this.Controls.Add(this.dataGridViewContacts);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.Button buttonIshur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose;
    }
}