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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }


        private void btnshowproduct_Click(object sender, EventArgs e)
        {
            show_product sp=new show_product();
            sp.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(sp);
            sp.Show(); 
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmaddp = new frmAddProduct();
            frmaddp.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmaddp);
            frmaddp.Show();
        }

        private void btnupdateproduct_Click(object sender, EventArgs e)
        {
            frmEditProduct frmup = new frmEditProduct();
            frmup.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmup);
            frmup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        
    }
}
