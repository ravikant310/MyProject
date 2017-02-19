using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreManagementProject
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmaddc = new frmAddCustomer();
            frmaddc.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmaddc);
            frmaddc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdatecustomer_Click(object sender, EventArgs e)
        {
            frmEditCustomer frmedit = new frmEditCustomer();
            frmedit.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmedit);
            frmedit.Show();
        }

        private void btnshowcustomer_Click(object sender, EventArgs e)
        {
            show_customer frmshow = new show_customer();
            frmshow.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmshow);
            frmshow.Show();
        }

       
    }
}
