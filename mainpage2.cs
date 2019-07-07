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
    public partial class mainpage2 : Form
    {
        public mainpage2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage m1 = new mainpage();
            m1.ShowDialog();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cancelbooking c1 = new cancelbooking();
            c1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            bang2 b2 = new bang2();
            b2.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            del2 d2 = new del2();
            d2.ShowDialog();
        }

        public void ClearControls()
        {
            t1.Text = "";
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (t1.Text == "mumbai" || t1.Text == "MUMBAI")
            {
                this.Hide();
                mum2 m2 = new mum2();
                m2.ShowDialog();
            }
            else if (t1.Text == "bangalore" || t1.Text == "BANGALORE")
            {
                this.Hide();
                bang2 b2 = new bang2();
                b2.ShowDialog();
            }
            else if (t1.Text == "agra" || t1.Text == "AGRA")
            {
                this.Hide();
                aagra2 a2 = new aagra2();
                a2.ShowDialog();
            }
            else if (t1.Text == "delhi" || t1.Text == "DELHI")
            {
                this.Hide();
                del2 d2 = new del2();
                d2.ShowDialog();
            }
            else if (t1.Text == "kanyakumari" || t1.Text == "KANYAKUMARI")
            {
                this.Hide();
                kan2 kk2 = new kan2();
                kk2.ShowDialog();
            }
            else if (t1.Text == "jaipur" || t1.Text == "JAIPUR")
            {
                this.Hide();
                jai2 j2 = new jai2();
                j2.ShowDialog();
            }
            else if (t1.Text == "jammu" || t1.Text == "JAMMU")
            {
                this.Hide();
                kashmir2 k3 = new kashmir2();
                k3.ShowDialog();
            }
            else if (t1.Text == "kolkata" || t1.Text == "KOLKATA")
            {
                this.Hide();
                kol2 k2 = new kol2();
                k2.ShowDialog();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bang2 b2 = new bang2();
            b2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            del2 d2 = new del2();
            d2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mybooking m1 = new mybooking();
            m1.ShowDialog();
        }

        private void mainpage2_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

       
    }
}
