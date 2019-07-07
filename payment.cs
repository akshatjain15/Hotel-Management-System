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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        public void ClearControls()
        {
            t1.Text = "";
            t2.Text = "";
            c1.Text = "";
        }
       
        private void payment_Load(object sender, EventArgs e)
        {
            
            int z = bang2.pt;
            string a = newbooking.p;
            int b = Convert.ToInt16(a);
            int c = b * z;
            t2.Text = Convert.ToString(c);
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
                oledbAdapter.SelectCommand = new OleDbCommand("select max(bookingid) from payment", connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    string x= ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    int y = Convert.ToInt32(x);
                    y=y+1;
                   t1.Text = Convert.ToString(y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "SELECT * FROM payment";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "payment");
            if (t1.Text == "" || t2.Text == "")
            {
                MessageBox.Show("Enter values");
            }
            else
            {
                string sql1 = "Insert into payment VALUES ('" + t1.Text + "', '" + t2.Text + "', '" + c1.Text + "' )";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                ClearControls();
                MessageBox.Show("successfull !! ");
                dataadapter.Fill(ds, "payment");
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage m1 = new mainpage();
            m1.ShowDialog();
        }

       

        

      
    }
}
