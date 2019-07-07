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
    public partial class useradmin : Form
    {
        public useradmin()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
           
            admin a1 = new admin();
            a1.ShowDialog();
            this.Visible = false;
           
        }

        private void b2_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.ShowDialog();
            this.Visible = false;
        }

        private void useradmin_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
