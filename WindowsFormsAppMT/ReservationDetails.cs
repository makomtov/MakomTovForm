using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppMT
{
    public partial class ReservationDetails :Form
    {
        public ReservationDetails()
        {
            InitializeComponent();
        }
        public ReservationDetails(string orderNumber)
        {
            InitializeComponent();
            textBoxOrderNumber.Text = orderNumber;
            
        }

    }
}
