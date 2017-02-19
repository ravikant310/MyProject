using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StoreManagementProject
{
    public partial class slogin : Form
    {
        public slogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string chkusr = "select count(*) from slogin where User_name='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(chkusr,conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string chkpass = "select Password from slogin where User_name='" + textBox1.Text + "'";
                SqlCommand passcmd = new SqlCommand(chkpass,conn);
                string pass = passcmd.ExecuteScalar().ToString();
                if (pass == textBox2.Text)
                {
                    this.Hide();
                    Home hm = new Home(Text = textBox1.Text);
                    hm.Show();                    
                }
                else 
                {
                    textBox2.Text = "";
                    textBox2.Focus();
                    MessageBox.Show("Password is incorrect");
                }
            }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    MessageBox.Show("Username is incorrect");
                }
        

            }

        private void slogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close this Application?", "closeing window", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                e.Cancel = true;
        }

        private void linkpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void slogin_Load(object sender, EventArgs e)
        {
            conn.Open();
            string un = @"SELECT User_Name FROM slogin";
            SqlCommand showcmd = new SqlCommand(un, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            foreach (DataRow item in dt.Rows)
            {
                sc.Add(item[0].ToString());
            }
            textBox1.AutoCompleteCustomSource = sc;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            conn.Close();
        }
      
    }
}
