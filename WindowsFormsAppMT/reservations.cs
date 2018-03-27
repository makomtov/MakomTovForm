using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebApiMTModel.Models.Models.View;
using Newtonsoft.Json;
using System.Net;

namespace WindowsFormsAppMT
{
    public enum dogFriendlyWith { יםזכר=0,נקבות,שניהם};
    public partial class reservations : Menu
    {
        DataTable DataTableReservationDogs;
        DataTable DataTableReservation;
        List<StatusView> listOrderStatus;
        List<OrderDetailsView> listOrder;
        string URI = "http://localhost:53698/api/";
        UserDetailsView user;
        OrdersForUserView OrdersForUser;

        public reservations(string userID, string name)
        {
            InitializeComponent();
            labelUser.Text = name;
            URI = URI + "Reservation/" + userID;
            GetFileUsers(URI);
            URI = "http://localhost:53698/api/Reservation/OrderStatusList";
            GetFileOrderStaus(URI);
            listOrder = user.UserReservations;
            if (listOrder.Count > 0)
                populateDataGrid(convertListToTable(user.UserReservations), "OrderStatus=11");
            populateCheckBoxList();

        }

        public reservations()
        {
            InitializeComponent();
            URI = URI + "Reservation/GetAllOrdersAndDogs";
            GetFileOrderList(URI);
            URI = "http://localhost:53698/api/Reservation/OrderStatusList";
            GetFileOrderStaus(URI);
            populateDataGrid(convertListToTable(listOrder), "OrderStatus = 11");
            populateCheckBoxList();
        }

        private void GetFileUsers(string url)
        {


            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                var json = client.DownloadString(url);
                user = JsonConvert.DeserializeObject<UserDetailsView>(json);

            }


        }
        private void GetFileOrderStaus(string url)
        {


            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                var json = client.DownloadString(url);
                listOrderStatus = JsonConvert.DeserializeObject<List<StatusView>>(json);

            }


        }
        // /api/Reservation/GetAllOrdersAndDogs

        private void GetFileOrderList(string url)
        {


            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                var json = client.DownloadString(url);
                listOrder = JsonConvert.DeserializeObject<List<OrderDetailsView>>(json);

            }


        }
        private void populateCheckBoxList()
        {
           // listViewStatus.Columns.Add("StatusName");
            //  StatusView[] statusArr = listOrderStatus.ToArray();
            for (int item = 0; item < listOrderStatus.Count; item++)
            {
                ListViewItem itemView = new ListViewItem(listOrderStatus[item].StatusName);
              
                listViewStatus.Items.Add(itemView);
            }
           
            //  StatusView[] statusArr = listOrderStatus.ToArray();
            //  CheckBox[] status = new CheckBox[statusArr.Length];
            //  for (int item = 0; item < status.Length; item++)
            //  {
            //      status[item] = new CheckBox();
            //      status[item].Text = statusArr[item].StatusName;
            //      checkedListBoxStatus.Items.Add(status[item]);

            //  }
            ////  checkedListBoxStatus.Items.AddRange(status);
            listViewStatus.View = View.Details;
           
            listViewStatus.Items[0].Checked = true;


        }
        private void populateDataGrid(DataTable dt, string filetr)
        {
            int size = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }
            DataView dv = new DataView(dt);
            dv.RowFilter = filetr;
            dataGridView1.AutoGenerateColumns = false;

            bindingSource1.DataSource = dv;
            // Automatically resize the visible rows.
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            //


            //dataGridView1.BorderStyle = BorderStyle

            // Put the cells in edit mode when user enters them.
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private DataTable convertListToTable(List<OrderDetailsView> list)
        {

            DataTableReservation = new DataTable();
            DataTableReservation.Columns.Add(new DataColumn("Name"));
            DataTableReservation.Columns.Add(new DataColumn("OrderNumber"));
            DataTableReservation.Columns.Add(new DataColumn("OrderDate"));
            DataTableReservation.Columns.Add(new DataColumn("OrderPrice"));
            DataTableReservation.Columns.Add(new DataColumn("DogName"));
            DataTableReservation.Columns.Add(new DataColumn("DogType"));
            DataTableReservation.Columns.Add(new DataColumn("OrderconfirmationNumber"));
            DataTableReservation.Columns.Add(new DataColumn("OrderStatusName"));
            DataTableReservation.Columns.Add(new DataColumn("OrderStatus"));
            DataTableReservation.Columns.Add(new DataColumn("Price"));

            foreach (OrderDetailsView order in list)
            {

                DataRow dr = DataTableReservation.NewRow();
                dr["Name"] = order.userFirstName + " " + order.userLastName;
                dr["OrderNumber"] = order.OrderNumber;
                dr["OrderDate"] = order.OrderDate;
                dr["OrderPrice"] = order.Price;
                dr["OrderconfirmationNumber"] = order.OrderconfirmationNumber;
                dr["OrderStatusName"] = order.OrderStatusName;
                dr["OrderStatus"] = order.OrderStatus;
                dr["Price"] = order.Price;
                DataTableReservation.Rows.Add(dr);



            }
            return DataTableReservation;

        }

        private DataTable convertListDogsToTable(List<DogsInOrderView> list)
        {
            DataTableReservationDogs = new DataTable();
            DataTableReservationDogs.Columns.Add(new DataColumn("DogName"));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogComments"));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogShvav"));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogType"));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogImage"));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogGender"));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogNeuter", typeof(bool)));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogRabiesVaccine", typeof(DateTime)));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogAge", typeof(System.Int32)));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogFriendlyWith", typeof(dogFriendlyWith)));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogDig", typeof(bool)));
            DataTableReservationDogs.Columns.Add(new DataColumn("DogJump", typeof(bool)));
            foreach (DogsInOrderView dog in list)
            {
                DataRow dr = DataTableReservationDogs.NewRow();
                dr["DogName"] = dog.DogName;
                dr["DogComments"] = dog.DogComments;
                dr["DogShvav"] = dog.DogShvav;
                dr["DogImage"] = dog.DogImage;
                dr["DogGender"] = dog.DogGender;
                dr["DogNeuter"] = dog.DogNeuter;
                dr["DogComments"] = dog.DogComments;
                dr["DogRabiesVaccine"] = dog.DogRabiesVaccine;
                dr["DogAge"] = DateTime.Now.Year - dog.DogBirthDate.Year;
                dr["DogFriendlyWith"] = (dogFriendlyWith)dog.DogFriendlyWith;
                dr["DogDig"] = dog.DogDig;
                dr["DogJump"] = dog.DogJump;
                DataTableReservationDogs.Rows.Add(dr);

            }
            return DataTableReservationDogs;
        }
        private void reservations_Load(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
                populateDogsInOrder(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), e.RowIndex);
        }
        public void populateDogsInOrder(string OrderNumber, int num)
        {
            DataTable data= convertListDogsToTable((FindOrderInList(int.Parse(OrderNumber), listOrder)).mDogs);
            if (data.Rows.Count > 0)
            {
                dataGridViewDogsInOrder.Visible = true;
                bindingSource2.DataSource = convertListDogsToTable((FindOrderInList(int.Parse(OrderNumber), listOrder)).mDogs);
            }
            else
                dataGridViewDogsInOrder.Visible = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
            {
                DataGridViewRow viewRow = dataGridView1.Rows[row];
                object orderNum = viewRow.Cells[1].Value;

                //לאכלס את מצבי ההזמנה
                if (orderNum != null)
                {
                    DataGridViewComboBoxCell orderStauscb = (DataGridViewComboBoxCell)viewRow.Cells["OrderStatus"];

                    orderStauscb.DataSource = listOrderStatus;
                    orderStauscb.DisplayMember = "StatusName";
                    orderStauscb.ValueMember = "StatusId";

                    OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(viewRow.Cells[1].Value.ToString()), listOrder);
                    dataGridView1.Rows[row].Cells["OrderStatus"].Value = orderDetailsView.OrderStatus;
                }

            }
            if (dataGridView1.Rows.Count > 1)
            {

                populateDogsInOrder(dataGridView1.Rows[0].Cells[1].Value.ToString(), 0);
            }
            else
                dataGridViewDogsInOrder.Visible = false;
        }

        private OrderDetailsView FindOrderInList(int num, List<OrderDetailsView> list)
        {
            OrderDetailsView orderDetailsView = list.Find(item => item.OrderNumber == num);
            return orderDetailsView;
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataGridView1.CurrentCell.ColumnIndex == 3)  //price-'Column index=3'
            {
                dataGridView1.BeginEdit(true);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 6)  //comments-'Column index=6'
            {
                dataGridView1.BeginEdit(true);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 7)  //status-'Column index=7'
            {
                dataGridView1.BeginEdit(true);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            List<OrderDetailsView> l = user.UserReservations;
            for (int rows = 1; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                l[rows].OrderStatusName = dataGridView1.Rows[rows].Cells["OrderStatus"].Value.ToString();
                //   string s = ((DataGridViewComboBoxCell)dataGridView1.Rows[rows].Cells[6]).Value.ToString();
                l[rows].OrderStatus = int.Parse(((DataGridViewComboBoxCell)dataGridView1.Rows[rows].Cells["OrderStatus"]).Value.ToString());
                l[rows].Price = decimal.Parse(dataGridView1.Rows[rows].Cells["OrderPrice"].Value.ToString());
                //להוסיף עדכון טבלת כלבים בהזמנה


            }


            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                try
                {
                    string userst = JsonConvert.SerializeObject(user);
                    client.UseDefaultCredentials = true;
                    client.Headers.Add("Content-Type:application / json; charset = utf - 8");
                    //    client.Headers.Add("Accept:application/json");
                    var uri = new Uri("http://localhost:53698/api/Reservation/UpdateOrdersByManager");
                    var response = client.UploadString(uri, "PUT", userst);
                    // jsonResponse = response;
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
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 3)  //price-'Column index=2'
            {
                dataGridView1.BeginEdit(true);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 6)  //comments-'Column index=6'
            {
                dataGridView1.BeginEdit(true);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 7)  //status-'Column index=7'
            {
                dataGridView1.BeginEdit(true);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {



        }

        private void dataGridViewDogsInOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridViewDogsInOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDogsInOrder.Columns["DogRabiesVaccine"].Index
            && e.Value != null)
            {
                if (Convert.ToDateTime(e.Value).CompareTo(DateTime.Now.AddYears(-1)) < 0)
                {
                    e.CellStyle.SelectionForeColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                }

            }
        }


        private string GenerateFilter()
        {
            string filter = "";
               

                //bool s = checkedListBoxStatus.GetSelected(i);
                //string t = checkedListBoxStatus.GetItemText(i);
                foreach (ListViewItem itm in listViewStatus.Items)
                {
                    if (itm.Checked)
                    {
                        filter += "OrderStatusName='" + itm.Text + "' OR ";
                    }
                }
                //if (listViewStatus.SelectedItems[i].
                //{
                //    filter += "OrderStatus='" + listViewStatus.Items[i].Text + "' AND";
                //}
           
                filter = filter.Substring(0, filter.LastIndexOf(" OR"));
               
            return filter;
        }
      

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filetr = GenerateFilter();

            populateDataGrid(convertListToTable(listOrder), filetr);

        }
    }
    }
