namespace StoreManagementProject
{
    partial class frmEditCustomer
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtNewContact = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtSearchC = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(444, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(234, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewAddress.Location = new System.Drawing.Point(601, 169);
            this.txtNewAddress.Multiline = true;
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(261, 94);
            this.txtNewAddress.TabIndex = 5;
            // 
            // txtNewContact
            // 
            this.txtNewContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewContact.Location = new System.Drawing.Point(601, 133);
            this.txtNewContact.Name = "txtNewContact";
            this.txtNewContact.Size = new System.Drawing.Size(204, 26);
            this.txtNewContact.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddress.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAddress.Location = new System.Drawing.Point(499, 169);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(96, 27);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "&Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchC
            // 
            this.txtSearchC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchC.Location = new System.Drawing.Point(419, 88);
            this.txtSearchC.Name = "txtSearchC";
            this.txtSearchC.Size = new System.Drawing.Size(204, 26);
            this.txtSearchC.TabIndex = 2;
            this.txtSearchC.TextChanged += new System.EventHandler(this.txtSearchC_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(234, 130);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(204, 26);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmail.Location = new System.Drawing.Point(234, 169);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(204, 26);
            this.txtNewEmail.TabIndex = 4;
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelContact.Location = new System.Drawing.Point(499, 135);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(96, 24);
            this.labelContact.TabIndex = 0;
            this.labelContact.Text = "&Contact";
            this.labelContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCustName
            // 
            this.labelCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustName.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCustName.Location = new System.Drawing.Point(75, 132);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(153, 26);
            this.labelCustName.TabIndex = 0;
            this.labelCustName.Text = "&Customer Name";
            this.labelCustName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEmail.Location = new System.Drawing.Point(140, 166);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(88, 30);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "&Email ID";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(331, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 324);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(917, 211);
            this.dataGridViewCustomer.TabIndex = 14;
            this.dataGridViewCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCustomer_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "EMail Id";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Contact";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNewAddress);
            this.panel1.Controls.Add(this.txtNewContact);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.txtSearchC);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtNewEmail);
            this.panel1.Controls.Add(this.labelContact);
            this.panel1.Controls.Add(this.labelCustName);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 329);
            this.panel1.TabIndex = 13;
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmEditCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtNewContact;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtSearchC;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}