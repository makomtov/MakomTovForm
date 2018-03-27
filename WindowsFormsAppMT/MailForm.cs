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
        public MailForm()
        {
            InitializeComponent();
        }
        public MailForm(string mailTo)
        {
            InitializeComponent();
            textBoxTo.Text = mailTo;

        }
        private void MailForm_Load(object sender, EventArgs e)
        {
            
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

            if (listBox1.Items.Count != 0)
            {
                valCollection.Add("filename", listBox1.Items[0].ToString());
                //if (listBox1.Items[0].ToString().Contains("JPG"))
                   
                //{

                //    valCollection.Add("filecontent",imageToByteArray(listBox1.Items[0].ToString()));
                //}
                //else
                
                valCollection.Add("filecontent", Serialize(listBox1.Items[0].ToString())); // Uncomment if you want to send a file across
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
                listBox1.Items.Add(openFileDialog.FileName);
            }
        }

        private void MailForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
