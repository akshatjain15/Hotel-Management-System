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
    public partial class cancelbooking : Form
    {
        public cancelbooking()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mainpage2 qw = new mainpage2();
            qw.Show();
            this.Hide();

        }
        private void cancelbooking_Load(object sender, EventArgs e)
        {
           
            t2.Text = Login.pt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
             string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "SELECT * FROM cancel";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "cancel");
            if (t1.Text == "" || t2.Text == "" ||t3.Text == "" || t4.Text == "")
            {
                MessageBox.Show("Enter values");
            }
            else
            {
                string sql1 = "Insert into cancel VALUES ('" + t1.Text + "', '" + t2.Text + "','" + t3.Text + "', '" + t4.Text + "' )";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();

                dataadapter.Fill(ds, "cancel");
            }
            string sql_search = "select count(*) from newbooking where email_id='" + t2.Text + "'";
            OleDbDataAdapter dataadapte = new OleDbDataAdapter(sql_search, connection);

            DataTable dt = new DataTable();
            dataadapte.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("no bookings");
            }
            else
            {
                if (t1.Text == "" || t2.Text == "" || t3.Text == "" || t4.Text == "")
                {
                    MessageBox.Show("Enter values");
                }
                else
                {
                    string sql_delete = "delete from newbooking where email_id='" + t2.Text + "' and bookingid = '" + t3.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(sql_delete, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted");
                }
            }

            connection.Close();

        }

       

        
    }
}
