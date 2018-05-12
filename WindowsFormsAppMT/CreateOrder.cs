using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WebApiMTModel.Models.Models.View;

namespace WindowsFormsAppMT
{
    public partial class CreateOrder : WindowsFormsAppMT.Menu
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
        UserDetailsView user;
        OrderDetailsView orderDetailsView;
        DataTable DataTableReservationDogs;
        DogsForManagerView dogsForManagerView;
        private BindingSource bindingSourceDogs = new BindingSource();
        List<DogsInOrderView> listDogsInOrderView;

        public CreateOrder(UserDetailsView user)
        {
            
                this.user = new UserDetailsView();
                this.user.UserID = user.UserID;
                this.user.UserFirstName = user.UserFirstName;
                this.user.UserLastName = user.UserLastName;
                this.user.UserEmail = user.UserEmail;

                InitializeComponent();
                labelName.Text += user.UserFirstName + " " + user.UserLastName;
                GetDogsInformation(user.UserID);
            GetFileOpenHours();
            populateCBShiftFromTo();

        }
        private void GetDogsInformation(int userid)
        {
            DataService dataService = new DataService();
            dogsForManagerView = new DogsForManagerView();
            dogsForManagerView.UserDogs = dataService.GetDogsInformationAsync(userid);
            listDogsInOrderView = new List<DogsInOrderView>();
            foreach(DogDetailsViewManager dog in dogsForManagerView.UserDogs)
            {
                DogsInOrderView dogsInOrderView = new DogsInOrderView();
                dogsInOrderView.DogBirthDate = dog.DogBirthDate;
                dogsInOrderView.DogComments = dog.DogComments;
                dogsInOrderView.DogDig = dog.DogDig;
                dogsInOrderView.DogFriendlyWith = dog.DogFriendlyWith;
                dogsInOrderView.DogGender = dog.DogGender;
                dogsInOrderView.DogJump = dog.DogJump;
                dogsInOrderView.DogName = dog.DogName;
                dogsInOrderView.DogNeuter = dog.DogNeuter;
                dogsInOrderView.DogNumber = dog.DogNumber;
                dogsInOrderView.DogRabiesVaccine = dog.DogRabiesVaccine;
                dogsInOrderView.DogShvav = dog.DogShvav;
                dogsInOrderView.DogType = dog.DogType;
                dogsInOrderView.DogUserID = dog.DogUserID;
                dogsInOrderView.HomeFood = false;
                dogsInOrderView.OrderNumber = 0;
                dogsInOrderView.Pension = true;
                listDogsInOrderView.Add(dogsInOrderView);
            }
           

            // bindingSourceDogs.DataSource = dogsForManagerView.UserDogs;

            bindingSourceDogs.DataSource = convertListDogsToTable(listDogsInOrderView);
            dataGridViewDogsInOrder.AutoGenerateColumns = false;
            int size = 0;
            foreach (DataGridViewColumn column in dataGridViewDogsInOrder.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }

            dataGridViewDogsInOrder.RowTemplate.Height = 50;

            dataGridViewDogsInOrder.DataSource = bindingSourceDogs;
            //  dataGridViewDogs.Width = size + 100;
            // Automatically resize the visible rows.
            //  dataGridViewDogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        }

       

   

    private void populateCBShiftFromTo()
    {
            comboBoxExit.Items.Clear();
            comboBoxArrival.Items.Clear();
            Item item;
            
            for (int i = 0; i < openHours.Count; i++)
            {
                item = new Item(openHours[i].Description, openHours[i].ShiftNumber);
                comboBoxExit.Items.Add(item);
                comboBoxArrival.Items.Add(item);
            }
            comboBoxArrival.SelectedIndex = 0;
            comboBoxExit.SelectedIndex = 0;

        }

    private void GetFileOpenHours()
    {
        DataService dataService = new DataService();
        openHours = dataService.GetOpenHours();

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
            foreach (DogsInOrderView  dog in list)
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
            private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.Value = dateTimePickerFrom.Value;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
              //  { "OrderNumber":0,"OrderDate":"2018-05-06T22:44:20.4086468+03:00","User":null,"Userid":1,"userFirstName":null,"userLastName":null,"useremail":"ziris248@gmail.com","Price":0.0,"OrderconfirmationNumber":null,"OrderStatus":11,"OrderStatusName":null,"OrderType":0,"OrderTypeName":null,"FromDate":"2018-05-06T22:44:10.5524488+03:00","ShiftNumberFrom":1,"ToDate":"2018-05-06T22:44:10.5444349+03:00","ShiftNumberTo":1,"Discount":0.0,"mDogs":[{"OrderNumber":0,"DogTraining":false,"Pension":true,"HomeFood":false,"Status":0,"DogNumber":3,"DogUserID":1,"DogName":"ghgf","DogComments":"ytry","DogShvav":"565","DogType":"אלסקן מלמוט","DogStatus":0,"DogImage":null,"DogGender":"נקבה","DogNeuter":true,"DogRabiesVaccine":"2018-04-01T00:00:00","DogBirthDate":"2018-02-01T00:00:00","DogFriendlyWith":2,"DogDig":false,"DogJump":false},{"OrderNumber":0,"DogTraining":false,"Pension":true,"HomeFood":false,"Status":0,"DogNumber":4,"DogUserID":1,"DogName":"tytr","DogComments":"gfhgfhf","DogShvav":"45654","DogType":"אלסקן מלמוט","DogStatus":0,"DogImage":null,"DogGender":"זכר","DogNeuter":true,"DogRabiesVaccine":"2017-01-01T00:00:00","DogBirthDate":"2015-01-01T00:00:00","DogFriendlyWith":3,"DogDig":false,"DogJump":false}]}
                orderDetailsView = new OrderDetailsView();
                orderDetailsView.Discount = 0;
                orderDetailsView.FromDate = dateTimePickerFrom.Value;
                orderDetailsView.OrderDate = DateTime.Now;
                orderDetailsView.OrderNumber = 0;
                orderDetailsView.OrderStatus = 11;
                orderDetailsView.Price = 0;
                Item item = (Item)comboBoxArrival.SelectedItem;
                orderDetailsView.ShiftNumberFrom = item._Value;
                 item = (Item)comboBoxExit.SelectedItem;
                orderDetailsView.ShiftNumberTo = item._Value;
                orderDetailsView.ToDate = dateTimePickerTo.Value;
                orderDetailsView.Userid = user.UserID;
                orderDetailsView.UserEmail = user.UserEmail;

                for(int i=0;i<listDogsInOrderView.Count;i++)
                {
                    if(listDogsInOrderView[i].Status==23)
                    {
                        listDogsInOrderView.RemoveAt(i);

                    }
                }
                if (listDogsInOrderView.Count == 0)
                    MessageBox.Show("אין כלבים בהזמנה");
                else
                {
                    orderDetailsView.mDogs = listDogsInOrderView;

                    DataService dataService = new DataService();
                    int orderNum = dataService.InsertUserResarvations(orderDetailsView);
                    MessageBox.Show(orderNum.ToString());
                }
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
        private DogsInOrderView FindDogList(int num, List<DogsInOrderView> list)
        {
            DogsInOrderView dogsInOrderView = list.Find(item => item.DogNumber == num);
            return dogsInOrderView;
        }
        private void dataGridViewDogsInOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //if (((DataGridView)sender).Rows[e.RowIndex].Cells["OrderNumber"].Value != null)
                //{
               // OrderDetailsView orderDetailsView = FindOrderInList(int.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["OrderNum"].Value.ToString()), listOrder);
                DogsInOrderView dog = FindDogList(int.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["DogNumber"].Value.ToString()), listDogsInOrderView);
                if (e.ColumnIndex == 7)  //Training-'Column index=7'
                {
                    dog.DogTraining = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["DogTraining"].Value.ToString());
                }
                if (e.ColumnIndex == 8)  //HomeFood-'Column index=8'
                {
                    dog.HomeFood = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["HomeFood"].Value.ToString());
                }
                if (e.ColumnIndex == 9)  //Pension-'Column index=9'
                {
                    dog.Pension = bool.Parse(dataGridViewDogsInOrder.Rows[e.RowIndex].Cells["OrderDogs"].Value.ToString());
                    if (dog.Pension)
                        dog.Status = 21;
                    else
                        dog.Status = 23;

                }
            }
        }
    }
}
