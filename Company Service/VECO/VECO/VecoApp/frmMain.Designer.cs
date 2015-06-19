namespace VecoApp
{
    partial class frmAdminMain
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabAddCustomer = new System.Windows.Forms.TabPage();
            this.tabCreateBill = new System.Windows.Forms.TabPage();
            this.gvCustomers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabAddCustomer.SuspendLayout();
            this.tabCreateBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(66, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(110, 41);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(31, 44);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(78, 13);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name : ";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(110, 77);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(100, 20);
            this.txtFamilyName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Family Name : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 115);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address : ";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(31, 152);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(58, 13);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "Birthdate : ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(69, 188);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 34);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register new Customer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.CustomFormat = "yyyy-MM-dd";
            this.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthdate.Location = new System.Drawing.Point(110, 146);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(100, 20);
            this.dtBirthdate.TabIndex = 11;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabAddCustomer);
            this.tab.Controls.Add(this.tabCreateBill);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(564, 265);
            this.tab.TabIndex = 12;
            // 
            // tabAddCustomer
            // 
            this.tabAddCustomer.Controls.Add(this.txtFirstName);
            this.tabAddCustomer.Controls.Add(this.dtBirthdate);
            this.tabAddCustomer.Controls.Add(this.lblFirstName);
            this.tabAddCustomer.Controls.Add(this.btnRegister);
            this.tabAddCustomer.Controls.Add(this.lblMiddleName);
            this.tabAddCustomer.Controls.Add(this.lblBirthDate);
            this.tabAddCustomer.Controls.Add(this.txtMiddleName);
            this.tabAddCustomer.Controls.Add(this.txtAddress);
            this.tabAddCustomer.Controls.Add(this.lblLastName);
            this.tabAddCustomer.Controls.Add(this.lblAddress);
            this.tabAddCustomer.Controls.Add(this.txtFamilyName);
            this.tabAddCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabAddCustomer.Name = "tabAddCustomer";
            this.tabAddCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCustomer.Size = new System.Drawing.Size(556, 239);
            this.tabAddCustomer.TabIndex = 0;
            this.tabAddCustomer.Text = "Add Customer";
            this.tabAddCustomer.UseVisualStyleBackColor = true;
            // 
            // tabCreateBill
            // 
            this.tabCreateBill.Controls.Add(this.btnBill);
            this.tabCreateBill.Controls.Add(this.txtBill);
            this.tabCreateBill.Controls.Add(this.btnRefresh);
            this.tabCreateBill.Controls.Add(this.gvCustomers);
            this.tabCreateBill.Location = new System.Drawing.Point(4, 22);
            this.tabCreateBill.Name = "tabCreateBill";
            this.tabCreateBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateBill.Size = new System.Drawing.Size(556, 239);
            this.tabCreateBill.TabIndex = 1;
            this.tabCreateBill.Text = "Customer Bill";
            this.tabCreateBill.UseVisualStyleBackColor = true;
            // 
            // gvCustomers
            // 
            this.gvCustomers.AllowUserToAddRows = false;
            this.gvCustomers.AllowUserToDeleteRows = false;
            this.gvCustomers.AllowUserToOrderColumns = true;
            this.gvCustomers.AllowUserToResizeColumns = false;
            this.gvCustomers.AllowUserToResizeRows = false;
            this.gvCustomers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvCustomers.Location = new System.Drawing.Point(17, 34);
            this.gvCustomers.MultiSelect = false;
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.ReadOnly = true;
            this.gvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvCustomers.Size = new System.Drawing.Size(522, 150);
            this.gvCustomers.TabIndex = 0;
            this.gvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomers_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(423, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(267, 207);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(100, 20);
            this.txtBill.TabIndex = 2;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBill
            // 
            this.btnBill.Enabled = false;
            this.btnBill.Location = new System.Drawing.Point(396, 200);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(102, 33);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 289);
            this.Controls.Add(this.tab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.tab.ResumeLayout(false);
            this.tabAddCustomer.ResumeLayout(false);
            this.tabAddCustomer.PerformLayout();
            this.tabCreateBill.ResumeLayout(false);
            this.tabCreateBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabAddCustomer;
        private System.Windows.Forms.TabPage tabCreateBill;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gvCustomers;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.TextBox txtBill;
    }
}

