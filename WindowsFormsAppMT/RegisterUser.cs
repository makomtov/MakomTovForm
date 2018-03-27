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
    public partial class RegisterUser : WindowsFormsAppMT.Menu
    {
        DataTable CitiesTable;
        public RegisterUser()
        {
            InitializeComponent();
            string URI = "http://localhost:53698/api/XMLData/cities";
            GetFileCities(URI);
            populateCBCities();

        }

        private void populateCBCities()
        {
            comboBoxUserCityName.DataSource = CitiesTable;
            comboBoxUserCityName.DisplayMember = "Heb";
        }

        private void GetFileCities(string url)
        {


            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {

                var json = client.DownloadString(url);
              //  CitiesTable = JsonConvert.DeserializeObject<DataTable>(json.ToString());
              //  CitiesTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

                CitiesTable = dataSet.Tables[0];

                
               

            }


        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserDetailsView userDetailsView = new UserDetailsView();
            userDetailsView.UserAddress = textBoxUserAddress.Text;
            userDetailsView.UserCityName = comboBoxUserCityName.SelectedText;
            userDetailsView.UserComments = textBoxusercomments.Text;
            userDetailsView.UserEmail = textBoxUserEmail.Text;
            userDetailsView.UserFirstName = textBoxuserFirstName.Text;
            userDetailsView.UserLastName = textBoxUserLastName.Text;
            userDetailsView.UserPaswrd = textBoxUserPaswrd.Text;
            userDetailsView.UserPhone1 = textBoxUserPhone1.Text;
            userDetailsView.UserPhone2 = textBoxUserPhone2.Text;


            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                try
                {
                    string userst = JsonConvert.SerializeObject(userDetailsView);
                    client.UseDefaultCredentials = true;
                    client.Headers.Add("Content-Type:application/json; charset = utf - 8");
                    //    client.Headers.Add("Accept:application/json");
                    var uri = new Uri("http://localhost:53698/api/Users/InsertUserDetails");
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
    }
}
