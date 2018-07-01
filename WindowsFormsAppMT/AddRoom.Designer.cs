namespace WindowsFormsAppMT
{
    partial class AddRoom
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
            this.textBoxRoomcomments = new System.Windows.Forms.TextBox();
            this.labelUserComments = new System.Windows.Forms.Label();
            this.labelRoomCapacity = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomDescription = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRoomcomments
            // 
            this.textBoxRoomcomments.Location = new System.Drawing.Point(207, 248);
            this.textBoxRoomcomments.Multiline = true;
            this.textBoxRoomcomments.Name = "textBoxRoomcomments";
            this.textBoxRoomcomments.Size = new System.Drawing.Size(121, 108);
            this.textBoxRoomcomments.TabIndex = 28;
            // 
            // labelUserComments
            // 
            this.labelUserComments.AutoSize = true;
            this.labelUserComments.Location = new System.Drawing.Point(364, 266);
            this.labelUserComments.Name = "labelUserComments";
            this.labelUserComments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUserComments.Size = new System.Drawing.Size(39, 13);
            this.labelUserComments.TabIndex = 25;
            this.labelUserComments.Text = "הערות";
            // 
            // labelRoomCapacity
            // 
            this.labelRoomCapacity.AutoSize = true;
            this.labelRoomCapacity.Location = new System.Drawing.Point(364, 85);
            this.labelRoomCapacity.Name = "labelRoomCapacity";
            this.labelRoomCapacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelRoomCapacity.Size = new System.Drawing.Size(118, 13);
            this.labelRoomCapacity.TabIndex = 24;
            this.labelRoomCapacity.Text = "מספר כלבים מקסימלי";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(207, 82);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "הוסף חדר";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 134);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "תיאור החדר";
            // 
            // textBoxRoomDescription
            // 
            this.textBoxRoomDescription.Location = new System.Drawing.Point(206, 120);
            this.textBoxRoomDescription.Multiline = true;
            this.textBoxRoomDescription.Name = "textBoxRoomDescription";
            this.textBoxRoomDescription.Size = new System.Drawing.Size(121, 108);
            this.textBoxRoomDescription.TabIndex = 32;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(612, 507);
            this.Controls.Add(this.textBoxRoomDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxRoomcomments);
            this.Controls.Add(this.labelUserComments);
            this.Controls.Add(this.labelRoomCapacity);
            this.Name = "AddRoom";
            this.Controls.SetChildIndex(this.labelRoomCapacity, 0);
            this.Controls.SetChildIndex(this.labelUserComments, 0);
            this.Controls.SetChildIndex(this.textBoxRoomcomments, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxRoomDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRoomcomments;
        private System.Windows.Forms.Label labelUserComments;
        private System.Windows.Forms.Label labelRoomCapacity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomDescription;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
