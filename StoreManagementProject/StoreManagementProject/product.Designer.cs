namespace StoreManagementProject
{
    partial class product
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
            this.btnupdateproduct = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.btnshowproduct = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnupdateproduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnaddproduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnshowproduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(1062, 538);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 1;
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
            // btnupdateproduct
            // 
            this.btnupdateproduct.BackColor = System.Drawing.Color.Green;
            this.btnupdateproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdateproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnupdateproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdateproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdateproduct.Location = new System.Drawing.Point(202, 0);
            this.btnupdateproduct.Name = "btnupdateproduct";
            this.btnupdateproduct.Size = new System.Drawing.Size(101, 82);
            this.btnupdateproduct.TabIndex = 0;
            this.btnupdateproduct.Text = "Update Product";
            this.btnupdateproduct.UseVisualStyleBackColor = false;
            this.btnupdateproduct.Click += new System.EventHandler(this.btnupdateproduct_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnaddproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnaddproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddproduct.Location = new System.Drawing.Point(101, 0);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(101, 82);
            this.btnaddproduct.TabIndex = 0;
            this.btnaddproduct.Text = "Add New Product";
            this.btnaddproduct.UseVisualStyleBackColor = false;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // btnshowproduct
            // 
            this.btnshowproduct.BackColor = System.Drawing.Color.Purple;
            this.btnshowproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshowproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnshowproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshowproduct.Location = new System.Drawing.Point(0, 0);
            this.btnshowproduct.Name = "btnshowproduct";
            this.btnshowproduct.Size = new System.Drawing.Size(101, 82);
            this.btnshowproduct.TabIndex = 0;
            this.btnshowproduct.Text = "Show All Product";
            this.btnshowproduct.UseVisualStyleBackColor = false;
            this.btnshowproduct.Click += new System.EventHandler(this.btnshowproduct_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1062, 538);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "product";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnshowproduct;
        private System.Windows.Forms.Button btnupdateproduct;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.Button button2;
    }
}