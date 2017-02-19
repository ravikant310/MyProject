using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace StoreManagementProject
{
    public partial class NewSale : Form
    {
        ReportDocument cryCart = new ReportDocument();
        public NewSale(string un)
        {
            InitializeComponent();
            label3.Text = un;
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");
        SqlDataAdapter sda, sda2;
        DataTable dt, dt2;
        private void NewSale_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT Product_Name FROM sProduct",conn);
            dt = new DataTable();
            sda.Fill(dt);
            comboBox1.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                comboBox1.Items.Add(item[0].ToString()); 
            }

            sda2 = new SqlDataAdapter("SELECT Customer_Name FROM Customer", conn);
            dt2 = new DataTable();
            sda2.Fill(dt2);
            cbCustomerName.Items.Clear();
            foreach (DataRow item2 in dt2.Rows)
            {
                cbCustomerName.Items.Add(item2[0].ToString());
            }
            dataGridViewCart.Rows.Clear();
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cryCart.Load(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\CrystalReportCart.rpt");
            SqlDataAdapter sdaCart = new SqlDataAdapter("ShowCart",conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet stCart = new DataSet();
            sdaCart.Fill(stCart, "sCart");
            cryCart.SetDataSource(stCart);
            crystalReportViewer1.ReportSource = cryCart;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string show = @"SELECT Product_Id, Product_Name, Company, Category, Price, Quantity
               FROM sProduct WHERE (Product_Name = '" + comboBox1.Text+ "')";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt2);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Product_id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Company"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Category"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Price"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Quantity"];
            }
            conn.Close();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && numericUpDown1.Value != 0)
            {
                conn.Open();
                string insert = @"insert into Sales values
('" + cbCustomerName.Text + "','" + dataGridView1.Rows[0].Cells[1].Value + "','" + dataGridView1.Rows[0].Cells[2].Value + "','" + dataGridView1.Rows[0].Cells[3].Value + "','" + labelDate.Text + "','" + numericUpDown1.Value + "'," + dataGridView1.Rows[0].Cells[4].Value + "*" + numericUpDown1.Value + ",'" + label3.Text + "')";
                SqlCommand insertcmd = new SqlCommand(insert, conn);
                insertcmd.ExecuteNonQuery();
              
                string icart = @"insert into sCart values
('" + dataGridView1.Rows[0].Cells[0].Value + "','" + dataGridView1.Rows[0].Cells[1].Value + "','" + dataGridView1.Rows[0].Cells[2].Value + "','" + dataGridView1.Rows[0].Cells[4].Value + "','" + numericUpDown1.Value + "'," + dataGridView1.Rows[0].Cells[4].Value + "*" + numericUpDown1.Value + ")";
                SqlCommand insertcmd2 = new SqlCommand(icart, conn);
                insertcmd2.ExecuteNonQuery();

                string uppro = @"UPDATE       sProduct
SET                Quantity = sProduct.Quantity - sCart.Quantity
FROM            sProduct INNER JOIN
                         sCart ON sProduct.Product_Id = sCart.Product_Id
WHERE        (sProduct.Product_Name = '" + dataGridView1.Rows[0].Cells[1].Value + "')";
                SqlCommand upprocmd = new SqlCommand(uppro,conn);
                upprocmd.ExecuteNonQuery();
                conn.Close();
                disp_Cart();
                comboBox1.Text = "";
                numericUpDown1.Value = 0;
            }
            else
                MessageBox.Show("Plese Enter Values");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }


        public void disp_Cart()
        {
            conn.Open();
            string show = "select * from sCart";
            SqlCommand showcmd = new SqlCommand(show, conn);
            showcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(showcmd);
            da.Fill(dt);
            dataGridViewCart.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewCart.Rows.Add();
                dataGridViewCart.Rows[n].Cells[0].Value = item["Product_id"].ToString();
                dataGridViewCart.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                dataGridViewCart.Rows[n].Cells[2].Value = item["Company"].ToString();
                dataGridViewCart.Rows[n].Cells[3].Value = item["Price"];
                dataGridViewCart.Rows[n].Cells[4].Value = item["Quantity"];
                dataGridViewCart.Rows[n].Cells[5].Value = item["Amount"];
            }
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conn.Open();
            string del ="DELETE FROM sCart";
            SqlCommand delcmd = new SqlCommand(del, conn);
            delcmd.ExecuteNonQuery();
            conn.Close();
            dataGridViewCart.Rows.Clear();
            MessageBox.Show("Cart Is Cleared");
            panel1.Visible = false;
        }

        private void dataGridViewCart_MouseClick(object sender, MouseEventArgs e)
        {
           comboBox1.Text = dataGridViewCart.SelectedRows[0].Cells[1].Value.ToString();  
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = dataGridViewCart.Rows[0].Cells[0].Value.ToString();
            string name = dataGridViewCart.Rows[0].Cells[1].Value.ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from sCart where Product_Id='" + id + "'", conn);
            cmd.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("Delete from Sales where Product_Name='" + name + "'", conn);
            cmd2.ExecuteScalar();
            conn.Close();
            if (this.dataGridViewCart.SelectedRows.Count > 0)
            {
                dataGridViewCart.Rows.RemoveAt(this.dataGridViewCart.SelectedRows[0].Index);
            }
        }

        private void saleTime_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labelDate.Text = datetime.ToString();
        }    
    }
}
