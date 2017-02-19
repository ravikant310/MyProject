using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace StoreManagementProject
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtemail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtemail.Text))
                {
                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.SelectAll();
                    e.Cancel = true;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                if (txtnpass.Text != "" && txtnpass.Text == txtrpass.Text)
                {
                    conn.Open();
                    string chkusr = "select count(*) from slogin where E_Mail='" + txtemail.Text + "'";
                    SqlCommand cmd = new SqlCommand(chkusr, conn);
                    int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    conn.Close();
                    if (temp == 1)
                    {
                        conn.Open();
                        string chkemailpass = "select E_MailPass from slogin where E_Mail='" + txtemail.Text + "'";
                        SqlCommand passcmd = new SqlCommand(chkemailpass, conn);
                        string pass = passcmd.ExecuteScalar().ToString();
                        if (pass == txtEmailpass.Text)
                        {
                            string uppass = @"UPDATE slogin SET Password ='" + txtnpass.Text + "' WHERE (E_Mail = '" + txtemail.Text + "')";
                            SqlCommand uppasscmd = new SqlCommand(uppass, conn);
                            uppasscmd.ExecuteNonQuery();
                            MessageBox.Show("Password is Updated Succespfully");   
                        }
                        else
                        {
                            txtEmailpass.Text = "";
                            txtEmailpass.Focus();
                            MessageBox.Show("Password is incorrect");
                        }
                        conn.Close();
                    }    
                }
                else
                {
                    MessageBox.Show("Re Enter Password");
                    txtnpass.Text = "";
                    txtrpass.Text = "";
                    txtnpass.Focus();
                }
            }
            else
                MessageBox.Show("Please Enter Register Email Id");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
