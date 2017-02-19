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
    public partial class SplashScreen : Form
    {
        int z = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 1;
            if (z >= 100)
            {
                this.Hide();
                timer1.Enabled = false;
                slogin sl = new slogin();
                sl.Show();

            }
            progressBar1.Value = z;

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 20;

        }

      
    }
}
