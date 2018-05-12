using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace WindowsFormsAppMT
{
    public partial class MailForm : Menu
    {
        Users users;
        string contacts;
        public MailForm()
        {
            InitializeComponent();
            if (LogIn.token == null)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
            }
            //Users users = new Users();
            //users.eventIshur+= new EventHandler(Contacts);
        }
        public MailForm(string mailTo)
        {
            InitializeComponent();
            textBoxTo.Text = mailTo;
            if (LogIn.token == null)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
            }
            //Users users = new Users();
            //users.eventIshur += new EventHandler(Contacts);

        }
        private void MailForm_Load(object sender, EventArgs e)
        {
            
        }
        private void Contacts(object sender, EventArgs e)
        {
            AddContacts();
        }

            private void buttonSend_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            NameValueCollection valCollection = new NameValueCollection();
            //valCollection.Add("recipient", textBoxTo.Text);
            valCollection.Add("recipient", textBoxTo.Text);
            // valCollection.Add("cc", "anothertest@test.com"); // Uncomment if you have a CC party
            valCollection.Add("subject", textBoxSubject.Text);
            valCollection.Add("body",textBoxBody.Text);

            if (dataGridViewFiles.Rows.Count != 0)
            {
                foreach(DataGridViewRow row in dataGridViewFiles.Rows)
                valCollection.Add("filename", row.Cells["fileName"].Value.ToString());
                //if (listBox1.Items[0].ToString().Contains("JPG"))

                //{

                //    valCollection.Add("filecontent",imageToByteArray(listBox1.Items[0].ToString()));
                //}
                //else

                valCollection.Add("filecontent", Serialize(dataGridViewFiles.Rows[0].Cells["fileName"].Value.ToString())); // Uncomment if you want to send a file across
            }
            
            client.UploadValues("http://localhost:53698/api/SendMail", "POST", valCollection);
        }
        //public string imageToByteArray(string imageName)
        //{

        //    Image img = Image.FromFile(imageName);
        //    byte[] arr;
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        arr = ms.ToArray();
        //        string imgstr= Convert.ToBase64String(arr);
        //        return imgstr;
        //    }
        //}
        private static string Serialize(string fileName)
        {
            //if (fileName.Contains("JPG"))
            //{
            //    byte[] bytes = System.IO.File.ReadAllBytes(fileName);
            //    return Convert.ToBase64String(bytes);
            //}
            //else
                using (FileStream reader = new FileStream(fileName, FileMode.Open))

                {
                    byte[] buffer = new byte[reader.Length];
                    reader.Read(buffer, 0, (int)reader.Length);
                    return Convert.ToBase64String(buffer);
                }
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                object[] arr = new object[] { openFileDialog.FileName };
                dataGridViewFiles.Rows.Add(arr);
            }
        }

        private void MailForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataGridViewRow row = senderGrid.Rows[e.RowIndex];

            if (senderGrid.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
            {

                dataGridViewFiles.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonTo_Click(object sender, EventArgs e)
        {
           
            //Create a new instance of the MDI child template form
             users = new Users();

            //Set parent form for the child window 
            users.MdiParent = this;
            users.eventIshur += new EventHandler(Contacts);
            //Display the child window
            users.Show();
           // contacts = users.GetMyResult;
    }
        private void AddContacts()
        {
           
            string[] contactsArr = users.GetMyResult.Split(',');
            if (contactsArr.Length > 0) textBoxTo.Text += ",";
            foreach (string contact in contactsArr)
            {
                if (textBoxTo.Text.IndexOf(contact.Trim()) < 0)
                    textBoxTo.Text += contact.Trim() + ",";

            }
            if (textBoxTo.Text.LastIndexOf(',') >= 0)
                textBoxTo.Text = textBoxTo.Text.Remove(textBoxTo.Text.LastIndexOf(','));
        }
    }
}
