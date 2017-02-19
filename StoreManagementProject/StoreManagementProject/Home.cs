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
    public partial class Home : Form
    {
        public Home(string uname)
        {
            InitializeComponent();
            label4.Text =uname;
            Image img = Image.FromFile(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\Resources\2.jpg");
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    control.BackgroundImage = System.Drawing.Image.FromFile(@"D:\StoreManagementProject\StoreManagementProject\StoreManagementProject\Resources\2.jpg");
                    control.BackColor = Color.AliceBlue;                                    
                    break;
                }
            }
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\StoreManagementProject\\StoreManagementProject\\StoreManagementProject\\G_Store.mdf;Integrated Security=True;User Instance=True");
        product pr;
        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (pr == null)
            {
                pr = new product();
                pr.MdiParent = this;
                pr.FormClosed += new FormClosedEventHandler(pr_FormClosed);
                pr.Show();
            }
            else
                pr.Activate();
        }
       
        void pr_FormClosed(object sender, FormClosedEventArgs e)
        {
            pr = null;
        }

        UserRegistration ur;
        private void btnUser_Click(object sender, EventArgs e)
        {
            if (ur == null)
            {
                ur = new UserRegistration();
                ur.MdiParent = this;
                ur.FormClosed += new FormClosedEventHandler(ur_FormClosed);
                ur.Show();
            }
            else
                ur.Activate();
        }
      
        void ur_FormClosed(object sender, FormClosedEventArgs e)
        {
            ur = null;
        }
        NewSale ns;

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (ns == null)
            {
                ns = new NewSale(label4.Text);
                ns.MdiParent = this;
                ns.FormClosed += new FormClosedEventHandler(ns_FormClosed);
                ns.Show();
            }
            else
                ns.Activate();
        }

        void ns_FormClosed(object sender, FormClosedEventArgs e)
        {
            ns = null;
        }

       
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close this window?", "closeing window", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                e.Cancel = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout ?", "Loguot Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                slogin sl = new slogin();
                sl.Show();
            }
        }
        Customer cs;
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (cs == null)
            {
                cs = new Customer();
                cs.MdiParent = this;
                cs.FormClosed += new FormClosedEventHandler(cs_FormClosed);
                cs.Show();
            }
            else
                cs.Activate();
        }

        void cs_FormClosed(object sender, FormClosedEventArgs e)
        {
            cs = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label5.Text = datetime.ToString();
        }

        Wholesaler wh;
        private void btnWholeseler_Click(object sender, EventArgs e)
        {
            if (wh == null)
            {
                wh = new Wholesaler();
                wh.MdiParent = this;
                wh.FormClosed += new FormClosedEventHandler(wh_FormClosed);
                wh.Show();
            }
            else
                wh.Activate();
        }

        void wh_FormClosed(object sender, FormClosedEventArgs e)
        {
            wh = null;
        }

        Reports rep;
        private void btnReports_Click(object sender, EventArgs e)
        {
                if(rep == null)
                {
                    rep = new Reports();
                    rep.MdiParent = this;
                    rep.FormClosed +=new FormClosedEventHandler(rep_FormClosed);
                 rep.Show();
                }
               else
                rep.Activate();
        }

        void  rep_FormClosed(object sender, FormClosedEventArgs e)
        {
 	         rep=null;
        }
        About ab;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ab == null)
            {
                ab = new About();
                //ab.MdiParent = this;
                ab.FormClosed += new FormClosedEventHandler(ab_FormClosed);
                ab.Show();
            }
            else
                ab.Activate();
        }
        void ab_FormClosed(object sender, FormClosedEventArgs e)
        {
            ab = null;
        }       
    }
}
