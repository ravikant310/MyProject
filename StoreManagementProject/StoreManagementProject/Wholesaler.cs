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
    public partial class Wholesaler : Form
    {
        public Wholesaler()
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
                    MessageBox.Show("Provide Valid Email Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.SelectAll();
                    e.Cancel = true;
                }

            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        public void disp_Whole()
        {
            conn.Open();
            string show = "select * from sWholesaler";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridViewWhole.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewWhole.Rows.Add();
                dataGridViewWhole.Rows[n].Cells[0].Value = item["Whole_Id"].ToString();
                dataGridViewWhole.Rows[n].Cells[1].Value = item["Whole_Name"].ToString();
                dataGridViewWhole.Rows[n].Cells[2].Value = item["Email"].ToString();
                dataGridViewWhole.Rows[n].Cells[3].Value = item["Contact"].ToString();
                dataGridViewWhole.Rows[n].Cells[4].Value = item["Address"].ToString();
                dataGridViewWhole.Rows[n].Cells[5].Value = item["City"].ToString();
                dataGridViewWhole.Rows[n].Cells[6].Value = item["State"].ToString();
            }
            conn.Close();
        }

        private void Wholesaler_Load(object sender, EventArgs e)
        {
            disp_Whole();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtWholeName.Text != "" && txtWholeName.Text != " ")
            {
               
                    conn.Open();
                    string Wadd = "insert into sWholesaler values('" + txtWholeName.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtCity.Text + "','" + txtState.Text + "')";
                    SqlCommand addwcmd = new SqlCommand(Wadd, conn);
                    addwcmd.ExecuteNonQuery();
                    conn.Close();
                    txtWholeName.Text = ""; txtemail.Text = "";
                    ; txtcontact.Text = ""; txtaddress.Text = ""; txtCity.Text = ""; txtState.Text = "";
                    disp_Whole();
                    MessageBox.Show("Wholesaler is Added Successfully");
             }
            
                else
                MessageBox.Show("Please Enter Wholesaler Name");
        }

        private void dataGridViewWhole_MouseClick(object sender, MouseEventArgs e)
        {
            txtWholeName.Text = dataGridViewWhole.SelectedRows[0].Cells[1].Value.ToString();
            txtemail.Text = dataGridViewWhole.SelectedRows[0].Cells[2].Value.ToString();
            txtcontact.Text = dataGridViewWhole.SelectedRows[0].Cells[3].Value.ToString();
            txtaddress.Text = dataGridViewWhole.SelectedRows[0].Cells[4].Value.ToString();
            txtCity.Text = dataGridViewWhole.SelectedRows[0].Cells[5].Value.ToString();
            txtState.Text = dataGridViewWhole.SelectedRows[0].Cells[6].Value.ToString();      
        }

        private void btnUpdateWhole_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = @"UPDATE       sWholesaler
                 SET  EMail ='" + txtemail.Text + "', Contact ='" + txtcontact.Text + "', Address ='" + txtaddress.Text + "',City ='" + txtCity.Text + "' WHERE (Whole_Name = '" + txtWholeName.Text + "')";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            txtWholeName.Text = ""; txtemail.Text = "";
            ; txtcontact.Text = ""; txtaddress.Text = ""; txtCity.Text = ""; txtState.Text = "";
            disp_Whole();
            MessageBox.Show("Wholesaler is Updated Successfully");
        }

        private void btnRemoveWhole_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = "delete from sWholesaler where Whole_Name='" + txtWholeName.Text + "' ";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            txtWholeName.Text = ""; txtemail.Text = "";
            ; txtcontact.Text = ""; txtaddress.Text = ""; txtCity.Text = ""; txtState.Text = "";
            disp_Whole();
            MessageBox.Show("Wholesaler is Deleted Successfully");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
