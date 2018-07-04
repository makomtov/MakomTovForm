using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
            // string URI = "http://localhost:53698/";
            if (LogIn.token == null)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
            }
            GetFileCities();
            populateCBCities();

        }

        private void populateCBCities()
        {
            for (int i = 0; i < CitiesTable.Rows.Count; i++)
            {

                comboBoxUserCityName.Items.Add(CitiesTable.Rows[i]["Heb"]);
            }

            comboBoxUserCityName.Items.Insert(0, "בחר עיר");
            comboBoxUserCityName.SelectedIndex = 0;
        }

        private void GetFileCities()
        {
            DataService dataService = new DataService();
            CitiesTable = dataService.GetFileCities();

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ErrorProviderExtensions.HasErrors(errorProvider1))
                return;
            UserDetailsView userDetailsView = new UserDetailsView();
            userDetailsView.UserAddress = textBoxUserAddress.Text;
            userDetailsView.UserCity = comboBoxUserCityName.Text;
            userDetailsView.UserComments = textBoxusercomments.Text;
            userDetailsView.UserEmail = textBoxUserEmail.Text;
            userDetailsView.UserFirstName = textBoxuserFirstName.Text;
            userDetailsView.UserLastName = textBoxUserLastName.Text;
            userDetailsView.UserPaswrd = textBoxUserPaswrd.Text;
            userDetailsView.UserPhone1 = textBoxUserPhone1.Text;
            userDetailsView.UserPhone2 = textBoxUserPhone2.Text;
            userDetailsView.VeterinarName = textBoxVetName.Text;
            userDetailsView.VeterinarPhone1 = textBoxVetPhone.Text;
            userDetailsView.Acceptmessages = checkBoxAccept.Checked;
            userDetailsView.UserStatusCode = 21;
            try
            {
                DataService dataService = new DataService();

                dataService.RegisterUser(userDetailsView);
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

            //catch (WebException ex)
            //{
            //    using (WebResponse response = ex.Response)
            //    {
            //        HttpWebResponse httpResponse = (HttpWebResponse)response;
            //        this.labelError.Text = httpResponse.StatusCode.ToString();
            //        using (Stream data = response.GetResponseStream())
            //        using (var reader = new StreamReader(data))
            //        {
            //           // string text = reader.ReadToEnd();
            //           // var x = response.re

            //                List<string> errors = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            //            foreach(string _error in errors)
            //            this.labelError.Text += _error+" ; ";
            //           // MessageBox.Show()
            //        }


            //    }
        }

        private void textBoxuserFirstName_Validating(object sender, CancelEventArgs e)
        {
           ErrorProviderExtensions.checkEmpty(errorProvider1,textBoxuserFirstName, "שם פרטי חובה");

        }

        private void textBoxUserLastName_Validating(object sender, CancelEventArgs e)
        {
          ErrorProviderExtensions.checkEmpty(errorProvider1,textBoxUserLastName, "שם משפחה חובה");
        }
        private void textBoxUserEmail_Validating(object sender, CancelEventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1,textBoxUserEmail, "מייל חובה");
            ErrorProviderExtensions.regexValidate(errorProvider1,textBoxUserEmail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", " מייל לא תקין");
              
            
        }

        private void textBoxUserPhone1_Validating(object sender, CancelEventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxUserPhone1, "טלפון חובה");
            ErrorProviderExtensions.regexValidate(errorProvider1, textBoxUserPhone1, @"^0\d{8}$|^0[5,7]{1}\d{8}$", " טלפון לא תקין");
        }
        private void textBoxUserPhone2_Validating(object sender, CancelEventArgs e)
        {

            ErrorProviderExtensions.regexValidate(errorProvider1, textBoxUserPhone2, @"^0\d{8}$|^0[5,7]{1}\d{8}$", " טלפון לא תקין");
        }

        private void textBoxVetName_Validating(object sender, CancelEventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxVetName, "שם וטרינר חובה");
        }

        private void textBoxVetPhone_Validating(object sender, CancelEventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxVetPhone, "טלפון חובה");
            ErrorProviderExtensions.regexValidate(errorProvider1, textBoxVetPhone, @"^0\d{8}$|^0[5,7]{1}\d{8}$", " טלפון לא תקין");
        }

        private void textBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxConfirmPass, "סיסמה חובה");
            if(textBoxConfirmPass.Text!=textBoxUserPaswrd.Text)
                ErrorProviderExtensions.SetErrorWithCount(errorProvider1, textBoxConfirmPass , "סיסמאות לא זהות");
        
            else
                ErrorProviderExtensions.SetErrorWithCount(errorProvider1, textBoxConfirmPass,   "");
        }

        private void textBoxUserPaswrd_Validating(object sender, CancelEventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxUserPaswrd, "סיסמה חובה");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }




        //private int errorCount;
        //private void SetError(Control c, string message)
        //{
        //    errorProvider1.SetError(c, message);
        //    if (message != "")
        //        errorCount++;
        //    else
        //        errorCount--;

        //}
    }
}
