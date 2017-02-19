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
    public partial class frmEditProduct : Form
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            disp_product();
        }
        public void disp_product()
        {
            conn.Open();
            string show = "select * from sProduct";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridViewProduct.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewProduct.Rows.Add();
                dataGridViewProduct.Rows[n].Cells[0].Value = item["Product_id"].ToString();
                dataGridViewProduct.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                dataGridViewProduct.Rows[n].Cells[2].Value = item["Company"].ToString();
                dataGridViewProduct.Rows[n].Cells[3].Value = item["Category"].ToString();
                dataGridViewProduct.Rows[n].Cells[4].Value = item["Price"].ToString();
                dataGridViewProduct.Rows[n].Cells[5].Value = item["Quantity"];
                dataGridViewProduct.Rows[n].Cells[6].Value = item["Wholseler"].ToString();
            }
            conn.Close();
        }
      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = "delete from sProduct where Product_Name='" + txtProductName.Text + "' ";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Data is Deleted Successfully");
            disp_product();
            txtSearchP.Text = ""; txtProductName.Text = ""; txtNewPrice.Text = "";
            txtNewQuant.Text = ""; txtNewWhole.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del = @"UPDATE       sProduct
                 SET  Price ='" + txtNewPrice.Text + "', Quantity ='" + txtNewQuant.Text + "', Wholseler ='" + txtNewWhole.Text + "' WHERE (Product_Name = '" + txtProductName.Text + "')";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Data is Updated Successfully");
            disp_product();
            txtSearchP.Text = ""; txtProductName.Text = ""; txtNewPrice.Text = "";
            txtNewQuant.Text = ""; txtNewWhole.Text = "";
        }

        private void txtSearchP_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string show = "select * from sProduct where Product_Name like '" + txtSearchP.Text + "%'";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridViewProduct.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewProduct.Rows.Add();
                dataGridViewProduct.Rows[n].Cells[0].Value = item["Product_id"].ToString();
                dataGridViewProduct.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                dataGridViewProduct.Rows[n].Cells[2].Value = item["Company"].ToString();
                dataGridViewProduct.Rows[n].Cells[3].Value = item["Category"].ToString();
                dataGridViewProduct.Rows[n].Cells[4].Value = item["Price"].ToString();
                dataGridViewProduct.Rows[n].Cells[5].Value = item["Quantity"];
                dataGridViewProduct.Rows[n].Cells[6].Value = item["Wholseler"].ToString();
            }
            conn.Close();
            //disp_product();
        }

        private void dataGridViewProduct_MouseClick(object sender, MouseEventArgs e)
        {
            txtProductName.Text = dataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtNewPrice.Text = dataGridViewProduct.SelectedRows[0].Cells[4].Value.ToString();
            txtNewQuant.Text = dataGridViewProduct.SelectedRows[0].Cells[5].Value.ToString();
            txtNewWhole.Text = dataGridViewProduct.SelectedRows[0].Cells[6].Value.ToString();
        }    
    }
}
