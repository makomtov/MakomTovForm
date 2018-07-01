using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WebApiMTModel.Models.Models.View;

namespace WindowsFormsAppMT
{
    public partial class AddRoom : WindowsFormsAppMT.Menu
    {
        
       

    public AddRoom()
    {
            //this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;

            if (LogIn.token == null)
            {
                this.Close();
                this.Hide();
                LogIn logIn = new LogIn();
                logIn.Show();


            }
            InitializeComponent();
            //   panelContainer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            //GetFileInformation();
            //GetFileOpenHours();
            //populateCBShift();
        }
        public AddRoom(LoginView loginView)
        {

            //this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;
            if (LogIn.token == null)
            {

                this.Hide();
                LogIn logIn = new LogIn();
                logIn.Show();


            }
            else
            {
                InitializeComponent();
                //  panelContainer.Anchor = System.Windows.Forms.AnchorStyles.Left;

                //GetFileInformation();
                //GetFileOpenHours();
                //populateCBShift();
                //int w = 0;
                //int h = 0;
                //if (rooms.Count > 20)

                //{
                //    w = 2000;
                //    h = 300;
                //}
                //else
                //{
                //    w = rooms.Count * 230;
                //    h = 300;
                //}
                //   panelContainer.Width = w;
                //   panelContainer.Height = h;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    if (ErrorProviderExtensions.HasErrors(errorProvider1))
        //        return;
            RoomsDetailsView roomsDetailsView = new RoomsDetailsView();
           if(comboBox1.Text!="")
            roomsDetailsView.RoomCapacity =int.Parse(comboBox1.Text);
            roomsDetailsView.RoomComments = textBoxRoomcomments.Text;
            roomsDetailsView.RoomDescription = textBoxRoomDescription.Text;
            try
            {
                DataService dataService = new DataService();

                dataService.AddRoom(roomsDetailsView);
                //  this.labelError.Text = "נוסף בהצלחה";
                MessageBox.Show("נוסף בהצלחה");
            }
            catch (WebException ex)
            {
                //using (WebResponse response = ex.Response)
                //{
                //    HttpWebResponse httpResponse = (HttpWebResponse)response;
                //    this.labelError.Text = httpResponse.StatusCode.ToString();
                //    using (Stream data = response.GetResponseStream())
                //    using (var reader = new StreamReader(data))
                //    {
                //        // string text = reader.ReadToEnd();
                //        // var x = response.re

                //        string errors = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(reader.ReadToEnd());
                //        //foreach (string _error in errors)
                //        //    this.labelError.Text += _error + " ; ";
                MessageBox.Show(ex.Message);
                //}


                //}
            }
        }
    }
}
