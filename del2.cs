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
    public partial class del2 : Form
    {
        public static int passingText;
        public del2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passingText = 14;
            this.Hide();
            newbooking n1 = new newbooking();
            n1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passingText = 15;
            this.Hide();
            newbooking n1 = new newbooking();
            n1.ShowDialog();
        }

        private void del2_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
