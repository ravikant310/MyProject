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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
     
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtpname.Text != "" && txtcname.Text != "" && txtcat.Text != null && txtprice.Text != "" && txtquant.Value != 0 && cbWhole.Text != "")
            {
                conn.Open();
                string add = "insert into sProduct values('" + txtpname.Text + "','" + txtcname.Text + "','" + txtcat.Text + "'," + txtprice.Text + "," + txtquant.Value + ",'" + cbWhole.Text + "')";
                SqlCommand addcmd = new SqlCommand(add, conn);
                addcmd.ExecuteNonQuery();
                conn.Close();
                txtpname.Text = ""; txtcname.Text = ""; txtcat.Text = null; ;
                txtprice.Text = ""; txtquant.Value = 0; cbWhole.Text = "";
                MessageBox.Show("Product Data is Inserted Successfully");
            }
            else
                MessageBox.Show("Please Enter All Product Details...");
           
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Whole_Name FROM sWholesaler", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbWhole.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                cbWhole.Items.Add(item[0].ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
