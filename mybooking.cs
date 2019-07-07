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
    public partial class mybooking : Form
    {
        public mybooking()
        {
            InitializeComponent();
        }

        private void mybooking_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            t1.Text = Login.pt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = "select e.name,e.city,a.name,a.FROMM,a.TOO,a.BOOKINGID from hotel e ,NEWBOOKING a where  e.hotelid=a.hotelid and a.EMAIL_ID='" + t1.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();




        }
    }
}
