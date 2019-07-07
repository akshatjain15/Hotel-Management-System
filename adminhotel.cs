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
    public partial class adminhotel : Form
    {
        public void ClearControls()
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
        }
        public adminhotel()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "SELECT * FROM hotel";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "hotel");
            if (t3.Text == "" || t4.Text == "" || t5.Text == "" || t6.Text == "")
            {
                MessageBox.Show("Enter values");
            }
            else
            {
                string sql1 = "Insert into hotel VALUES ('" + t3.Text + "', '" + t4.Text + "', '" + t5.Text + "', '" + t6.Text + "' )";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                ClearControls();
                MessageBox.Show("successfull !! ");
                dataadapter.Fill(ds, "hotel");
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "select * from hotel where hotelid = '" + t1.Text + "' ";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "hotel");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "hotel";
            dataGridView1.Refresh();
            ClearControls();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "select * from hotel where city = '" + t2.Text + "' ";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "hotel");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "hotel";
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

        private void adminhotel_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                oledbAdapter.SelectCommand = new OleDbCommand("select max(hotelid) from hotel", connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    string x = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    int y = Convert.ToInt32(x);
                    y = y + 1;
                    t3.Text = Convert.ToString(y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            string sql = null;
            connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            connection = new OleDbConnection(connetionString);
            sql = "update hotel set totalrooms = '" + t8.Text + "' where hotelid= '" + t7.Text + "'";
            try
            {
                connection.Open();
                oledbAdapter.UpdateCommand = connection.CreateCommand();
                oledbAdapter.UpdateCommand.CommandText = sql;
                oledbAdapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Updated !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ClearControls();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminmainpage b = new adminmainpage();
            b.Show();
            this.Hide();
        }
    }
}
