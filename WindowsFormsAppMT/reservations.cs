using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebApiMTModel.Models.Models.View;
using Newtonsoft.Json;
using System.Net;
using System.Linq;

namespace WindowsFormsAppMT
{
    public enum dogFriendlyWith { זכרים = 1, נקבות, שניהם };
    public partial class reservations : Menu
    {
        private class Item
        {
            public string Name;
            public int _Value;
            public Item(string description, int value)
            {
                Name = description;
                _Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
            public int Value
            { get; set; }
        }
        List<ShiftView> openHours;
        int lastOrder;
        DataTable DataTableReservationDogs;
        DataTable DataTableReservation;
        List<StatusView> listOrderStatus;
        List<OrderDetailsViewManager> listOrder;
      //  string URI = "http://localhost:53698/api/";
        UserDetailsView user;


        public reservations(UserDetailsView user)
        {
            this.user = new UserDetailsView();
            this.user.UserID = user.UserID;
            this.user.UserFirstName = user.UserFirstName;
            this.user.UserLastName = user.UserLastName;
            this.user.UserEmail = user.UserEmail;

            InitializeComponent();
            if (LogIn.token == null)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
            }
            labelUser.Text = user.UserFirstName + " " + user.UserLastName; ;
            GetDataFromDB();
            GetFileOpenHours();
            // listOrder = user.UserReservations;
            listOrder = listOrder.Where(a => a.Userid == user.UserID).ToList();
            for (int i = 0; i < listOrder.Count; i++)
            {
                listOrder[i].User = user;
               
            }
            if (listOrder.Count > 0)
            {
                populateDataGrid(convertListToTable(listOrder), "OrderStatus=11");
                populateCheckBoxList();

            }
           
        }
        public reservations()
        {
            InitializeComponent();
            if (LogIn.token == null)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
            }
            GetDataFromDB();
            GetFileOpenHours();
            populateDataGrid(convertListToTable(listOrder), "OrderStatus = 11");
            populateCheckBoxList();
        }

        private void GetDataFromDB()
        {
            //URI = URI + "Reservation/GetAllOrdersAndDogsManager";
            //   GetFileUsers(URI);
            DataService dataService = new DataService();
            listOrder = dataService.GetFileOrderList(LogIn.loginView);
            lastOrder = listOrder.Last().OrderNumber;
             dataService = new DataService();
            listOrderStatus = dataService.GetFileOrderStaus(LogIn.loginView);
            
        }

        private void GetFileOpenHours()
        {
            DataService dataService = new DataService();
            openHours = dataService.GetOpenHours();

        }

        private void populateCheckBoxList()
        {
            

            listViewStatus.Items.Add(new ListViewItem("הכל"));
            for (int item = 0; item < listOrderStatus.Count; item++)
            {
                ListViewItem itemView = new ListViewItem(listOrderStatus[item].StatusName);

                listViewStatus.Items.Add(itemView);
            }

          
            listViewStatus.View = View.Details;

            listViewStatus.Items[1].Checked = true;


        }
        private void populateDataGrid(DataTable dt, string filetr)
        {
            int size = 0;
            foreach (DataGridViewColumn column in dataGridViewOrders.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }
            DataView dv = new DataView(dt);
            dv.RowFilter = filetr;
            dataGridViewOrders.AutoGenerateColumns = false;

            dataGridViewOrders.DataSource = dv;
            // Automatically resize the visible rows.
            dataGridViewOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            if(dv.Count>0)
            populateDogsInOrder(dv.ToTable().Rows[0]["OrderNumber"].ToString());
            // Set the DataGridView control's border.
            //


            //dataGridView1.BorderStyle = BorderStyle

            // Put the cells in edit mode when user enters them.
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private DataTable convertListToTable(List<OrderDetailsViewManager> list)
        {

            DataTableReservation = new DataTable();
            DataTableReservation.Columns.Add(new DataColumn("Name"));
            DataTableReservation.Columns.Add(new DataColumn("OrderNumber"));
            DataTableReservation.Columns.Add(new DataColumn("OrderDate"));
            DataTableReservation.Columns.Add(new DataColumn("OrderPrice"));
            DataTableReservation.Columns.Add(new DataColumn("OrderconfirmationNumber"));
            DataTableReservation.Columns.Add(new DataColumn("OrderStatusName"));
            DataTableReservation.Columns.Add(new DataColumn("OrderStatus"));
            DataTableReservation.Columns.Add(new DataColumn("Price"));
            DataTableReservation.Columns.Add(new DataColumn("Discount"));
            DataTableReservation.Columns.Add(new DataColumn("ManagerComments"));
            DataTableReservation.Columns.Add(new DataColumn("FromDate", typeof(DateTime)));
            DataTableReservation.Columns.Add(new DataColumn("ToDate", typeof(DateTime)));
            DataTableReservation.Columns.Add(new DataColumn("ShiftNumberFrom"));
            DataTableReservation.Columns.Add(new DataColumn("ShiftNumberTo"));
            foreach (OrderDetailsViewManager order in list)
            {

                DataRow dr = DataTableReservation.NewRow();
                dr["Name"] = order.userFirstName + " " + order.userLastName;
                dr["OrderNumber"] = order.OrderNumber;
                dr["OrderDate"] = order.OrderDate.ToShortDateString();
                dr["OrderPrice"] = order.Price;
                dr["OrderconfirmationNumber"] = order.OrderconfirmationNumber;
                dr["OrderStatusName"] = order.OrderStatusName.Trim();
                dr["OrderStatus"] = order.OrderStatus;
                dr["Price"] = order.Price;
                dr["Discount"] = order.Discount;
                dr["ManagerComments"] = order.ManagerComments;
                dr["FromDate"] = order.FromDate.ToString("yyyy/MM/dd");
                dr["ToDate"] = order.ToDate.ToString("yyyy/MM/dd");
                dr["ShiftNumberFrom"] = order.ShiftNumberFrom;
                dr["ShiftNumberTo"] = order.ShiftNumberTo;
                DataTableReservation.Rows.Add(dr);



            }
            return DataTableReservation;

        }

        private DataTable convertListDogsToTable(List<DogsInOrderView> list)
        {
            DataTableReservationDogs = new DataTable();
            DataTableReservationDogs.Columns.Add(new DataColumn("DogNumber"));
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
            DataTableReservationDogs.Columns.Add(new DataColumn("DogTraining", typeof(bool)));
            DataTableReservationDogs.Columns.Add(new DataColumn("OrderNum"));
            DataTableReservationDogs.Columns.Add(new DataColumn("OrderDogs", typeof(bool)));
            DataTableReservationDogs.Columns.Add(new DataColumn("HomeFood", typeof(bool)));
            DataTableReservationDogs.Columns.Add(new DataColumn("Status", typeof(int)));
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
                dr["DogType"] = dog.DogType;
                dr["DogTraining"] = dog.DogTraining;
                dr["DogNumber"] = dog.DogNumber;
                dr["OrderNum"] = dog.OrderNumber;
                dr["OrderDogs"] = dog.Pension;
                dr["HomeFood"] = dog.HomeFood;
                dr["Status"] = dog.DogStatus;
                DataTableReservationDogs.Rows.Add(dr);

            }
            DataTableReservationDogs.PrimaryKey = new DataColumn[1] { DataTableReservationDogs.Columns["DogNumber"] };
            return DataTableReservationDogs;
        }
        private void reservations_Load(object sender, EventArgs e)
        {

          //  populateGrid();


        }
       
        private void dataGridViewOrders_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                var BtnCell = (DataGridViewButtonCell)dataGridViewOrders.Rows[e.RowIndex].Cells[11];
                OrderDetailsView order = FindOrderInList(int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()), listOrder);
                //if (order.mDogs.Count==0)
                //{
                //    dataGridViewDogsInOrder.Visible = true;
                //    dataGridViewDogsInOrder.Columns["OrderDogs"].Visible = true;
                //    //  DogService.GetDogsInformation(user.UserID);
                //    DataService dataService = new DataService();
                //    List<DogDetailsViewManager> dogslist = dataService.GetDogsInformation(user.UserID);
                //    List<DogsInOrderView> dogsInorderViewList = new List<DogsInOrderView>();

                ////    order.mDogs = new List<DogsInOrderView>();
                //    for (int i = 0; i < dogslist.Count; i++)
                //    {
                //        order.mDogs.Add(new DogsInOrderView());

                //        order.mDogs[i].DogBirthDate = dogslist[i].DogBirthDate;
                //        order.mDogs[i].DogName = dogslist[i].DogName;
                //        order.mDogs[i].DogComments = dogslist[i].DogComments;
                //        order.mDogs[i].DogDig = dogslist[i].DogDig;
                //        order.mDogs[i].DogFriendlyWith = dogslist[i].DogFriendlyWith;
                //        order.mDogs[i].DogNumber = dogslist[i].DogNumber;
                //        order.mDogs[i].DogJump = dogslist[i].DogJump;
                //        order.mDogs[i].Training = false;
                //        order.mDogs[i].HomeFood = false;
                //        order.mDogs[i].Pension = true;
                //        order.mDogs[i].OrderNumber = int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString());


            //}

            //dataGridViewDogsInOrder.DataSource = convertListDogsToTable(order.mDogs);
                populateDogsInOrder(dataGridViewOrders.Rows[e.RowIndex].Cells[1].Value.ToString());
                //  populateGrid();
                //Dogs dogs = new Dogs(user.UserID.ToString(), user.UserFirstName + " " + user.UserLastName);
                //dogs.Show();

            }
                //else
                //{
                //    populateDogsInOrder(dataGridViewOrders.Rows[e.RowIndex].Cells[1].Value.ToString());
                //}
            }

       
        public void populateDogsInOrder(string OrderNumber)
        {
            
            DataTable data = convertListDogsToTable((FindOrderInList(int.Parse(OrderNumber), listOrder)).mDogs);
            if (data.Rows.Count > 0)
            {
                dataGridViewDogsInOrder.Visible = true;
                dataGridViewDogsInOrder.AutoGenerateColumns = false;
                dataGridViewDogsInOrder.DataSource = data;
                
               
            }
            else
                dataGridViewDogsInOrder.Visible = false;
        }

        private void dataGridViewOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //var BtnCell = (DataGridViewButtonCell)dataGridViewOrders.Rows[e.RowIndex].Cells[11];
            //if (BtnCell.Value.ToString() == "הוסף כלבים")
            for (int row = 0; row < dataGridViewOrders.Rows.Count; row++)
            {
                DataGridViewRow viewRow = dataGridViewOrders.Rows[row];
                object orderNum = viewRow.Cells[1].Value;
                populateOrderStatusinDataGrid(viewRow, orderNum);
                populateShiftArrival(viewRow, orderNum);
                populateShiftExit(viewRow, orderNum);
                //  ChangeButtonText(viewRow, orderNum);

            }
            
            //if (dataGridViewOrders.Rows.Count > 1)
            //{
            //if()
            //   populateDogsInOrder(dataGridViewOrders.Rows[0].Cells[1].Value.ToString());
            //}
            //else
            //    dataGridViewDogsInOrder.Visible = false;
        }
        private void ChangeButtonText(DataGridViewRow viewRow,object orderNum)
        {
            //var BtnCell = (DataGridViewButtonCell)viewRow.Cells[11];
            //if (orderNum != null)
            //{
            //    OrderDetailsView order = FindOrderInList(int.Parse(orderNum.ToString()), listOrder);
            //    if (order.mDogs.Count == 0)
            //        BtnCell.Value = "הוסף כלבים";
            //    else
            //        BtnCell.Value = "כלבים בהזמנה";
            //    viewRow.Cells["ShiftNumberFrom"].Value = order.ShiftNumberFrom.ToString();
            //    viewRow.Cells["ShiftNumberTo"].Value = order.ShiftNumberTo.ToString();
            //}
        }
        private void populateOrderStatusinDataGrid(DataGridViewRow viewRow,object orderNum)
        {
           
                

                //לאכלס את מצבי ההזמנה
                if (orderNum != null)
                {
                    DataGridViewComboBoxCell orderStauscb = (DataGridViewComboBoxCell)viewRow.Cells["OrderStatus"];

                    orderStauscb.DataSource = listOrderStatus;
                    orderStauscb.DisplayMember = "StatusName";
                    orderStauscb.ValueMember = "StatusId";

                    OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(viewRow.Cells[1].Value.ToString()), listOrder);
                    viewRow.Cells["OrderStatus"].Value = orderDetailsView.OrderStatus;
                }

           
        }

        private void populateShiftArrival(DataGridViewRow viewRow, object orderNum)
        {
            //איכלוס משמרת הגעה
            if (orderNum != null)
            {
                DataGridViewComboBoxCell ShiftNumberFromCB = (DataGridViewComboBoxCell)viewRow.Cells["ShiftNumberFrom"];

                ShiftNumberFromCB.DataSource = openHours;
                ShiftNumberFromCB.DisplayMember = "Description";
                ShiftNumberFromCB.ValueMember = "ShiftNumber";

                OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(viewRow.Cells[1].Value.ToString()), listOrder);
                viewRow.Cells["ShiftNumberFrom"].Value = orderDetailsView.ShiftNumberFrom;
            }
        }


        private void populateShiftExit(DataGridViewRow viewRow, object orderNum)
        {
            //איכלוס משמרת עזיבה
            if (orderNum != null)
            {
                DataGridViewComboBoxCell ShiftNumberFromCB = (DataGridViewComboBoxCell)viewRow.Cells["ShiftNumberTo"];

                ShiftNumberFromCB.DataSource = openHours;
                ShiftNumberFromCB.DisplayMember = "Description";
                ShiftNumberFromCB.ValueMember = "ShiftNumber";

                OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(viewRow.Cells[1].Value.ToString()), listOrder);
                viewRow.Cells["ShiftNumberTo"].Value = orderDetailsView.ShiftNumberFrom;
            }
        }
        private OrderDetailsView FindOrderInList(int num, List<OrderDetailsViewManager> list)
        {
            OrderDetailsView orderDetailsView = list.Find(item => item.OrderNumber == num);
            return orderDetailsView;
        }
        private DogsInOrderView FindDogList(int num, List<DogsInOrderView> list)
        {
            DogsInOrderView dogsInOrderView = list.Find(item => item.DogNumber == num);
            return dogsInOrderView;
        }
        private string FindStatusName(int StatusVal)
        {
            StatusView statusView = listOrderStatus.Find(item => item.StatusId == StatusVal);
            return statusView.StatusName;
        }
        private void dataGridViewOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)


        {
            dataGridViewOrders.BeginEdit(true);

            //if (dataGridView1.CurrentCell.ColumnIndex == 7)  //price-'Column index=3'
            //{
            //    dataGridView1.BeginEdit(true);
            //}
            //if (dataGridView1.CurrentCell.ColumnIndex == 8)  //discount-'Column index=4'
            //{
            //    dataGridView1.BeginEdit(true);
            //}
            //if (dataGridView1.CurrentCell.ColumnIndex == 10)  //comments-'Column index=6'
            //{
            //    dataGridView1.BeginEdit(true);
            //}
            //if (dataGridView1.CurrentCell.ColumnIndex == 12)  //status-'Column index=8'
            //{
            //    dataGridView1.BeginEdit(true);
            //}

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
          //  changeGVCellsType();
            try
            {
                //for (int i = 0; i < listOrder.Count; i++)
                //{
                //    for (int d = 0; d < listOrder[i].mDogs.Count; d++)
                //    {
                //        if (listOrder[i].mDogs[d].Status == 23)
                //            listOrder[i].mDogs.RemoveAt(d);
                //    }
                //}
                DataService dataService = new DataService();
                dataService.UpdateUserResarvations(listOrder);
                GetDataFromDB();
                // listOrder = user.UserReservations;
                if(user!=null)
                listOrder = listOrder.Where(a =>  a.Userid == user.UserID).ToList();

                if (listOrder.Count > 0)
                    populateGrid();
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

        private void changeGVCellsType()
        {
            ////  cahmge the cell FromDate type to text
            //Label labelDateFrom = new Label();
            //labelDateFrom.Text = DateTime.Now;
            ////add DateTimePicker into the control collection of the DataGridView
            //this.dataGridViewOrders.Controls.Add(dtpout);
            ////set its location and size to fit the cell
            //dtpout.Location = dataGridViewOrders.GetCellDisplayRectangle(5, e.Row.Index, true).Location;
            //dtpout.Size = dataGridViewOrders.GetCellDisplayRectangle(5, e.Row.Index, true).Size;
            //e.Row.Cells["ToDate"].Value = dtpout.Value.ToShortDateString();
        }

        private void dataGridViewOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewOrders.BeginEdit(true);
            if (e.ColumnIndex == 12)  //status-'Column index=12'
            {
                // int ind = FindOrderInList(int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()), listOrder);
                OrderDetailsView order = FindOrderInList(int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()), listOrder);
                string SelectedText = Convert.ToString((dataGridViewOrders.Rows[e.RowIndex].Cells["OrderStatus"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                int SelectedVal = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderStatus"].Value);
                //listOrder[ind].OrderStatus = SelectedVal;
                //listOrder[ind].OrderStatusName = SelectedText;
                order.OrderStatus = SelectedVal;
                order.OrderStatusName = SelectedText;
                if (SelectedVal == 15)
                {
                    for (int i = 0; i < order.mDogs.Count; i++)
                    {
                        order.mDogs[i].DogTraining = false;

                    }
                    populateDogsInOrder(order.OrderNumber.ToString());
                }
                    //for (int i = 0; i < listOrder[ind].mDogs.Count; i++)
                    //{
                    //    listOrder[ind].mDogs[i].DogTraining = false;

                    //}
                    //        //populateDogsInOrder(listOrder[ind].OrderNumber.ToString());
                    //    }
                    //}
                    //if (dataGridView1.CurrentCell.ColumnIndex == 7)  //price-'Column index=3'
                    //{
                    //    dataGridView1.BeginEdit(true);
                    //}
                    //if (dataGridView1.CurrentCell.ColumnIndex == 8)  //discount-'Column index=4'
                    //{
                    //    dataGridView1.BeginEdit(true);
                    //}
                    //if (dataGridView1.CurrentCell.ColumnIndex == 10)  //comments-'Column index=6'
                    //{
                    //    dataGridView1.BeginEdit(true);
                    //}
                    //if (dataGridView1.CurrentCell.ColumnIndex == 12)  //status-'Column index=8'
                    //{
                    //    dataGridView1.BeginEdit(true);
                    //}
                
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
            string field = "";
            string filter = "";
            bool check = false;
            foreach (ListViewItem itm in listViewStatus.Items)
            {
                if (itm.Checked)
                {
                    check = true;
                }
            }
            if (check)
            {
                if (listViewStatus.Items[0].Checked == false)
                {
                    filter += "(";
                    //bool s = checkedListBoxStatus.GetSelected(i);
                    //string t = checkedListBoxStatus.GetItemText(i);
                    foreach (ListViewItem itm in listViewStatus.Items)
                    {
                        if (itm.Checked)
                        {
                            filter += "OrderStatusName='" + itm.Text.Trim() + "' OR ";
                        }
                    }
                    //if (listViewStatus.SelectedItems[i].
                    //{
                    //    filter += "OrderStatus='" + listViewStatus.Items[i].Text + "' AND";
                    //}
                    if (filter.LastIndexOf(" OR") >= 0)
                        filter = filter.Substring(0, filter.LastIndexOf(" OR"));
                    filter += ")";
                }
                
            }


            if (comboBoxChooseDate.Text != "ללא תאריך")
            {
                if (filter != "") filter += " AND ";
                switch(comboBoxChooseDate.Text)
                {
                    case "תאריך הזמנה":field = "OrderDate";
                        break;
                    case "תאריך הגעה":field = "FromDate";
                        break;
                    case "תאריך עזיבה":field ="ToDate";
                        break;
                }
                DateTime df = new DateTime(dateTimePickerFrom.Value.Year, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Day);
                DateTime dt = new DateTime(dateTimePickerTo.Value.Year, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Day);
                filter += "("+field+">=#" + df.ToString("yyyy/MM/dd") + "# AND "+ field+"<=#" + dt.ToString("yyyy/MM/dd") + "#)";
            }

            return filter;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            populateGrid();

        }

        private void populateGrid()
        {
            string filetr = GenerateFilter();

            populateDataGrid(convertListToTable(listOrder), filetr);
        }

        private void dataGridViewOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (!dataGridViewOrders.Rows[e.RowIndex].IsNewRow))
            {
                if (dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value != null)
                {
                    OrderDetailsView order = FindOrderInList(int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()), listOrder);
                    //        int ind = CheckinList(listOrder, int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()));
                    if (e.ColumnIndex == 3)  //FromDate-'Column index=3'
                    {

                        order.FromDate = Convert.ToDateTime(dataGridViewOrders.Rows[e.RowIndex].Cells["FromDate"].Value);
                        if (order.FromDate.CompareTo(order.ToDate) > 0)
                        {
                            dataGridViewOrders.Rows[e.RowIndex].Cells["ToDate"].Value = order.FromDate;
                            order.ToDate = order.FromDate;
                        }
                    }
                    if (e.ColumnIndex == 4)  //ShiftNumberFrom-'Column index=4'
                    {
                        if (dataGridViewOrders.Rows[e.RowIndex].Cells["ShiftNumberFrom"].Value != null)
                        {
                            //string SelectedText = Convert.ToString((dataGridViewOrders.Rows[e.RowIndex].Cells["ShiftNumberFrom"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                            //order.ShiftNumberFrom = int.Parse(SelectedText);
                            order.ShiftNumberFrom = int.Parse(Convert.ToString((dataGridViewOrders.Rows[e.RowIndex].Cells["ShiftNumberFrom"] as DataGridViewComboBoxCell).Value));

                        }
                    }
                    if (e.ColumnIndex == 5)  //ToDate-'Column index=5'
                    {
                        order.ToDate = Convert.ToDateTime(dataGridViewOrders.Rows[e.RowIndex].Cells["ToDate"].Value);
                    }
                    if (e.ColumnIndex == 6)  //ShiftNumberTo-'Column index=6'
                    {
                        if (dataGridViewOrders.Rows[e.RowIndex].Cells["ShiftNumberTo"].Value != null)
                        {
                            //string SelectedText = Convert.ToString((dataGridViewOrders.Rows[e.RowIndex].Cells["ShiftNumberTo"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                            //order.ShiftNumberTo = int.Parse(SelectedText);
                            order.ShiftNumberTo = int.Parse(Convert.ToString((dataGridViewOrders.Rows[e.RowIndex].Cells["ShiftNumberFrom"] as DataGridViewComboBoxCell).Value));
                        }
                    }
                    if (e.ColumnIndex == 7)  //price-'Column index=3'
                    {
                        if (dataGridViewOrders.Rows[e.RowIndex].Cells["OrderPrice"].Value != null)
                            order.Price = decimal.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderPrice"].Value.ToString());
                    }
                    if (e.ColumnIndex == 8)  //discount-'Column index=8'
                    {
                        order.Discount = decimal.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["Discount"].Value.ToString());
                    }

                    if (e.ColumnIndex == 10)  //comments-'Column index=10'
                    {
                        if (dataGridViewOrders.Rows[e.RowIndex].Cells["ManagerComments"].Value != null)
                           ((OrderDetailsViewManager) order).ManagerComments = dataGridViewOrders.Rows[e.RowIndex].Cells["ManagerComments"].Value.ToString();
                    }

                    if (e.ColumnIndex == 12)  //status-'Column index=12'
                    {
                       
                        //   int ind = FindOrderInList(int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()), listOrder);
                        string SelectedText = Convert.ToString((dataGridViewOrders.Rows[e.RowIndex].Cells["OrderStatus"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                        int SelectedVal = Convert.ToInt32(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderStatus"].Value);
                        order.OrderStatus = SelectedVal;
                        order.OrderStatusName = SelectedText;
                        if (SelectedVal == 15)
                        {
                            for (int i = 0; i < order.mDogs.Count; i++)
                            {
                                order.mDogs[i].DogTraining = false;

                            }
                            populateDogsInOrder(order.OrderNumber.ToString());
                        }
                    }
                }
            }
        }

   



        private void listViewStatus_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (listViewStatus.Items[0].Checked)
            {
                for (int item = 1; item < listViewStatus.Items.Count; item++)
                {
                    listViewStatus.Items[item].Checked = false;
                }
            }
        }

        private void dataGridViewOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dataGridViewOrders.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }



       

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
          //  dataGridViewDogsInOrder.Visible = false;
          //  e.Row.Cells["OrderDate"].Value = DateTime.Now.ToShortDateString();
          //  e.Row.Cells["FromDate"].Value = DateTime.Now.ToShortDateString();
          //  e.Row.Cells["ToDate"].Value = DateTime.Now.ToShortDateString();
          //  e.Row.Cells["ToDate"].Value = DateTime.Now.ToShortDateString();
          //  // DataGridViewRow viewRow = dataGridViewOrders.Rows[e.Row.Index];


          //  //לאכלס את מצבי ההזמנה

          //  DataGridViewComboBoxCell orderStauscb = (DataGridViewComboBoxCell)e.Row.Cells["OrderStatus"];

          //  orderStauscb.DataSource = listOrderStatus;
          //  orderStauscb.DisplayMember = "StatusName";
          //  orderStauscb.ValueMember = "StatusId";
          //  e.Row.Cells["OrderStatus"].Value = 11;
          //  e.Row.Cells["UserName"].Value = user.UserFirstName + " " + user.UserLastName;
          //  lastOrder++;
          //  e.Row.Cells["OrderNumber"].Value = lastOrder;
          //  e.Row.Cells["ShiftNumberFrom"].Value = 1;
          //  e.Row.Cells["ShiftNumberTo"].Value = 1;
          //  //viewRow.Cells["ShiftNumberTo"].Value = 1;
          //  //   viewRow.Cells[""]

          //  var BtnCell = (DataGridViewButtonCell)dataGridViewOrders.Rows[e.Row.Index].Cells[11];
          //  BtnCell.Value = "הוסף כלבים";
           
          //  OrderDetailsViewManager orderDetailsViewManager = new OrderDetailsViewManager();
          //  orderDetailsViewManager.userFirstName = user.UserFirstName;
          //  orderDetailsViewManager.userLastName = user.UserLastName;
          //  orderDetailsViewManager.mDogs = new List<DogsInOrderView>();
          //  orderDetailsViewManager.OrderDate = DateTime.Now;
          //  orderDetailsViewManager.OrderStatus = 11;
          //  orderDetailsViewManager.OrderStatusName = "חדש";
          //  orderDetailsViewManager.FromDate = DateTime.Now;
          //  orderDetailsViewManager.ToDate = DateTime.Now;
          //  orderDetailsViewManager.Userid = user.UserID;
          //  orderDetailsViewManager.Price = 0;
          //  orderDetailsViewManager.Discount = 0;
          //  orderDetailsViewManager.OrderNumber = lastOrder;
          //  orderDetailsViewManager.User = this.user;
          //  listOrder.Add(orderDetailsViewManager);
          ////      populateGrid();
            //  ((DataGridView)sender).BindingContext[((DataGridView)sender).DataSource].EndCurrentEdit();
        }

        private void dataGridViewOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;
            ////if (dgv.Name == "dataGridView1")
            ////    return;
            //var row = dgv.Rows[e.RowIndex];

            //if (row.IsNewRow)
            //{
            //    // Set your default values here
            //    row.Cells["UserName"].Value = user.UserFirstName + " " + user.UserLastName;
            //    row.Cells["OrderNumber"].Value = 0;

            // Force the DGV to add the new row by marking it dirty
            dgv.NotifyCurrentCellDirty(true);
            // }
        }
        private void dataGridViewDogsInOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;
            ////if (dgv.Name == "dataGridView1")
            ////    return;
            //var row = dgv.Rows[e.RowIndex];

            //if (row.IsNewRow)
            //{
            //    // Set your default values here
            //    row.Cells["UserName"].Value = user.UserFirstName + " " + user.UserLastName;
            //    row.Cells["OrderNumber"].Value = 0;

            // Force the DGV to add the new row by marking it dirty
            dgv.NotifyCurrentCellDirty(true);
            // }
        }
        private void dataGridViewDogsInOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDogsInOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //if (((DataGridView)sender).Rows[e.RowIndex].Cells["OrderNumber"].Value != null)
                //{
                OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["OrderNum"].Value.ToString()), listOrder);
                DogsInOrderView dog = FindDogList(int.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["DogNumber"].Value.ToString()), orderDetailsView.mDogs);
                if (e.ColumnIndex == 7)  //Training-'Column index=7'
                {
                    dog.DogTraining = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["DogTraining"].Value.ToString());
                    if (dog.DogTraining == true && orderDetailsView.OrderStatus == 15)
                        MessageBox.Show("שים לב, סתירה בין סטטוס הזמנה לנתונים");

                }
                if (e.ColumnIndex == 8)  //HomeFood-'Column index=8'
                {
                    dog.HomeFood = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["HomeFood"].Value.ToString());
                    
                }
                if (e.ColumnIndex == 9)  //Training-'Column index=7'
                {
                    dog.Pension = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["OrderDogs"].Value.ToString());
                    if (dog.Pension)
                        dog.Status = 21;
                    else
                        dog.Status = 23;

                }
            }
        }

        private void dataGridViewDogsInOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    //if (((DataGridView)sender).Rows[e.RowIndex].Cells["OrderNumber"].Value != null)
            //    //{
            //    OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["OrderNum"].Value.ToString()), listOrder);
            //    DogsInOrderView dog = FindDogList(int.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["DogNumber"].Value.ToString()), orderDetailsView.mDogs);
            //    if (e.ColumnIndex == 7)  //Training-'Column index=7'
            //    {
            //        dog.Training = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["Training"].Value.ToString());
            //    }
            //    if (e.ColumnIndex == 8)  //HomeFood-'Column index=8'
            //    {
            //        DataGridViewCheckBoxCell chk = dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["HomeFood"] as DataGridViewCheckBoxCell;
                  
            //            dog.HomeFood = Convert.ToBoolean(chk.Value);
            //    }
            //    if (e.ColumnIndex == 9)  //Training-'Column index=7'
            //    {
            //        dog.Pension = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["OrderDogs"].Value.ToString());
                   
            //    }
            //}
        }

        private void dataGridViewDogsInOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDogsInOrder.IsCurrentCellDirty)
                dataGridViewDogsInOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            object orderNum = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value;
            populateDogsInOrder(orderNum.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.Value = dateTimePickerFrom.Value;
        }

       
    }
}


