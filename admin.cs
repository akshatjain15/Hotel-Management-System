using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace HOTELMANAGEMENT
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public void ClearControls()
        {
            t1.Text = "";
            t2.Text = "";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string name=" akshat";
            string pass = "akshat";
            if(t1.Text == "akshat" && t2.Text == "akshat123")
            {
                MessageBox.Show("logged in successfully");
                adminmainpage am1 = new adminmainpage();
                am1.ShowDialog();
                this.Hide();
            }
            else if (t1.Text == "" && t2.Text == "")
            {
                MessageBox.Show("Enter credential");
            }
            else
            {
                MessageBox.Show("wrong credential");
            }
            ClearControls();
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            useradmin u = new useradmin();
            u.Show();
            this.Hide();
        }
    }
}
