using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace HOTELMANAGEMENT
{
    public partial class adminpayment : Form
    {
        public adminpayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = "select * from payment ";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminmainpage a = new adminmainpage();
            a.Show();
            this.Hide();
        }

        private void adminpayment_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = "select sum(amount) from payment ";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = " select n.hotelid,h.name as hotelname,n.bookingid,p.amount,p.metho as Method from hotel h,newbooking n,payment p where n.HOTELID=h.HOTELID and n.bookingid=p.BOOKINGID and h.hotelid= '" + t1.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = " select sum(p.AMOUNT),h.name ,h.CITY from hotel h,payment p ,newbooking n where n.HOTELID=h.HOTELID and n.bookingid=p.BOOKINGID GROUP BY h.name,h.CITY ";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }
    }
}
