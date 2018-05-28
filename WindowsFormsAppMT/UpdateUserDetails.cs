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
    public partial class UpdateUserDetails : WindowsFormsAppMT.Menu
    {
        UserDetailsView UuserDetailsView;

        DataTable CitiesTable;
        public UpdateUserDetails(UserDetailsView userDetailsView)
        {
            InitializeComponent();
            UuserDetailsView = userDetailsView;
            textBoxUserAddress.Text = userDetailsView.UserAddress;
            textBoxusercomments.Text = userDetailsView.UserComments;
            textBoxUserEmail.Text = userDetailsView.UserEmail;
            textBoxuserFirstName.Text = userDetailsView.UserFirstName;
            textBoxUserLastName.Text = userDetailsView.UserLastName;
            textBoxUserPhone1.Text = userDetailsView.UserPhone1;
            textBoxUserPhone2.Text = userDetailsView.UserPhone2;
            textBoxVetName.Text = userDetailsView.VeterinarName;
            textBoxVetPhone.Text = userDetailsView.VeterinarPhone1;
            textBoxusercomments.Text = userDetailsView.UserComments;
            comboBoxUserCityName.Text = userDetailsView.UserCity;
            checkBoxAccept.Checked = userDetailsView.Acceptmessages;

            GetFileCities();
            populateCBCities();

        }
        private void GetFileCities()
        {
            DataService dataService = new DataService();
            CitiesTable = dataService.GetFileCities();

        }
        private void populateCBCities()
        {
            for (int i = 0; i < CitiesTable.Rows.Count; i++)
            {

                comboBoxUserCityName.Items.Add(CitiesTable.Rows[i]["Heb"]);
            }
            comboBoxUserCityName.Text = UuserDetailsView.UserCity;
            //comboBoxUserCityName.Items.Insert(0, "בחר עיר");
            //comboBoxUserCityName.SelectedIndex = 0;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (ErrorProviderExtensions.HasErrors(errorProvider1))
                return;
                       
            UuserDetailsView.UserAddress = textBoxUserAddress.Text;
            UuserDetailsView.UserCity = comboBoxUserCityName.Text;
            UuserDetailsView.UserComments = textBoxusercomments.Text;
            UuserDetailsView.UserEmail = textBoxUserEmail.Text;
            UuserDetailsView.UserFirstName = textBoxuserFirstName.Text;
            UuserDetailsView.UserLastName = textBoxUserLastName.Text;
            UuserDetailsView.UserComments = textBoxusercomments.Text;
            UuserDetailsView.UserPhone1 = textBoxUserPhone1.Text;
            UuserDetailsView.UserPhone2 = textBoxUserPhone2.Text;
            UuserDetailsView.VeterinarName = textBoxVetName.Text;
            UuserDetailsView.VeterinarPhone1 = textBoxVetPhone.Text;
            UuserDetailsView.Acceptmessages = checkBoxAccept.Checked;
            UuserDetailsView.UserComments = textBoxusercomments.Text;
            
            try
            {
                DataService dataService = new DataService();

                dataService.UpdateUser(UuserDetailsView);
                this.Hide();
                Form1 f1 = new Form1(LogIn.loginView);
                f1.Show();
                //MessageBox.Show("עודכן בהצלחה");
            }
            catch (WebException ex)
            {
                
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}
