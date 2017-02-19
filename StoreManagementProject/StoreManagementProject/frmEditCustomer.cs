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
    public partial class frmEditCustomer : Form
    {
        public frmEditCustomer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");

        public void disp_customer()
        {
            conn.Open();
            string show = "select * from Customer";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridViewCustomer.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewCustomer.Rows.Add();
                dataGridViewCustomer.Rows[n].Cells[0].Value = item["Cust_id"].ToString();
                dataGridViewCustomer.Rows[n].Cells[1].Value = item["Customer_Name"].ToString();
                dataGridViewCustomer.Rows[n].Cells[2].Value = item["Gender"].ToString();
                dataGridViewCustomer.Rows[n].Cells[3].Value = item["E_Mail"].ToString();
                dataGridViewCustomer.Rows[n].Cells[4].Value = item["Contact"].ToString();
                dataGridViewCustomer.Rows[n].Cells[5].Value = item["Address"].ToString();
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = "delete from Customer where Customer_Name='" + txtCustomerName.Text + "' ";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer is Deleted Successfully");
            disp_customer();
            txtSearchC.Text = ""; txtCustomerName.Text = ""; txtNewContact.Text = "";
            txtNewEmail.Text = ""; txtNewAddress.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = @"UPDATE       Customer
                 SET  E_Mail ='" + txtNewEmail.Text + "', Contact ='" + txtNewContact.Text + "', Address ='" + txtNewAddress.Text + "' WHERE (Customer_Name = '" + txtCustomerName.Text + "')";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Customer record is Updated Successfully");
            disp_customer();
            txtSearchC.Text = ""; txtCustomerName.Text = ""; txtNewContact.Text = "";
            txtNewEmail.Text = ""; txtNewAddress.Text = "";
        }

        private void txtSearchC_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string show = "select * from Customer where Customer_Name like '" + txtSearchC.Text + "%'";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridViewCustomer.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewCustomer.Rows.Add();
                dataGridViewCustomer.Rows[n].Cells[0].Value = item["Cust_id"].ToString();
                dataGridViewCustomer.Rows[n].Cells[1].Value = item["Customer_Name"].ToString();
                dataGridViewCustomer.Rows[n].Cells[2].Value = item["Gender"].ToString();
                dataGridViewCustomer.Rows[n].Cells[3].Value = item["E_Mail"].ToString();
                dataGridViewCustomer.Rows[n].Cells[4].Value = item["Contact"].ToString();
                dataGridViewCustomer.Rows[n].Cells[5].Value = item["Address"].ToString();
            }
            conn.Close();
        }

        private void dataGridViewCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            txtCustomerName.Text = dataGridViewCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtNewContact.Text = dataGridViewCustomer.SelectedRows[0].Cells[4].Value.ToString();
            txtNewEmail.Text = dataGridViewCustomer.SelectedRows[0].Cells[3].Value.ToString();
            txtNewAddress.Text = dataGridViewCustomer.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            disp_customer();
        }

       
      
    }
}
