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
    public partial class UserRegistration : Form 
    {
        public UserRegistration()
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
            if (txtuname.Text != "" && txtuname.Text!=" ")
            {
                if (txtnpass.Text!="" && txtnpass.Text == txtrpass.Text)
                {
                    conn.Open();
                    string uadd = "insert into slogin values('" + txtuname.Text + "','" + txtnpass.Text + "','" + txtusertype.Text + "','" + txtemail.Text + "','"+txtEmailPass.Text+"','" + txtcontact.Text + "','" + txtaddress.Text + "')";
                    SqlCommand adducmd = new SqlCommand(uadd, conn);
                    adducmd.ExecuteNonQuery();
                    conn.Close();
                    txtuname.Text = ""; txtnpass.Text = ""; txtrpass.Text = ""; txtemail.Text = "";
                    txtusertype.Text = null; txtcontact.Text = ""; txtaddress.Text = ""; txtemail.Text = "";
                    MessageBox.Show("New User Is Created Successfully");
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
                MessageBox.Show("Please Enter User Name");
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
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
            txtuname.AutoCompleteCustomSource = sc;
            txtuname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = "delete from slogin where User_Name='" + txtuname.Text + "' ";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User is Deleted Successfully");
            txtuname.Text = ""; txtnpass.Text = ""; txtrpass.Text = ""; txtemail.Text = "";
            txtusertype.Text = null; txtcontact.Text = ""; txtaddress.Text = ""; txtemail.Text = "";
        }              
    }
}
