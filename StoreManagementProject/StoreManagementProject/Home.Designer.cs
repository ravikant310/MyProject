namespace StoreManagementProject
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSale = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnWholeseler = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.btnSale);
            this.flowLayoutPanel1.Controls.Add(this.btnProduct);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnWholeseler);
            this.flowLayoutPanel1.Controls.Add(this.btnUser);
            this.flowLayoutPanel1.Controls.Add(this.btnAbout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 576);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Teal;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(3, 465);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(99, 71);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 88);
            this.panel1.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(924, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LOGOUT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(924, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(287, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 84);
            this.label3.TabIndex = 2;
            this.label3.Text = "General Store Management System\r\nVersion 1.0\r\nDeveloped By- Ravi Kant Gupta\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(67, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "STORE";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "G";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(872, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSale
            // 
            this.btnSale.BackgroundImage = global::StoreManagementProject.Properties.Resources.sale;
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSale.Location = new System.Drawing.Point(3, 3);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(99, 71);
            this.btnSale.TabIndex = 1;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = global::StoreManagementProject.Properties.Resources.unnamed3;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduct.Location = new System.Drawing.Point(3, 80);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(99, 71);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = global::StoreManagementProject.Properties.Resources.customer;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomer.Location = new System.Drawing.Point(3, 157);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(99, 71);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackgroundImage = global::StoreManagementProject.Properties.Resources.reports;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Location = new System.Drawing.Point(3, 234);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(99, 71);
            this.btnReports.TabIndex = 4;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnWholeseler
            // 
            this.btnWholeseler.BackgroundImage = global::StoreManagementProject.Properties.Resources.whole;
            this.btnWholeseler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWholeseler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWholeseler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWholeseler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWholeseler.ForeColor = System.Drawing.Color.Black;
            this.btnWholeseler.Location = new System.Drawing.Point(3, 311);
            this.btnWholeseler.Name = "btnWholeseler";
            this.btnWholeseler.Size = new System.Drawing.Size(99, 71);
            this.btnWholeseler.TabIndex = 5;
            this.btnWholeseler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWholeseler.UseVisualStyleBackColor = true;
            this.btnWholeseler.Click += new System.EventHandler(this.btnWholeseler_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUser.BackgroundImage = global::StoreManagementProject.Properties.Resources.User_Icon_64;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(3, 388);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(99, 71);
            this.btnUser.TabIndex = 6;
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::StoreManagementProject.Properties.Resources.User_Icon_72;
            this.pictureBox1.Location = new System.Drawing.Point(845, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 69);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 664);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnWholeseler;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAbout;


    }
}