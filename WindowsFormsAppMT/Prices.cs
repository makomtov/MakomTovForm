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
    public partial class Prices : WindowsFormsAppMT.Menu
    {
        //public Prices()
        //{
        //    //this.TopMost = true;
        //    this.WindowState = FormWindowState.Maximized;

        //    if (LogIn.token == null)
        //    {
        //        this.Close();
        //        this.Hide();
        //        LogIn logIn = new LogIn();
        //        logIn.Show();


        //    }
        //    InitializeComponent();
        //    //   panelContainer.Anchor = System.Windows.Forms.AnchorStyles.Left;
        //    GetFileInformation();
        //    //GetFileOpenHours();
        //    //populateCBShift();
        //}
        public List<PricesView> listPrices;
        public Prices(LoginView loginView)
        {

            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            if (LogIn.token == null)
            {

                this.Hide();
                LogIn logIn = new LogIn();
                logIn.Show();


            }
            else
            {
                InitializeComponent();
                GetFileInformation(loginView);

            }

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
                listPrices = dataService.GetPrices(loginView);

                populateGridView(listPrices);
               
               // populatecomboBoxFindUser();
            }
            catch (WebException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void populateGridView(List<PricesView> list)
        {
            BindingList<PricesView> pricesViewsBind = new BindingList<PricesView>(list);
            bindingSourcePrices.DataSource = pricesViewsBind;
            dataGridView1.AutoGenerateColumns = false;
            //int size = 0;
            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    size += column.Width;
            //}


            dataGridView1.DataSource = bindingSourcePrices;
            //dataGridView1.Width = size + 100;
        }
        private PricesView FindPriceLineInList(int num, List<PricesView> list)
        {
            PricesView price = list.Find(item => item.Id == num);
            return price;
        }

       
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (!dataGridView1.Rows[e.RowIndex].IsNewRow))
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    PricesView price = FindPriceLineInList(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()), listPrices);
                    //        int ind = CheckinList(listOrder, int.Parse(dataGridViewOrders.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString()));
                    if (e.ColumnIndex == 1)  //Days-'Column index=1'
                    {
                        price.Days = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Days"].Value.ToString());

                    }
                    if (e.ColumnIndex == 3)  //Dogs-'Column index=1'
                    {
                        price.Dogs = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Dogs"].Value.ToString());

                    }
                    populateGridView(listPrices);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PriceService priceService = new PriceService();
                priceService.UpdatePricesByManager(listPrices);
                MessageBox.Show("עודכן בהצלחה");
            }
            catch (WebException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow newRow = this.dataGridView1.Rows[e.RowIndex];
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex)
            {
                //PricesView pricesView = new PricesView();
                int rows = listPrices.Count;
                listPrices[rows - 1].Id = listPrices[rows - 2].Id + 1;
              //  listPrices.Add(pricesView);
            }
        }
    }
}
