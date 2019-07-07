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
    public partial class bang2 : Form
    {
        public static int passingText,pt;
        public bang2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e )
        {
            passingText = 11;
            pt = 500;
            newbooking n1 = new newbooking();
            n1.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainpage2 m2 = new mainpage2();
            m2.ShowDialog();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hotel_description h = new hotel_description();
            h.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passingText = 12;
            pt = 700;
            newbooking n1 = new newbooking();
            n1.ShowDialog();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passingText = 13;
            pt = 1000;
            newbooking n1 = new newbooking();
            n1.ShowDialog(); 
        }

        private void bang2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hotel_descriptio2 h2 = new hotel_descriptio2();
            h2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            hoteldescription3 h3 = new hoteldescription3();
            h3.Show();
            this.Hide();
        }
    }
}
