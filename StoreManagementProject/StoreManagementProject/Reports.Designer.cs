namespace StoreManagementProject
{
    partial class Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btncustomerrpt = new System.Windows.Forms.Button();
            this.btnstockrpt = new System.Windows.Forms.Button();
            this.btnproductrpt = new System.Windows.Forms.Button();
            this.btnsalerpt = new System.Windows.Forms.Button();
            this.crvSales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvCustomer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btncustomerrpt);
            this.panel1.Controls.Add(this.btnstockrpt);
            this.panel1.Controls.Add(this.btnproductrpt);
            this.panel1.Controls.Add(this.btnsalerpt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.Location = new System.Drawing.Point(404, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(101, 85);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncustomerrpt
            // 
            this.btncustomerrpt.BackColor = System.Drawing.Color.Teal;
            this.btncustomerrpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncustomerrpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomerrpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncustomerrpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncustomerrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerrpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncustomerrpt.Location = new System.Drawing.Point(303, 0);
            this.btncustomerrpt.Name = "btncustomerrpt";
            this.btncustomerrpt.Size = new System.Drawing.Size(101, 85);
            this.btncustomerrpt.TabIndex = 1;
            this.btncustomerrpt.Text = "Customer Report";
            this.btncustomerrpt.UseVisualStyleBackColor = false;
            this.btncustomerrpt.Click += new System.EventHandler(this.btncustomerrpt_Click);
            // 
            // btnstockrpt
            // 
            this.btnstockrpt.BackColor = System.Drawing.Color.Green;
            this.btnstockrpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstockrpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstockrpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnstockrpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockrpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstockrpt.Location = new System.Drawing.Point(202, 0);
            this.btnstockrpt.Name = "btnstockrpt";
            this.btnstockrpt.Size = new System.Drawing.Size(101, 85);
            this.btnstockrpt.TabIndex = 2;
            this.btnstockrpt.Text = "Stock Report";
            this.btnstockrpt.UseVisualStyleBackColor = false;
            this.btnstockrpt.Click += new System.EventHandler(this.btnstockrpt_Click);
            // 
            // btnproductrpt
            // 
            this.btnproductrpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnproductrpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnproductrpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductrpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnproductrpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproductrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductrpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproductrpt.Location = new System.Drawing.Point(101, 0);
            this.btnproductrpt.Name = "btnproductrpt";
            this.btnproductrpt.Size = new System.Drawing.Size(101, 85);
            this.btnproductrpt.TabIndex = 3;
            this.btnproductrpt.Text = "Product Report";
            this.btnproductrpt.UseVisualStyleBackColor = false;
            this.btnproductrpt.Click += new System.EventHandler(this.btnproductrpt_Click);
            // 
            // btnsalerpt
            // 
            this.btnsalerpt.BackColor = System.Drawing.Color.Purple;
            this.btnsalerpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalerpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalerpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsalerpt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalerpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalerpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalerpt.Location = new System.Drawing.Point(0, 0);
            this.btnsalerpt.Name = "btnsalerpt";
            this.btnsalerpt.Size = new System.Drawing.Size(101, 85);
            this.btnsalerpt.TabIndex = 4;
            this.btnsalerpt.Text = "Sale\'s Report";
            this.btnsalerpt.UseVisualStyleBackColor = false;
            this.btnsalerpt.Click += new System.EventHandler(this.btnsalerpt_Click);
            // 
            // crvSales
            // 
            this.crvSales.ActiveViewIndex = -1;
            this.crvSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSales.Location = new System.Drawing.Point(0, 85);
            this.crvSales.Name = "crvSales";
            this.crvSales.Size = new System.Drawing.Size(945, 417);
            this.crvSales.TabIndex = 3;
            this.crvSales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvSales.Visible = false;
            // 
            // crvProduct
            // 
            this.crvProduct.ActiveViewIndex = -1;
            this.crvProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProduct.Location = new System.Drawing.Point(0, 85);
            this.crvProduct.Name = "crvProduct";
            this.crvProduct.Size = new System.Drawing.Size(945, 417);
            this.crvProduct.TabIndex = 4;
            this.crvProduct.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvProduct.Visible = false;
            // 
            // crvStock
            // 
            this.crvStock.ActiveViewIndex = -1;
            this.crvStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvStock.Location = new System.Drawing.Point(0, 85);
            this.crvStock.Name = "crvStock";
            this.crvStock.Size = new System.Drawing.Size(945, 417);
            this.crvStock.TabIndex = 5;
            this.crvStock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvStock.Visible = false;
            // 
            // crvCustomer
            // 
            this.crvCustomer.ActiveViewIndex = -1;
            this.crvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCustomer.Location = new System.Drawing.Point(0, 85);
            this.crvCustomer.Name = "crvCustomer";
            this.crvCustomer.Size = new System.Drawing.Size(945, 417);
            this.crvCustomer.TabIndex = 6;
            this.crvCustomer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvCustomer.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 502);
            this.Controls.Add(this.crvCustomer);
            this.Controls.Add(this.crvStock);
            this.Controls.Add(this.crvProduct);
            this.Controls.Add(this.crvSales);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Reports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncustomerrpt;
        private System.Windows.Forms.Button btnstockrpt;
        private System.Windows.Forms.Button btnproductrpt;
        private System.Windows.Forms.Button btnsalerpt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSales;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProduct;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvStock;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCustomer;
    }
}