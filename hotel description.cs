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
    public partial class hotel_description : Form
    {
        public hotel_description()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bang2 b = new bang2();
            b.ShowDialog();
        }

        private void hotel_description_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
