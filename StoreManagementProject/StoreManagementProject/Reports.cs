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
    public partial class Reports : Form
    {
        ReportDocument crySale = new ReportDocument();
        public Reports()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");
        private void btnsalerpt_Click(object sender, EventArgs e)
        {
            if (crvProduct.Visible == true && crvStock.Visible == true)
            {
                crvProduct.Visible = false;
                crvStock.Visible = false;
            }
            crvProduct.Visible = false;
            crvStock.Visible = false;
            crvSales.Visible = true;

            crySale.Load(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\CrystalReportSales.rpt");
            SqlDataAdapter sdaSale = new SqlDataAdapter("ShowSale", conn);
            sdaSale.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet stSale = new DataSet();
            sdaSale.Fill(stSale, "Sales");
            crySale.SetDataSource(stSale);
            crvSales.ReportSource = crySale;

        }

        private void btnproductrpt_Click(object sender, EventArgs e)
        {
            if (crvSales.Visible == true && crvStock.Visible==true && crvCustomer.Visible == true)
            {
                crvSales.Visible = false;
                crvStock.Visible = false;
                crvCustomer.Visible = false;
            }
            crvSales.Visible = false;
            crvStock.Visible = false;
            crvCustomer.Visible = false;
            crvProduct.Visible = true;

            crySale.Load(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\CrystalReportProduct.rpt");
            SqlDataAdapter sdaPro = new SqlDataAdapter("ShowSale", conn);
            sdaPro.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet stPro = new DataSet();
            sdaPro.Fill(stPro, "Sales");
            crySale.SetDataSource(stPro);
            crvProduct.ReportSource = crySale;
        }

        private void btnstockrpt_Click(object sender, EventArgs e)
        {
            if (crvSales.Visible == true && crvProduct.Visible == true && crvCustomer.Visible == true)
            {
                crvSales.Visible = false;
                crvProduct.Visible = false;
            }
            crvSales.Visible = false;
            crvProduct.Visible = false;
            crvCustomer.Visible = false;
            crvStock.Visible = true;

            crySale.Load(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\CrystalReportStock.rpt");
            SqlDataAdapter sdaStock = new SqlDataAdapter("ShowProduct", conn);
            sdaStock.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet stStock = new DataSet();
            sdaStock.Fill(stStock, "sProduct");
            crySale.SetDataSource(stStock);
            crvStock.ReportSource = crySale;
        }

        private void btncustomerrpt_Click(object sender, EventArgs e)
        {
            if (crvSales.Visible == true && crvProduct.Visible == true && crvStock.Visible ==true)
            {
                crvSales.Visible = false;
                crvProduct.Visible = false;
                crvStock.Visible = false;
            }
            crvSales.Visible = false;
            crvProduct.Visible = false;
            crvStock.Visible =false;
            crvCustomer.Visible = true;

            crySale.Load(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\CrystalReportCustomer.rpt");
            SqlDataAdapter sdacust = new SqlDataAdapter("ShowSale", conn);
            sdacust.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet stcust = new DataSet();
            sdacust.Fill(stcust, "Sales");
            crySale.SetDataSource(stcust);
            crvCustomer.ReportSource = crySale;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
