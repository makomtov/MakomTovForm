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


namespace WindowsFormsAppMT
{
    public partial class Form1 : Menu
    {
        
        private BindingSource bindingSource1 = new BindingSource();
        private string userID;
        List<UserDetailsView> listUsers;
        List<DogDetailsViewManager> userDogs;
        public Form1():base("Form1")
        {
            InitializeComponent();

            string URI = "http://localhost:53698/api/Users";
            GetFileInformation(URI);
        }
        //Get File List 
        public void CloseMe()
        {
            Hide();
        }
        private void btnFileList_Click(object sender, EventArgs e)
        {
            string URI = "http://localhost:53698/api/Users";
            GetFileInformation(URI);
        }
        private void GetDogsInformation(string url)
        {
            userDogs = new List<DogDetailsViewManager>();
            //  using (var client = new HttpClient())
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                var json = client.DownloadString(url);
                // var user = JsonConvert.DeserializeObject<UserDetailsView>(json);
                userDogs = JsonConvert.DeserializeObject<List<DogDetailsViewManager>>(json);
            }
            bindingSourceDogs.DataSource = userDogs;
            dataGridViewDogs.AutoGenerateColumns = false;
            int size = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }


            dataGridViewDogs.DataSource = bindingSourceDogs;
            dataGridViewDogs.Width = size + 100;

        }

        private void GetFileInformation(string url)
        {
            List<UserDetailsView> filesinformation = new List<UserDetailsView>();
            //  using (var client = new HttpClient())
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {


                var json = client.DownloadString(url);
                // var user = JsonConvert.DeserializeObject<UserDetailsView>(json);
                listUsers = JsonConvert.DeserializeObject<List<UserDetailsView>>(json);
            }
            bindingSource1.DataSource = listUsers;
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




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataGridViewRow row = senderGrid.Rows[e.RowIndex];

            if (senderGrid.Columns[e.ColumnIndex].Name == "ReservationsNumber" && e.RowIndex >= 0)
            {
               
                this.userID = row.Cells["User"].Value.ToString();
                string name = row.Cells["UserFirstName"].Value.ToString() + " " + row.Cells["UserLastName"].Value.ToString();
                this.Hide();

                reservations f2 = new reservations(userID, name); //this is the change, code for redirect

                f2.Show();
            }
            if (senderGrid.Columns[e.ColumnIndex].Name == "UserEmail" && e.RowIndex >= 0)
            {
                string mailto = row.Cells["UserEmail"].Value.ToString();
                this.Hide();
                MailForm mailForm = new MailForm(mailto);
                mailForm.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "UserDogs" && e.RowIndex >= 0)
            {
               
                this.userID = row.Cells["User"].Value.ToString();
               
               

                string URI = "http://localhost:53698/api/Users/GetUserDogs/" + userID;
                GetDogsInformation(URI);
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
            {
                DataGridViewRow viewRow = dataGridView1.Rows[row];
                viewRow.Cells["useraddress"].Value = listUsers[row].UserAddress + " " + listUsers[row].UserCityName;
                viewRow.Cells["UserPhones"].Value = listUsers[row].UserPhone1;
                if(listUsers[row].UserPhone2!="")
                { viewRow.Cells["UserPhones"].Value +=" , "+ listUsers[row].UserPhone2; }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
