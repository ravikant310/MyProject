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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");
        string gender = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                gender = rbMale.Text;
            else
                gender = rbFemale.Text;
            if (txtcname.Text != "" && txtContact.Text!="" )
            {
                conn.Open();
                string add = "insert into Customer values('" + txtcname.Text + "','"+gender+"','"+txtEmail.Text+"','"+txtContact.Text+"','"+txtAddress.Text+"')"; 
                SqlCommand addcmd = new SqlCommand(add, conn);
                addcmd.ExecuteNonQuery();
                conn.Close();
                txtcname.Text = ""; txtEmail.Text = ""; txtContact.Text = ""; txtAddress.Text = "";            
                MessageBox.Show("Customer Data is Added Successfully");
            }
            else
                MessageBox.Show("Please Enter All The Details");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Please Provide Valid E-Mail ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }

            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
