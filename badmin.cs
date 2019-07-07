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
    public partial class badmin : Form
    {
        public void ClearControls()
        {
            t1.Text = "";
            t2.Text = "";

        }
        public badmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "select * from newbooking where hotelid = '" + t1.Text + "' ";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "newbooking");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "newbooking";
            dataGridView1.Refresh();
            ClearControls();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "select * from hotel";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "hotel");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "hotel";
            dataGridView1.Refresh();
            connection.Close();
        }

        private void badmin_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminmainpage a = new adminmainpage();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "select * from newbooking where bookingid = '" + t2.Text + "' ";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "newbooking");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "newbooking";
            dataGridView1.Refresh();
            ClearControls();
            connection.Close();
        }
    }
}
