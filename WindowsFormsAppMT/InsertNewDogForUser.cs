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
    public partial class InsertNewDogForUser : WindowsFormsAppMT.Menu
    {
        DataTable DogTypesTBL;
        UserDetailsView userDetailsView;
        public InsertNewDogForUser(UserDetailsView userDetailsView)
        {
            InitializeComponent();
            this.userDetailsView = userDetailsView;
            labelName.Text += userDetailsView.UserFirstName + " " + userDetailsView.UserLastName;
            if (LogIn.token == null)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
            }
            GetFileDogTypes();
            populateCBDogType();
            populateCBDogFriendlyWith();

        }

        private void populateCBDogType()
        {
            for (int i = 0; i < DogTypesTBL.Rows.Count; i++)
            {

                comboBoxDogType.Items.Add(DogTypesTBL.Rows[i]["type_Text"]);
            }

            comboBoxDogType.Items.Insert(0, "בחר גזע");
            comboBoxDogType.SelectedIndex = 0;
        }
        private void populateCBDogFriendlyWith()
        {
            
            for (int i = 1; i <=3; i++)
            {

                comboBoxDogFriendlyWith.Items.Add((dogFriendlyWith)i);
            }

            comboBoxDogFriendlyWith.Items.Insert(0, "בחר ");
            comboBoxDogFriendlyWith.SelectedIndex = 0;
        }
        private void GetFileDogTypes()
        {
            DataService dataService = new DataService();
            DogTypesTBL = dataService.GetFileDogTypes();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ErrorProviderExtensions.HasErrors(errorProvider1))
                return;
            DogDetailsView dogDetailsView = new DogDetailsView();
            dogDetailsView.DogBirthDate = dateTimePickerDogBirthDate.Value;
            dogDetailsView.DogComments = textBoxusercomments.Text;
            dogDetailsView.DogDig = checkBoxDogDig.Checked;
            dogDetailsView.DogFriendlyWith =(int) (dogFriendlyWith)Enum.Parse(typeof(dogFriendlyWith), comboBoxDogFriendlyWith.Text); 
            dogDetailsView.DogGender = comboBoxDogGender.Text;
            dogDetailsView.DogJump = checkBoxDogJump.Checked;
            dogDetailsView.DogName = textBoxDogName.Text;
            dogDetailsView.DogNeuter = checkBoxDogNeuter.Checked;
            dogDetailsView.DogRabiesVaccine = dateTimePickerDogRabiesVaccine.Value;
            dogDetailsView.DogShvav = textBoxDogShvav.Text;
            dogDetailsView.DogStatus = 21;
            dogDetailsView.DogType = comboBoxDogType.Text;
            dogDetailsView.DogUserID = userDetailsView.UserID;


            try
            {
                DataService dataService = new DataService();

                dataService.AddOneUserDog(dogDetailsView);
                //  this.labelError.Text = "נוסף בהצלחה";
                MessageBox.Show("נוסף בהצלחה");
            }
            catch (WebException ex)
            {
                
                MessageBox.Show(ex.Message);
              
            }

        }
    }
}
