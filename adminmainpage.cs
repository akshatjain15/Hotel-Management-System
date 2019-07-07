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
    public partial class adminmainpage : Form
    {
        public adminmainpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "select CITY_NAME,count(*) as  no_of_times_searched from search group by CITY_NAME ORDER BY no_of_times_searched desc";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "search");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "search";
            dataGridView1.Refresh();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = "select e.name,e.city,e.HOTELID,a.name,a.FROMM,a.TOO,a.EMAIL_ID,a.BOOKINGID,a.CONTACT_NO from hotel e ,NEWBOOKING a where  e.hotelid=a.hotelid  ";
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

            string sql = "select * from cancel";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminpayment a = new adminpayment();
            a.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = "select * from sign ";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            badmin b = new badmin();
            b.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminhotel a = new adminhotel();
            a.Show();
        }

        private void adminmainpage_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }

       
    }
}
