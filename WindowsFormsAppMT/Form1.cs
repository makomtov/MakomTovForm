using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiMTModel.Models.Models.View;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Reflection;

namespace WindowsFormsAppMT
{
    public partial class Form1 : Menu
    {
        private class Item
        {
            public string Name;
            public int _Value;
            public Item(string FirstName,string LastName, int value)
            {
                Name=FirstName+" "+LastName;
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

        private string userID;
        List<UserDetailsView> listUsers;
       
        public Form1(LoginView loginView):base("Form1")
        {
            
            InitializeComponent();
          
            
            GetFileInformation(loginView);
          //  populatecomboBoxFindUser();
        }
        //Get File List 
        public void CloseMe()
        {
            Hide();
        }

        private void populatecomboBoxFindUser()
        {
            comboBoxFindUser.Items.Clear();
            Item item;
            //Item item = new Item("כל", "המשתמשים", 0);
            //comboBoxFindUser.Items.Add(item);
            for (int i = 0; i < listUsers.Count; i++)
            {
                 item = new Item(listUsers[i].UserFirstName, listUsers[i].UserLastName, listUsers[i].UserID);
                comboBoxFindUser.Items.Add(item);
            }
            comboBoxFindUser.Items.Insert(0, new Item("כל", "המשתמשים", 0));
            comboBoxFindUser.SelectedIndex = 0;

            // bindingSource1.DataSource = listUsers;

            // comboBoxFindUser.DataSource = bindingSource1.DataSource;
            //// comboBoxFindUser.DataSource = listUsers;

            // comboBoxFindUser.DisplayMember = "UserFirstName";
            // comboBoxFindUser.ValueMember = "UserID";


        }

        private void GetFileInformation(LoginView loginView)
        {
            try
            {
                if (LogIn.token == null)
                {
                    LogIn logIn = new LogIn();
                    logIn.Show();
                }
                DataService dataService = new DataService();
                listUsers = dataService.GetUsersInformation(loginView);

                populateGridView(listUsers);
                populatecomboBoxFindUser();
            }
            catch (WebException ex)
            {
               
                MessageBox.Show(ex.Message);
            }

        }

        private void populateGridView(List<UserDetailsView> list)
        {
            bindingSource1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            int size = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }

           
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Width = size + 100;
        }

        private UserDetailsView FindUserInList(int num, List<UserDetailsView> list)
        {
            UserDetailsView orderDetailsView = list.Find(item => item.UserID == num);
            return orderDetailsView;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataGridViewRow row = senderGrid.Rows[e.RowIndex];

            if (senderGrid.Columns[e.ColumnIndex].Name == "ReservationsNumber" && e.RowIndex >= 0)
            {
                UserDetailsView user = FindUserInList(int.Parse(senderGrid.Rows[e.RowIndex].Cells["User"].Value.ToString()), listUsers);
                if (user.DogsNumber > 0)
                {
                    UserDetailsView userDetailsView = new UserDetailsView();
                    userDetailsView.UserID = int.Parse(row.Cells["User"].Value.ToString());
                    userDetailsView.UserLastName = row.Cells["UserLastName"].Value.ToString();
                    userDetailsView.UserFirstName = row.Cells["UserFirstName"].Value.ToString();
                    userDetailsView.UserEmail = row.Cells["UserEmail"].Value.ToString();
                    this.Hide();

                    reservations f2 = new reservations(userDetailsView); //this is the change, code for redirect

                    f2.Show();
                }
                else
                {
                    labelError.Text=  "ל";
                    labelError.Text +=  user.UserFirstName + " " + user.UserLastName ;
                    labelError.Text += " אין כלבים. לא ניתן לבצע הזמנה ";
                    }
            }
            if (senderGrid.Columns[e.ColumnIndex].Name == "UserEmail" && e.RowIndex >= 0)
            {
                string mailto = row.Cells["UserEmail"].Value.ToString();
                this.Hide();
                MailForm mailForm = new MailForm(mailto.Trim());
                mailForm.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "DogsWatch" && e.RowIndex >= 0)
            {
               
                this.userID = row.Cells["User"].Value.ToString();
               
                string userFirstName = row.Cells["UserFirstName"].Value.ToString();
                string userLastName = row.Cells["UserLastName"].Value.ToString();
                Dogs dogs = new Dogs(userID,userFirstName,userLastName);
                dogs.ShowDialog(this);
               
            }
            if (senderGrid.Columns[e.ColumnIndex].Name == "CreateOrder" && e.RowIndex >= 0)
            {

                UserDetailsView userDetailsView = new UserDetailsView();
                userDetailsView.UserID = int.Parse(row.Cells["User"].Value.ToString());
                userDetailsView.UserLastName = row.Cells["UserLastName"].Value.ToString();
                userDetailsView.UserFirstName = row.Cells["UserFirstName"].Value.ToString();
                userDetailsView.UserEmail = row.Cells["UserEmail"].Value.ToString();
                this.Hide();

                CreateOrder createOrder = new CreateOrder(userDetailsView); //this is the change, code for redirect

                createOrder.Show();
            }
            if(senderGrid.Columns[e.ColumnIndex].Name == "Vet" && e.RowIndex >= 0)
                {
                UserDetailsView user = FindUserInList(int.Parse(row.Cells["User"].Value.ToString()), listUsers);

                MessageBox.Show(string.Format("שם הוטרינר:{0}\nנייד:{1}",user.VeterinarName,user.VeterinarPhone1));
            }
            if (senderGrid.Columns[e.ColumnIndex].Name == "UpdateDtails" && e.RowIndex >= 0)
            {
                UserDetailsView userDetailsView;
                int UserID =int.Parse(row.Cells["User"].Value.ToString());
                userDetailsView = FindUserInList(UserID, listUsers);
                UpdateUserDetails updateUserDetails = new UpdateUserDetails(userDetailsView);
                this.Close();
                updateUserDetails.Show();

            }
            if (senderGrid.Columns[e.ColumnIndex].Name == "AddDog" && e.RowIndex >= 0)
            {
                UserDetailsView userDetailsView;
                int UserID = int.Parse(row.Cells["User"].Value.ToString());
                userDetailsView = FindUserInList(UserID, listUsers);
                this.Hide();
                InsertNewDogForUser insertNewDogForUser = new InsertNewDogForUser(userDetailsView);
                insertNewDogForUser.Show();
            }

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int row = 0; row < dataGridView1.Rows.Count ; row++)
            {
                DataGridViewRow viewRow = dataGridView1.Rows[row];
                viewRow.Cells["useraddress"].Value = listUsers[row].UserAddress + " " + listUsers[row].UserCityName;
                viewRow.Cells["UserPhones"].Value = listUsers[row].UserPhone1;
                if(listUsers[row].UserPhone2!="")
                { viewRow.Cells["UserPhones"].Value +=" , "+ listUsers[row].UserPhone2; }
            }
        }

        private void comboBoxFindUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void comboBoxFindUser_Format(object sender, ListControlConvertEventArgs e)
        {
            //string lastname = ((UserDetailsView)e.ListItem).UserFirstName;
            //string firstname = ((UserDetailsView)e.ListItem).UserLastName;
            //e.Value = lastname + " " + firstname;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            populateGridView(listUsers);
        }

        private void comboBoxFindUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Item item = (Item)comboBoxFindUser.SelectedItem;
            if (item._Value == 0)
                populateGridView(listUsers);
            else
            {
                List<UserDetailsView> temp = listUsers.FindAll(user => user.UserID == item._Value);
                populateGridView(temp);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
        }
    }
}
