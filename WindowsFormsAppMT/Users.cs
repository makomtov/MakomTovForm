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

namespace WindowsFormsAppMT
{
    public partial class Users : Form
    {
        public EventHandler eventIshur;
        public string GetMyResult = "";
        private BindingSource bindingSource1 = new BindingSource();
        List<UserDetailsView> listUsers;
        DataTable DataTableUsers;
        public Users()
        {
            InitializeComponent();
            DataService dataService = new DataService();
            listUsers = dataService.GetUsersInformation(LogIn.loginView);
            DataTableUsers = convertListToTable(listUsers);
            bindingSource1.DataSource = DataTableUsers;
            dataGridViewContacts.AutoGenerateColumns = false;
            int size = 0;
            foreach (DataGridViewColumn column in dataGridViewContacts.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                size += column.Width;
            }


            dataGridViewContacts.DataSource = bindingSource1;
            dataGridViewContacts.Width = size + 100;
        }
        private DataTable convertListToTable(List<UserDetailsView> list)
        {

            DataTableUsers = new DataTable();
            DataTableUsers.Columns.Add(new DataColumn("Name"));
            DataTableUsers.Columns.Add(new DataColumn("UserEmail"));
            foreach (UserDetailsView user in list)
            {

                DataRow dr = DataTableUsers.NewRow();
                dr["Name"] = user.UserFirstName + " " + user.UserLastName;
                dr["UserEmail"] = user.UserEmail;

                DataTableUsers.Rows.Add(dr);



            }
            return DataTableUsers;

        }

        private void buttonIshur_Click(object sender, EventArgs e)
        {
            dataGridViewContacts.NotifyCurrentCellDirty(true);

            eventIshur?.Invoke(this, e);
            this.Close();
          //  Senders();
        }

        private void Senders()
        {

            //foreach (DataGridViewRow dg in dataGridViewContacts.Rows)
            //{
            //    object 
            //    bool add = bool.Parse(dg.Cells["Choose"].Value.ToString());
            //    if (add)

            //        GetMyResult += dg.Cells["UserEmail"].ToString()+",";

            //}
            //GetMyResult = GetMyResult.Remove(GetMyResult.LastIndexOf(','));
        }

        private void dataGridViewContacts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dataGridViewContacts.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewContacts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)  //Training-'Column index=7'
                {
                    if (bool.Parse(dataGridViewContacts.Rows[e.RowIndex].Cells["Choose"].Value.ToString()))
                    {
                        GetMyResult += dataGridViewContacts.Rows[e.RowIndex].Cells["UserEmail"].Value.ToString().Trim() + ",";
                    }
                }
            }
        }
    }
}
