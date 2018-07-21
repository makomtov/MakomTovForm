using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMT
{
    public partial class Menu : Form
    {
        string id;
        public Menu()
        {
            InitializeComponent();
          
        }
        public Menu(string child)
        {
            InitializeComponent();
            id = child;
           

        }
        private void ToolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            // This method creates a new ChildForm instance 
            // and attaches it to the MDI parent form.
           
                //ChildForm f = new ChildForm();
                //f.MdiParent = this;
                //f.Text = "Form - " + this.MdiChildren.Length.ToString();
                //f.Show();
            //}
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemWatchOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservations reservations = new reservations();
            reservations.Show();
        }

        private void ToolStripMenuItemWatchUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(LogIn.loginView);
            f1.Show();

        }

        private void צפיהToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוספתמשתמשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
                RegisterUser registerUser = new RegisterUser();
                 registerUser.Show();
        }

        private void ניהולכלביםבפנסיוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms rooms = new Rooms(LogIn.loginView);
            rooms.Show();
        }

        private void הוסףעדכןחדריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRoom addRoom=new AddRoom(LogIn.loginView);
            addRoom.Show();
        }

        private void מחירוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prices prices = new Prices(LogIn.loginView);
            prices.Show();
        }
    }
}
