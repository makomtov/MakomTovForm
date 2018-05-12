using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppMT
{
    public partial class Rooms : WindowsFormsAppMT.Menu
    {
        public class ButtonPlae
        {
            public   Button button { get; set; }
            public string lastpannel { get; set; }
            public string thispannel { get; set; }
        }
        ButtonPlae[] ButtonPlace;
        
        public Rooms()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            panel2.AllowDrop = true;

            panel1.DragEnter += panel_DragEnter;
            panel2.DragEnter += panel_DragEnter;

            panel1.DragDrop += panel_DragDrop;
            panel2.DragDrop += panel_DragDrop;

          
           
            //button1.MouseUp += Button1_MouseUp;
            //button1.MouseLeave += Button1_MouseLeave;
            //button1.MouseMove += Button1_MouseMove;
            
            //lastpannel = ((Panel)button1.Parent).Name;
            //thispannel = lastpannel;
            ButtonPlace = new ButtonPlae[10];
            ButtonPlace[1] = new ButtonPlae();
            ButtonPlace[1].button = new Button();
            ButtonPlace[1].button.Name = "Button1";
            ButtonPlace[1].button.Text = "שאגי";
            ButtonPlace[1].button.Parent = panel1;
           
            ButtonPlace[1].button.Location=  new Point(0, panel1.Controls.Count*40+5);
            ButtonPlace[1].button.MouseDown += button1_MouseDown;
            ButtonPlace[1].lastpannel= ((Panel)ButtonPlace[1].button.Parent).Name;
            ButtonPlace[1].thispannel = ButtonPlace[1].lastpannel;
            panel1.Controls.Add(ButtonPlace[1].button);
            ButtonPlace[4] = new ButtonPlae();
            ButtonPlace[4].button = new Button();
            ButtonPlace[4].button.Name = "Button4";
            ButtonPlace[4].button.Text = "כחלון";
            ButtonPlace[4].button.Parent = panel1;
           
            ButtonPlace[4].button.MouseDown += button1_MouseDown;
            ButtonPlace[4].lastpannel = ((Panel)ButtonPlace[4].button.Parent).Name;
            ButtonPlace[4].thispannel = ButtonPlace[4].lastpannel;
            ButtonPlace[4].button.Location = new Point(0, panel1.Controls.Count*40 + 5);
            panel1.Controls.Add(ButtonPlace[4].button);
           


        }



       

        void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b= (Button)sender;
            b.DoDragDrop(b, DragDropEffects.Move);
            
            

        }

        

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            Button b = (Button)e.Data.GetData(typeof(Button));
            int index = int.Parse(b.Name.Substring(6, 1));
            ButtonPlace[index].lastpannel = ButtonPlace[index].thispannel;
            ButtonPlace[index].thispannel = ((Panel)sender).Name;
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
            ButtonPlace[index].button.Location = new Point(0, ((Panel)sender).Controls.Count * 40 + 5);
            if (ButtonPlace[index].lastpannel == ButtonPlace[index].thispannel)
                textBox1.Text = ButtonPlace[index].button.Text;
            else
                textBox1.Text = "";
            // ((Button)e.Data.GetData(typeof(Button))).Click += Button1_Click;


        }

       

        string n;
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                     n = c.Text;
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                    n = c.Text;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
