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
using System.Data.SqlClient;




namespace HOTELMANAGEMENT
{
    public partial class signupform : Form
    {
        public static string passingText;
        public signupform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://mail.google.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.ShowDialog();
            this.Hide();
        }
        public void ClearControls()
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            string sql = "SELECT * FROM sign";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "sign");
            if (t1.Text != "" && t2.Text != "" && t3.Text != "" && t4.Text != "")
            {
                if (t3.Text.ToString().Trim().ToLower() == t4.Text.ToString().Trim().ToLower())
                {

                    string UserName = t2.Text;
                    passingText = t2.Text;
                    string Password = Cryptography.Encrypt(t3.Text.ToString());
                    string sql1 = "insert into sign values('" + t1.Text + "','" + UserName + "','" + Password + "')";

                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                  
                    dataadapter.Fill(ds, "sign");
                    MessageBox.Show("signed up  successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    this.Hide();
                    Login l= new Login();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
