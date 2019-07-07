using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HOTELMANAGEMENT
{
    public partial class hotel_descriptio2 : Form
    {
        public hotel_descriptio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bang2 qe = new bang2();
            qe.Show();
            this.Hide();
        }
    }
}
