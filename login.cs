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
    public partial class Login : Form
    {
        public static string pt;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            t1.Text = signupform.passingText;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.ShowDialog();
            this.Visible = false;
        }
        public void ClearControls()
        {
            t1.Text = "";
            t2.Text = "";
     
        }

        private void b1_Click(object sender, EventArgs e)
        {
            pt = t1.Text;
             string Password = "";
            bool IsExist = false;
            string connetionString = null;
            OleDbConnection oledbCnn;
            OleDbCommand oledbCmd;
            string sql = null;

            connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
            sql = "select * from sign where email_id='" + t1.Text + "'";
            oledbCnn = new OleDbConnection(connetionString);
            oledbCnn.Open();
            oledbCmd = new OleDbCommand(sql, oledbCnn);
            OleDbDataReader sdr = oledbCmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(2);  //get the user password
                IsExist = true;
            }
            oledbCnn.Close();
            if (IsExist)  //if record exis in database   
            {
                if (Cryptography.Decrypt(Password).Equals(t2.Text))
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainpage2 m2=new mainpage2();
                    m2.ShowDialog();
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else  //showing the error message if user credential is wrong  
            {
                MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            oledbCmd.Dispose();
            oledbCnn.Close();
            
                
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           signupform s1 = new signupform();
            s1.ShowDialog();
            this.Visible = false;
        }

     
    }
}
