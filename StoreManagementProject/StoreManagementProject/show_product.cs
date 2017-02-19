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
    public partial class show_product : Form
    {
        public show_product()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");

        public void disp_product()
        {
            conn.Open();
            string show = "select * from sProduct";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Product_id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Company"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Category"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Price"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Quantity"];
                dataGridView1.Rows[n].Cells[6].Value = item["Wholseler"].ToString();
            }
            conn.Close();
        }

        private void show_product_Load(object sender, EventArgs e)
        {
            disp_product();
        }
    }


}
