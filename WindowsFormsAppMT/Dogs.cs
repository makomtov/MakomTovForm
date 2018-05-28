using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WebApiMTModel.Models.Models.View;

namespace WindowsFormsAppMT
{
    public partial class Dogs : WindowsFormsAppMT.Menu
    {
        UserDetailsView userDetailsView;
        DataTable DataTablDogs;
        private BindingSource bindingSource1 = new BindingSource();
        DogsForManagerView dogsForManagerView;
       // List<DogDetailsViewManager> userDogs;
        public Dogs()
        {
            InitializeComponent();
        }
        public Dogs(string userid,string userFirstName,string userLastName)
        {
            InitializeComponent();
            userDetailsView = new UserDetailsView();
            userDetailsView.UserID = int.Parse(userid);
            userDetailsView.UserFirstName = userFirstName;
            userDetailsView.UserLastName = userLastName;
            labelName.Text += " "+userFirstName+" " + userLastName;
            
            GetDogsInformation(userid);
        }
        private void GetDogsInformation(string userid)
        {
            DataService dataService = new DataService();
            dogsForManagerView = new DogsForManagerView();
            dogsForManagerView.UserDogs = dataService.GetDogsInformationAsync(int.Parse(userid));
           // bindingSourceDogs.DataSource = dogsForManagerView.UserDogs;

            bindingSourceDogs.DataSource = convertListDogsToTable(dogsForManagerView.UserDogs);
            dataGridViewDogs.AutoGenerateColumns = false;
            int size = 0;
            foreach (DataGridViewColumn column in dataGridViewDogs.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }

            dataGridViewDogs.RowTemplate.Height = 50;
           
          dataGridViewDogs.DataSource = bindingSourceDogs;
            //  dataGridViewDogs.Width = size + 100;
            // Automatically resize the visible rows.
          //  dataGridViewDogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

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
        private DataTable convertListDogsToTable(List<DogDetailsViewManager> list)
        {
            DataTablDogs = new DataTable();
            DataTablDogs.Columns.Add(new DataColumn("DogName"));
            DataTablDogs.Columns.Add(new DataColumn("DogComments"));
            DataTablDogs.Columns.Add(new DataColumn("DogShvav"));
            DataTablDogs.Columns.Add(new DataColumn("DogType"));
            DataTablDogs.Columns.Add(new DataColumn("DogImage",typeof(Bitmap)));
            DataTablDogs.Columns.Add(new DataColumn("DogGender"));
            DataTablDogs.Columns.Add(new DataColumn("DogNeuter", typeof(bool)));
            DataTablDogs.Columns.Add(new DataColumn("DogRabiesVaccine", typeof(DateTime)));
            DataTablDogs.Columns.Add(new DataColumn("DogAge", typeof(System.Double)));
            DataTablDogs.Columns.Add(new DataColumn("DogFriendlyWith", typeof(dogFriendlyWith)));
            DataTablDogs.Columns.Add(new DataColumn("DogDig", typeof(bool)));
            DataTablDogs.Columns.Add(new DataColumn("DogJump", typeof(bool)));
            DataTablDogs.Columns.Add(new DataColumn("DogNumber"));
            DataTablDogs.Columns.Add(new DataColumn("ManagerComments"));
            foreach (DogDetailsViewManager dog in list)
                {
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
                    DataTablDogs.Rows.Add(dr);

                }
            DataTablDogs.AcceptChanges();
            return DataTablDogs;
        }
        private void dataGridViewDogs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           

            //for (int row = 0; row < dataGridViewDogs.Rows.Count - 1; row++)
            //{
            //    DataGridViewRow viewRow = dataGridViewDogs.Rows[row];


              



            //    if (viewRow.Cells["DogImageUrl"].Value != null)
            //    {

            //        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(viewRow.Cells["DogImageUrl"].Value.ToString());
            //        myRequest.Method = "GET";
            //        HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            //        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
            //        myResponse.Close();
            //       viewRow.Cells["DogImage"].Value = bmp;
                   
            //        //img = new Bitmap(viewRow.Cells["DogImageUrl"].Value.ToString());
            //        //// Image image = Image.FromFile(viewRow.Cells["DogImageUrl"].Value.ToString());
            //        //viewRow.Cells["DogImage"].Value = img;
            //    }
               
            //}
        }

        private void dataGridViewDogs_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            ////  Add control to the host in the cell FromDate
            //DateTimePicker dtpin = new DateTimePicker();
            //dtpin.Value = DateTime.Now;
            ////add DateTimePicker into the control collection of the DataGridView
            //this.dataGridViewDogs.Controls.Add(dtpin);
            ////set its location and size to fit the cell
            //dtpin.Location = dataGridViewDogs.GetCellDisplayRectangle(9, e.Row.Index, true).Location;
            //dtpin.Size = dataGridViewDogs.GetCellDisplayRectangle(9, e.Row.Index, true).Size;
            //// e.Row.Cells["DogRabiesVaccine"].Value = dtpin.Value.ToShortDateString();

            //add combobox to dog type cell
            //ListView listViewTypes = new ListView();


        }

        private void populateListView(ListView listViewTypes)
        {
            //DataService dataService = new DataService();
            //DataTable dt= dataService.GetFileDogTypes();

            
            //    DataGridViewComboBoxCell orderStauscb = (DataGridViewComboBoxCell)viewRow.Cells["OrderStatus"];

                //orderStauscb.DataSource = listOrderStatus;
                //orderStauscb.DisplayMember = "StatusName";
                //orderStauscb.ValueMember = "StatusId";

                //OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(viewRow.Cells[1].Value.ToString()), listOrder);
                //dataGridViewOrders.Rows[row].Cells["OrderStatus"].Value = orderDetailsView.OrderStatus;
            }

            //listViewTypes.Items.Add(new ListViewItem("הכל"));
            //for (int item = 0; item < dt.Rows.Count; item++)
            //{
            //   // ListViewGroup 
            //    //ListViewItem itemView = new ListViewItem(

            //  //  listViewTypes.Items.Add(itemView);
            //}


            //listViewTypes.View = View.Details;

            //listViewTypes.Items[1].Checked = true;


        //}
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               // DogsForManagerView dogsForManagerView = new DogsForManagerView();
                DataService dataService = new DataService();
                dataService.UpdateUserDogs(dogsForManagerView);
                GetDogsInformation(userDetailsView.UserID.ToString());
                // listOrder = user.UserReservations;
              
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
        private DogDetailsView FindDogInList(int num, List<DogDetailsViewManager> list)
        {
            DogDetailsView DogDetailsView = list.Find(item => item.DogNumber == num);
            return DogDetailsView;
        }
        
        private void dataGridViewDogs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (!dataGridViewDogs.Rows[e.RowIndex].IsNewRow))
            {
                if (dataGridViewDogs.Rows[e.RowIndex].Cells["DogNumber"].Value != null)
                {
                    DogDetailsView dog = FindDogInList(int.Parse(dataGridViewDogs.Rows[e.RowIndex].Cells["DogNumber"].Value.ToString()), dogsForManagerView.UserDogs);
                    //        int ind = CheckinList(listOrder, int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()));

                    if (e.ColumnIndex == 12)  //comments-'Column index=14'
                    {
                       // if (dataGridViewDogs.Rows[e.RowIndex].Cells["ManagerComments"].Value != null)
                            ((DogDetailsViewManager)dog).DogDig = bool.Parse(dataGridViewDogs.Rows[e.RowIndex].Cells["DogDig"].Value.ToString());
                    }
                    if (e.ColumnIndex == 13)  //comments-'Column index=14'
                    {
                       // if (dataGridViewDogs.Rows[e.RowIndex].Cells["ManagerComments"].Value != null)
                            ((DogDetailsViewManager)dog).DogJump =bool.Parse( dataGridViewDogs.Rows[e.RowIndex].Cells["DogJump"].Value.ToString());
                    }
                    if (e.ColumnIndex == 14)  //comments-'Column index=14'
                    {
                        if (dataGridViewDogs.Rows[e.RowIndex].Cells["ManagerComments"].Value != null)
                            ((DogDetailsViewManager)dog).ManagerComments = dataGridViewDogs.Rows[e.RowIndex].Cells["ManagerComments"].Value.ToString();
                    }

                }
            }
        }

        private void dataGridViewDogs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewDogs.BeginEdit(true);
        }

        private void dataGridViewDogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDogs.BeginEdit(true);
        }
    }
}
