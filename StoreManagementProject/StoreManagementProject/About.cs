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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            richTextBox1.Visible = false;
            label5.Visible = false;
            panel2.Visible = true;   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            label4.Visible = false;
            label5.Visible = true;
            panel2.Visible = false;
        }
    }
}
