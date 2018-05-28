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
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsAppMT
{
    public partial class LogIn : Form
    {
        public static LoginView loginView;
        public static string token;
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonlogIn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ErrorProviderExtensions.HasErrors(errorProvider1))
                //    return;
                this.ValidateChildren();
               if (ErrorProviderExtensions.HasErrors(errorProvider1))
                        return;

                    loginView = new LoginView();
                    loginView.UserEmail = textBoxEmail.Text;
                    loginView.UserPassword = textBoxPassWord.Text;
                    token = DataService.GetToken(loginView.UserEmail, loginView.UserPassword);

                    DataService dataService = new DataService();
                    UserDetailsView userDetailsView = dataService.GetUser(loginView);

                    //if (userDetailsView != null)
                    //    if(userDetailsView.UserEmail=="liron248@gmail.com")
                    //{
                    this.Hide();
                    Form1 form1 = new Form1(loginView);
                    form1.Show();
               
                   
                //}
                //    else
                //    {
                //        Dogs dogs = new Dogs(userDetailsView.UserID.ToString(), userDetailsView.UserFirstName, userDetailsView.UserLastName);
                //        dogs.Show();
                //    }
            }
            catch (WebException ex)
            {
                //LogIn logIn = new LogIn();
                //logIn.Show();
                MessageBox.Show(ex.Message);
                    }

            catch (Exception ex)
            {
                //LogIn logIn = new LogIn();
                //logIn.Show();
                MessageBox.Show(ex.Message);
            }
        }

       
            private void textBoxEmail_Validating(object sender, CancelEventArgs e)
            {
                ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxEmail, "מייל חובה");
                ErrorProviderExtensions.regexValidate(errorProvider1, textBoxEmail, @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", " מייל לא תקין");
            //if (ErrorProviderExtensions.HasErrors(errorProvider1))
            //    e.Cancel = true;

            }
        private void textBoxPassWord_Validating(object sender, CancelEventArgs e)
        {
            ErrorProviderExtensions.checkEmpty(errorProvider1, textBoxPassWord, "סיסמה חובה");
            //if (ErrorProviderExtensions.HasErrors(errorProvider1))
            //    e.Cancel = true;
        }

    }
        }
 

