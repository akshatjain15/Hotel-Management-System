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
    public partial class newbooking : Form
    {
        public static string p;
        int a;
        public newbooking()
        {
            InitializeComponent();
        }
        private void newbooking_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            t2.Text = Login.pt;
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
                oledbAdapter.SelectCommand = new OleDbCommand("select max(bookingid) from newbooking", connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    string x = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    int y = Convert.ToInt32(x);
                    y=y+1;
                    a=y;
       
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int xyz = bang2.passingText;int abc= del2.passingText ,pqr;
            if(xyz==0)
            {
              pqr = abc;
            }
            else
            {
                pqr = xyz;
            }
            p = t4.Text;
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "SELECT * FROM newbooking";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "newbooking");
            if (t1.Text == "" || t2.Text == "" || t3.Text == "" || t4.Text == "")
            {
                MessageBox.Show("Enter values");
            }
            else
            {
                string sql1 = "Insert into newbooking VALUES ('" + pqr + "' , '" + t1.Text + "', '" + t2.Text + "', '" + t3.Text + "', '" + t4.Text + "', '" + d1.Text + "', '" + d2.Text + "' ,'" + a + "')";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
           
                dataadapter.Fill(ds, "newbooking");
                connection.Close();
                this.Hide();
                payment p1 = new payment();
                p1.ShowDialog();
            }


        }

        

       
    }
}
