namespace StoreManagementProject
{
    partial class Customer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.btnupdatecustomer = new System.Windows.Forms.Button();
            this.btnaddcustomer = new System.Windows.Forms.Button();
            this.btnshowcustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnupdatecustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btnaddcustomer);
            this.splitContainer1.Panel1.Controls.Add(this.btnshowcustomer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(921, 503);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(303, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 82);
            this.button2.TabIndex = 0;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnupdatecustomer
            // 
            this.btnupdatecustomer.BackColor = System.Drawing.Color.Green;
            this.btnupdatecustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdatecustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdatecustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnupdatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdatecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdatecustomer.Location = new System.Drawing.Point(202, 0);
            this.btnupdatecustomer.Name = "btnupdatecustomer";
            this.btnupdatecustomer.Size = new System.Drawing.Size(101, 82);
            this.btnupdatecustomer.TabIndex = 0;
            this.btnupdatecustomer.Text = "Edit Customer";
            this.btnupdatecustomer.UseVisualStyleBackColor = false;
            this.btnupdatecustomer.Click += new System.EventHandler(this.btnupdatecustomer_Click);
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnaddcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddcustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddcustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnaddcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddcustomer.Location = new System.Drawing.Point(101, 0);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(101, 82);
            this.btnaddcustomer.TabIndex = 0;
            this.btnaddcustomer.Text = "Add New Customer";
            this.btnaddcustomer.UseVisualStyleBackColor = false;
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // btnshowcustomer
            // 
            this.btnshowcustomer.BackColor = System.Drawing.Color.Purple;
            this.btnshowcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshowcustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowcustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnshowcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowcustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshowcustomer.Location = new System.Drawing.Point(0, 0);
            this.btnshowcustomer.Name = "btnshowcustomer";
            this.btnshowcustomer.Size = new System.Drawing.Size(101, 82);
            this.btnshowcustomer.TabIndex = 0;
            this.btnshowcustomer.Text = "Show All Customer";
            this.btnshowcustomer.UseVisualStyleBackColor = false;
            this.btnshowcustomer.Click += new System.EventHandler(this.btnshowcustomer_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(921, 503);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Customer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnupdatecustomer;
        private System.Windows.Forms.Button btnaddcustomer;
        private System.Windows.Forms.Button btnshowcustomer;

    }
}