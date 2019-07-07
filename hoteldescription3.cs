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
    public partial class hoteldescription3 : Form
    {
        public hoteldescription3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bang2 ba = new bang2();
            ba.Show();
            this.Hide();
        }

        private void hoteldescription3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bang2 b2 = new bang2();
            b2.Show();
            this.Hide();
        }
    }
}
