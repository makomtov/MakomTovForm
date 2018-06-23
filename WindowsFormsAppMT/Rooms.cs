using Newtonsoft.Json;
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
    public partial class Rooms : WindowsFormsAppMT.Menu
    {
        List<ShiftView> openHours;
        ReservationDetails reservationDetails;
        //  List<Panel> listPanels = new List<Panel>();
        DataTable DataTablDogs;
        List<RoomPanel> roomPanels = new List<RoomPanel>();
        List<RoomsDetailsView> rooms;
        RoomPanel roomPanel;
        public class ButtonPlace
        {
            public Button button { get; set; }
            public string lastpannelName { get; set; }
            public string thispannelName { get; set; }
            public Panel lastpanel { get; set; }
            //public Panel thispanel { get; set; }
        }

        public class RoomPanel : RoomsDetailsView
        {
            List<ButtonPlace> buttonPlaces = new List<ButtonPlace>();
            public void AddToButtonPlace(ButtonPlace buttonPlace)
            {
                buttonPlaces.Insert(0,buttonPlace);
            }
            public ButtonPlace GetButton(string name)
            {
                foreach (ButtonPlace b in buttonPlaces)
                {
                    if (b.button.Name == name)
                        return b;
                }
                return null;
            }

            public int FindButton(string name)
            {
                for (int b = 0; b < buttonPlaces.Count; b++)
                {
                    if (buttonPlaces[b].button.Name == name)
                        return b;
                }
                return -1;
            }
            public void DeleteButton(string name)
            {
                int index = FindButton(name);
                buttonPlaces.RemoveAt(index);

            }
            public void DeleteAllButtons()
            {
                buttonPlaces = new List<ButtonPlace>();
            }
        }

        public class Dates
        {
            [JsonProperty("fromDate")]
            DateTime fromDate { get; set; }
            [JsonProperty("toDate")]
            DateTime toDate { get; set; }
            [JsonProperty("fromShift")]
            int fromShift { get; set; }
            [JsonProperty("toShift")]
            int toShift { get; set; }
            public Dates(DateTime fromDate, DateTime toDate,int fromShift, int toShift)
            {
                this.fromDate = fromDate;
                this.toDate = toDate;
                this.fromShift = fromShift;
                this.toShift = toShift;

            }
        }

        public Rooms()
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
            GetFileInformation();
            GetFileOpenHours();
            populateCBShift();
        }
        public Rooms(LoginView loginView)
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

                GetFileInformation();
                GetFileOpenHours();
                populateCBShift();
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

        private void GetFileInformation()
        {
            try
            {

                DataService dataService = new DataService();
                //Dates dates = new Dates(dateTimePicker1.Value, dateTimePicker2.Value);
                Dates dates = new Dates(dateTimePicker1.Value, dateTimePicker1.Value,int.Parse(comboBoxShift.ValueMember), int.Parse(comboBoxShift.ValueMember));
                rooms = dataService.GetRoomsSetting(dates);
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is Panel)
                    {
                        Controls.RemoveAt(i);
                        i--;
                    }
                }
                AddPannels(rooms);
                // populateGridView(listUsers);
                // populatecomboBoxFindUser();
            }
            catch (WebException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddPannels(List<RoomsDetailsView> rooms)
        {
            //  panelContainer.Controls.Clear();

            int x = 1500;
            int y = 220;
            int numTabIndex = 18;
            roomPanel = new RoomPanel();
            roomPanels = new List<RoomPanel>();
            Panel panel = new Panel();
            //  panel.Parent = panelContainer;
            // panel.Anchor = AnchorStyles.Right|AnchorStyles.Top;
            panel.Name = "0";
            panel.Width = 100;
            panel.Height = 30 * rooms[0].dogsInRoom.Count;
            panel.AllowDrop = true;
            panel.DragEnter += panel_DragEnter;
            panel.DragDrop += panel_DragDrop;
            panel.Location = new Point(x, y);
            panel.BackColor = Color.Pink;
            Label label = new Label();
            label.Location = new Point(x, y - 17);
            label.Text = "לא משובצים";
            Controls.Add(label);
            //   this.panel1.Size = new System.Drawing.Size(200, 100);
            panel.TabIndex = numTabIndex;
            //panel.Controls.Clear();
            //roomPanel.DeleteAllButtons();
            for (int d = 0; d < rooms[0].dogsInRoom.Count; d++)
            {

                ButtonPlace buttonPlace = new Rooms.ButtonPlace();
                buttonPlace.button = new Button();
                // buttonPlace.button.Name = "Button" + d;
                buttonPlace.button.Name = "Button" + rooms[0].dogsInRoom[d].DogNumber.ToString();
                buttonPlace.button.Text = rooms[0].dogsInRoom[d].DogName;
                buttonPlace.button.Parent = panel;
                buttonPlace.button.MouseDown += button1_MouseDown;
                buttonPlace.lastpannelName = (buttonPlace.button.Parent).Name;
                buttonPlace.lastpanel = (Panel)buttonPlace.button.Parent;
                buttonPlace.thispannelName = buttonPlace.lastpannelName;
                panel.Controls.Add(buttonPlace.button);
                roomPanel.AddToButtonPlace(buttonPlace);


            }
            roomPanels.Add(roomPanel);
            Controls.Add(panel);
            ArrangePannel(panel);
            for (int r = 1; r < rooms.Count; r++)
            {

                numTabIndex++;
                x -= 130;
                if (x < 20)
                {
                    y += 350;
                    x = 1255;
                }
                panel.TabIndex = numTabIndex;
                roomPanel = new RoomPanel();
                panel = new Panel();
                //  panel.Parent = panelContainer;

                panel.Name = r.ToString();
                panel.Width = 100;
                panel.Height = 300;
                panel.AllowDrop = true;
                panel.DragEnter += panel_DragEnter;
                panel.DragDrop += panel_DragDrop;
                panel.Location = new Point(x, y);
                panel.BackColor = Color.Pink;
                label = new Label();
                label.Name = rooms[r].RoomID.ToString();
                label.Location = new Point(x, y - 17);
                label.Text = rooms[r].RoomID + " חדר ";
                Controls.Add(label);
                if (rooms[r].RoomStatus != 21)
                {
                    label.Text += rooms[r].RoomStatusName;
                    Button button = new Button();
                    button.Location = new Point(x-5,y-40);
                    button.Name = "not" + r.ToString();
                    button.Width = 110;
                    button.Text = "הפוך חדר לפעיל";
                    button.Click += Button_Click;
                    Controls.Add(button);
                }
                else
                {
                    Button button = new Button();
                    button.Location = new Point(x-5, y -40);
                    button.Name = r.ToString();
                    button.Width = 110;
                    button.Text = "הפוך חדר ללא פעיל";
                    button.Click += ButtonNOt_Click;
                    Controls.Add(button);
                }
               
                //panel.Controls.Clear();
                //roomPanel.DeleteAllButtons();
                for (int d = 0; d < rooms[r].dogsInRoom.Count; d++)
                {

                    ButtonPlace buttonPlace = new Rooms.ButtonPlace();
                    buttonPlace.button = new Button();
                    //   buttonPlace.button.Name = "Button" + d;
                    buttonPlace.button.Name = "Button" + rooms[r].dogsInRoom[d].DogNumber.ToString();
                    buttonPlace.button.Text = rooms[r].dogsInRoom[d].DogName;
                    buttonPlace.button.Parent = panel;
                    buttonPlace.button.MouseDown += button1_MouseDown;
                    buttonPlace.lastpannelName = (buttonPlace.button.Parent).Name;
                    buttonPlace.lastpanel = (Panel)buttonPlace.button.Parent;
                    buttonPlace.thispannelName = buttonPlace.lastpannelName;
                    panel.Controls.Add(buttonPlace.button);
                    roomPanel.AddToButtonPlace(buttonPlace);
                }
                if (rooms[r].dogsInRoom.Count > 0 && rooms[r].RoomStatus != 21)
                {
                    MessageBox.Show("שים לב! יש כלבים בחדר לא פעיל");
                }
                Controls.Add(panel);

                roomPanels.Add(roomPanel);
                ArrangePannel(panel);

            }

        }


        private void ListBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.DoDragDrop(b, DragDropEffects.Move);



        }

        private void populateCBShift()
        {
            
            comboBoxShift.Items.Clear();
            Item item;

            for (int i = 0; i < openHours.Count; i++)
            {
                item = new Item(openHours[i].Description, openHours[i].ShiftNumber);
             
                comboBoxShift.Items.Add(item);
            }
            if (dateTimePicker1.Value.Hour >= 7 && dateTimePicker1.Value.Hour <= 12)
                comboBoxShift.SelectedIndex=0;
            else
             // if (dateTimePicker1.Value.Hour >= 16 && dateTimePicker1.Value.Hour <= 19)
                comboBoxShift.SelectedIndex = 1;

        }

        private void GetFileOpenHours()
        {
            DataService dataService = new DataService();
            openHours = dataService.GetOpenHours();

        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {

            Button b = (Button)e.Data.GetData(typeof(Button));
            int lastPanelIndex = int.Parse(b.Parent.Name);
            int index = int.Parse(b.Name.Remove(0, 6));
            ButtonPlace buttonPlace = roomPanels[lastPanelIndex].GetButton(b.Name);

            buttonPlace.lastpannelName = buttonPlace.thispannelName;
            buttonPlace.lastpanel = (Panel)buttonPlace.button.Parent;

            int dogInRoomDetailsViewPlace = FindDogInRoom(index, rooms[int.Parse(b.Parent.Name)].dogsInRoom);
            DogInRoomDetailsView dogInRoomDetailsView = rooms[int.Parse(b.Parent.Name)].dogsInRoom[dogInRoomDetailsViewPlace];
            if (buttonPlace.lastpannelName == ((Panel)sender).Name) //לא הועבר כלב, רק נלחץ
            {
                bindingSourceDogs.DataSource = convertDogToTable(dogInRoomDetailsView);
                dataGridViewDog.AutoGenerateColumns = false;
                int size = 0;
                foreach (DataGridViewColumn column in dataGridViewDog.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    size += column.Width;
                }

                dataGridViewDog.RowTemplate.Height = 50;

                dataGridViewDog.DataSource = bindingSourceDogs;
            }
            else //הועבר
            {
                bindingSourceDogs.DataSource = null;
                dataGridViewDog.DataSource = bindingSourceDogs;
                if (rooms[int.Parse(((Panel)sender).Name)].RoomStatus == 21 || int.Parse(((Panel)sender).Name) == 0)
                {
                    buttonPlace.thispannelName = ((Panel)sender).Name;

                    buttonPlace.button.Parent = (Panel)sender;

                    roomPanels[int.Parse(b.Parent.Name)].AddToButtonPlace(buttonPlace);
                    roomPanels[lastPanelIndex].DeleteButton(buttonPlace.button.Name);
                    dogInRoomDetailsView.FromDateInRoom = dateTimePicker1.Value;
                    dogInRoomDetailsView.RoomShiftFrom = int.Parse(comboBoxShift.ValueMember);
                    rooms[int.Parse(b.Parent.Name)].dogsInRoom.Insert(0, dogInRoomDetailsView);

                    //  dogInRoomDetailsView = FindDogInRoom(index, rooms[int.Parse(b.Parent.Name)].dogsInRoom);
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom.Insert(0,new DogInRoomDetailsView());

                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].Comments = dogInRoomDetailsView.Comments;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogBirthDate = dogInRoomDetailsView.DogBirthDate;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogComments = dogInRoomDetailsView.DogComments;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogDig = dogInRoomDetailsView.DogDig;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogFood = dogInRoomDetailsView.DogFood;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogFriendlyWith = dogInRoomDetailsView.DogFriendlyWith;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogGender = dogInRoomDetailsView.DogGender;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogImage  = dogInRoomDetailsView.DogImage;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogJump = dogInRoomDetailsView.DogJump;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogName = dogInRoomDetailsView.DogName;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogNeuter = dogInRoomDetailsView.DogNeuter;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogNumber = dogInRoomDetailsView.DogNumber;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogorderNumber = dogInRoomDetailsView.DogorderNumber;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogRabiesVaccine = dogInRoomDetailsView.DogRabiesVaccine;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogShvav = dogInRoomDetailsView.DogShvav;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogStatus = dogInRoomDetailsView.DogStatus;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogTraining = dogInRoomDetailsView.DogTraining;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogType = dogInRoomDetailsView.DogType;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].DogUserID = dogInRoomDetailsView.DogUserID;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].FromDateInPension = dogInRoomDetailsView.FromDateInPension;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].FromDateInRoom = dogInRoomDetailsView.FromDateInRoom;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].HomeFood = dogInRoomDetailsView.HomeFood;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].ManagerComments = dogInRoomDetailsView.ManagerComments;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].OrderNumber = dogInRoomDetailsView.OrderNumber;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].Pension = dogInRoomDetailsView.Pension;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].RoomNumberDB = dogInRoomDetailsView.RoomNumberDB;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].Status = dogInRoomDetailsView.Status;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].ToDateInPension = dogInRoomDetailsView.ToDateInPension;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].ToDateInRoom = dogInRoomDetailsView.ToDateInRoom;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].UserFirstName = dogInRoomDetailsView.UserFirstName;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].UserLastName = dogInRoomDetailsView.UserLastName;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].UserPhone1 = dogInRoomDetailsView.UserPhone1;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].UserPhone2 = dogInRoomDetailsView.UserPhone2;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].VeterinarName = dogInRoomDetailsView.VeterinarName;
                    //rooms[int.Parse(b.Parent.Name)].dogsInRoom[0].VeterinarPhone1 = dogInRoomDetailsView.VeterinarPhone1;
                    rooms[lastPanelIndex].dogsInRoom.RemoveAt(dogInRoomDetailsViewPlace);
                    ArrangePannel(buttonPlace.lastpanel);
                    ArrangePannel((Panel)buttonPlace.button.Parent);
                }
                else
                {
                    MessageBox.Show("חדר לא בשימוש");
                }
            }
            // ButtonPlace[index].button.Location = new Point(0, ((Panel)sender).Controls.Count * 40 + 5);
            
               // textBox1.Text = buttonPlace.button.Text;

               
               
          
           
              
           
            // ((Button)e.Data.GetData(typeof(Button))).Click += Button1_Click;


        }

        private static Bitmap BitmapFromWeb(string URL)
        {
            try
            {
                if (URL == null)
                    return new Bitmap(1, 1);
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                myResponse.Close();

                return bmp;
            }
            catch (Exception ex)
            {
                throw ex; // if for some reason we couldn't get to image, we return null
            }
        }
        private DataTable convertDogToTable(DogInRoomDetailsView dog)
        {
            DataTablDogs = new DataTable();
            DataTablDogs.Columns.Add(new DataColumn("DogName"));
            DataTablDogs.Columns.Add(new DataColumn("DogComments"));
            DataTablDogs.Columns.Add(new DataColumn("DogShvav"));
            DataTablDogs.Columns.Add(new DataColumn("DogType"));
            DataTablDogs.Columns.Add(new DataColumn("DogImage", typeof(Bitmap)));
            DataTablDogs.Columns.Add(new DataColumn("DogGender"));
            DataTablDogs.Columns.Add(new DataColumn("DogNeuter", typeof(bool)));
            DataTablDogs.Columns.Add(new DataColumn("DogRabiesVaccine", typeof(DateTime)));
            DataTablDogs.Columns.Add(new DataColumn("DogAge", typeof(System.Double)));
            DataTablDogs.Columns.Add(new DataColumn("DogFriendlyWith", typeof(dogFriendlyWith)));
            DataTablDogs.Columns.Add(new DataColumn("DogDig", typeof(bool)));
            DataTablDogs.Columns.Add(new DataColumn("DogJump", typeof(bool)));
            DataTablDogs.Columns.Add(new DataColumn("DogNumber"));
            DataTablDogs.Columns.Add(new DataColumn("ManagerComments"));
            DataTablDogs.Columns.Add(new DataColumn("VeterinarName"));
            DataTablDogs.Columns.Add(new DataColumn("VeterinarPhone1"));
            DataTablDogs.Columns.Add(new DataColumn("OrderNumber"));
            DataTablDogs.Columns.Add(new DataColumn("Owner"));
            DataTablDogs.Columns.Add(new DataColumn("ToDateInPension", typeof(DateTime)));

            DataRow dr = DataTablDogs.NewRow();
                dr["DogName"] = dog.DogName;
                dr["DogComments"] = dog.DogComments;
                dr["DogShvav"] = dog.DogShvav;
                dr["DogImage"] = BitmapFromWeb(dog.DogImage);
                dr["DogGender"] = dog.DogGender;
                dr["DogNeuter"] = dog.DogNeuter;
                dr["DogComments"] = dog.DogComments;
                dr["DogRabiesVaccine"] = dog.DogRabiesVaccine;
                dr["DogAge"] = (DateTime.Now - dog.DogBirthDate).TotalDays / 365.242199;
                dr["DogFriendlyWith"] = (dogFriendlyWith)dog.DogFriendlyWith;
                dr["DogDig"] = dog.DogDig;
                dr["DogJump"] = dog.DogJump;
                dr["DogType"] = dog.DogType;
                dr["DogNumber"] = dog.DogNumber;
          
                dr["ManagerComments"] = dog.ManagerComments;
                dr["VeterinarName"] = dog.VeterinarName;
                dr["VeterinarPhone1"] = dog.VeterinarPhone1;
                dr["OrderNumber"] = dog.OrderNumber;
                dr["Owner"] = dog.UserFirstName + " " + dog.UserLastName;
                dr["ToDateInPension"] = dog.ToDateInPension;
           
            DataTablDogs.Rows.Add(dr);

            
            DataTablDogs.AcceptChanges();
            return DataTablDogs;
        }
        private int FindDogInRoom(int num, List<DogInRoomDetailsView> list)
        {
            int dogInRoomDetailsViewPlace = list.FindIndex(item => item.DogNumber == num);
           
            return dogInRoomDetailsViewPlace;
        }
        private void ArrangePannel(Panel panel)
        {
            //Panel active=  FindPanel(panelName);
            int number = 0;
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                if (panel.Controls[i] is Button)
                {
                    ((Button)panel.Controls[i]).Location = new Point(0, (number * 30 + 5));
                    number++;
                }
            }
        }

        private Panel FindPanel(string panelName)
        {

            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                    if (c.Name == panelName)
                        return (Panel)c;
            }
            return null;
        }
     //   string n;
        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (Control c in panel1.Controls)
            //{
            //    if (c is Button)
            //         n = c.Text;
            //}
            //foreach (Control c in panel2.Controls)
            //{
            //    if (c is Button)
            //        n = c.Text;
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void labelFrom_Click(object sender, EventArgs e)
        {

        }

        private void buttonChooseDates_Click(object sender, EventArgs e)
        {
            GetFileInformation();
        }

        private void Rooms_Resize(object sender, EventArgs e)
        {

            //panelContainer.Width = Convert.ToInt32(this.Width * 0.9);
            //panelContainer.Height = Convert.ToInt32(this.Height * 0.9);

        }
        private Label FindLabel(string name)
        {

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                    if (c.Name == name)
                        return (Label)c;
            }
            return null;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string r = ((Button)sender).Name.Substring(3, ((Button)sender).Name.Length - 3);
            rooms[int.Parse(r)].RoomStatus = 21;
            Label l = FindLabel(rooms[int.Parse(r)].RoomID.ToString());
            l.Text = rooms[int.Parse(r)].RoomID + " חדר ";
            ((Button)sender).Name =((Button)sender).Name.Substring(3);
            ((Button)sender).Text = "הפוך חדר ללא פעיל";
            ((Button)sender).Click -= Button_Click;
            ((Button)sender).Click += ButtonNOt_Click;
        }
        private void ButtonNOt_Click(object sender, EventArgs e)
        {
            string r = ((Button)sender).Name;
            rooms[int.Parse(r)].RoomStatus = 22;
            Label l = FindLabel(rooms[int.Parse(r)].RoomID.ToString());
            l.Text ="לא פעיל" +rooms[int.Parse(r)].RoomID + " חדר ";
            ((Button)sender).Name ="not"+ r;
            ((Button)sender).Text = "הפוך חדר לפעיל";
            if (rooms[int.Parse(r)].dogsInRoom.Count>0)
            MessageBox.Show("שים לב, הפכת חדר עם כלבים ללא פעיל");
            ((Button)sender).Click -= ButtonNOt_Click;
            ((Button)sender).Click += Button_Click;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataService dataService = new DataService();
                dataService.UpdateRoomsDetailsAndSetting(rooms);
                GetFileInformation();
               
            }
            catch (WebException ex)
            {

                // Http Error
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse wrsp = (HttpWebResponse)ex.Response;
                    var statusCode = (int)wrsp.StatusCode;
                    var msg = wrsp.StatusDescription;

                    //  string url = "http://localhost:53698/api/Reservation/UpdateOrdersByManager";
                    ////  client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                    //   client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    //  client.UploadString(url,"POST", userst);



                }
            }
        }

        private void dataGridViewDog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
