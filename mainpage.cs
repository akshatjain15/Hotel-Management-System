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
    public partial class mainpage : Form
    {
        public string mumbai, MUMBAI, jammu, JAMMU, kolkata, KOLKATA, bangalore, BANGALORE, delhi, DELHI, JAIPUR, jaipur, kanyakumari, KANYAKUMARI, agra, AGRA;
        public mainpage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage m1 = new mainpage();
            m1.Show();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupform s1 = new signupform();
            s1.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            bang b1 = new bang();
            b1.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bang b1 = new bang();
            b1.Show();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mum m1 = new mum();
            m1.Show();
           

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mum m1 = new mum();
            m1.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            del d1 = new del();
            d1.Show();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            del d1 = new del();
            d1.Show();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            aagra a1 = new aagra();
            a1.Show();
           
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            aagra a1 = new aagra();
            a1.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            kashmir j1 = new kashmir();
            j1.Show();
            

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            kashmir j1 = new kashmir();
            j1.Show();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            kan kk1 = new kan();
            kk1.Show();
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            kan kk1 = new kan();
            kk1.Show();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            jai j1 = new jai();
            j1.Show();
            
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            jai j1 = new jai();
            j1.Show();
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            kol k1 = new kol();
            k1.Show();
            
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            kol k1 = new kol();
            k1.Show();
            
        }
        public void ClearControls()
        {
            t1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (t1.Text == "mumbai" || t1.Text == "MUMBAI")
            {
                this.Hide();
                mum m1 = new mum();
                m1.Show();
                
            }
            else if (t1.Text == "bangalore" || t1.Text == "BANGALORE")
            {
                this.Hide();
                bang b1 = new bang();
                b1.Show();
                
            }
            else if (t1.Text == "agra" || t1.Text == "AGRA")
            {
                this.Hide();
                aagra a1 = new aagra();
                a1.Show();
                
            }
            else if (t1.Text == "delhi" || t1.Text == "DELHI")
            {
                this.Hide();
                del d1 = new del();
                d1.Show();
                
            }
            else if (t1.Text == "kanyakumari" || t1.Text == "KANYAKUMARI")
            {
                this.Hide();
                kan kk1 = new kan();
                kk1.Show();
                
            }
            else if (t1.Text == "jaipur" || t1.Text == "JAIPUR")
            {
                this.Hide();
                jai j1 = new jai();
                j1.Show();
                
            }
            else if (t1.Text == "jammu" || t1.Text == "JAMMU")
            {
                this.Hide();
                kashmir j1 = new kashmir();
                j1.Show();
                
            }
            else if (t1.Text == "kolkata" || t1.Text == "KOLKATA")
            {
                this.Hide();
                kol k1 = new kol();
                k1.Show();
                
            }
            else
            {
               
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=7608956;";
                string sql = "SELECT * FROM search";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "search");
                if (t1.Text == "")
                {
                    MessageBox.Show("Enter a city name");
                }
                else
                {
                    MessageBox.Show("sorry,we don't serve this city yet");
                    string sql1 = "Insert into search VALUES ('" + t1.Text + "')";
                    dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    dataadapter.Fill(ds, "search");
                    connection.Close();
                }
                ClearControls();
            }


        }

        private void mainpage_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            useradmin u = new useradmin();
            u.Show();
            
        }
    }



}


 

