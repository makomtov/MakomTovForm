namespace WindowsFormsAppMT
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWatchOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWatchUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמשתמשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ביטולמשתמשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ניהולכלביםבפנסיוןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReservations,
            this.ToolStripMenuItemUsers,
            this.ניהולכלביםבפנסיוןToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ToolStripMenuItemUsers;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItemReservations
            // 
            this.toolStripMenuItemReservations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemWatchOrders});
            this.toolStripMenuItemReservations.Name = "toolStripMenuItemReservations";
            this.toolStripMenuItemReservations.Size = new System.Drawing.Size(85, 20);
            this.toolStripMenuItemReservations.Text = "ניהול הזמנות";
            // 
            // ToolStripMenuItemWatchOrders
            // 
            this.ToolStripMenuItemWatchOrders.Name = "ToolStripMenuItemWatchOrders";
            this.ToolStripMenuItemWatchOrders.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemWatchOrders.Text = "צפיה בכל ההזמנות";
            this.ToolStripMenuItemWatchOrders.Click += new System.EventHandler(this.ToolStripMenuItemWatchOrders_Click);
            // 
            // ToolStripMenuItemUsers
            // 
            this.ToolStripMenuItemUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemWatchUsers,
            this.הוספתמשתמשToolStripMenuItem,
            this.ביטולמשתמשToolStripMenuItem});
            this.ToolStripMenuItemUsers.Name = "ToolStripMenuItemUsers";
            this.ToolStripMenuItemUsers.Size = new System.Drawing.Size(102, 20);
            this.ToolStripMenuItemUsers.Text = "ניהול משתמשים";
            this.ToolStripMenuItemUsers.Click += new System.EventHandler(this.ToolStripMenuItemUsers_Click);
            // 
            // ToolStripMenuItemWatchUsers
            // 
            this.ToolStripMenuItemWatchUsers.Name = "ToolStripMenuItemWatchUsers";
            this.ToolStripMenuItemWatchUsers.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItemWatchUsers.Text = "צפיה במשתמשים";
            this.ToolStripMenuItemWatchUsers.Click += new System.EventHandler(this.ToolStripMenuItemWatchUsers_Click);
            // 
            // הוספתמשתמשToolStripMenuItem
            // 
            this.הוספתמשתמשToolStripMenuItem.Name = "הוספתמשתמשToolStripMenuItem";
            this.הוספתמשתמשToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.הוספתמשתמשToolStripMenuItem.Text = "הוספת משתמש";
            this.הוספתמשתמשToolStripMenuItem.Click += new System.EventHandler(this.הוספתמשתמשToolStripMenuItem_Click);
            // 
            // ביטולמשתמשToolStripMenuItem
            // 
            this.ביטולמשתמשToolStripMenuItem.Name = "ביטולמשתמשToolStripMenuItem";
            this.ביטולמשתמשToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ביטולמשתמשToolStripMenuItem.Text = "ביטול משתמש";
            // 
            // ניהולכלביםבפנסיוןToolStripMenuItem
            // 
            this.ניהולכלביםבפנסיוןToolStripMenuItem.Name = "ניהולכלביםבפנסיוןToolStripMenuItem";
            this.ניהולכלביםבפנסיוןToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ניהולכלביםבפנסיוןToolStripMenuItem.Text = "ניהול כלבים בפנסיון";
            this.ניהולכלביםבפנסיוןToolStripMenuItem.Click += new System.EventHandler(this.ניהולכלביםבפנסיוןToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 507);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReservations;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUsers;
       
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWatchOrders;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWatchUsers;
        private System.Windows.Forms.ToolStripMenuItem הוספתמשתמשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ביטולמשתמשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ניהולכלביםבפנסיוןToolStripMenuItem;
    }
}