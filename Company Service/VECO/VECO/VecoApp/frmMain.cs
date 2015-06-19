using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdminLogics;
using VecoModels;
using CustomerBillModel;

namespace VecoApp
{
    public partial class frmAdminMain : Form
    {
        private List<CustomerDetail> Customers;
        public frmAdminMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Address = this.txtAddress.Text;
            customer.Birthdate = this.dtBirthdate.Value;
            customer.FirstName = this.txtFirstName.Text;
            customer.MiddleName = this.txtMiddleName.Text;
            customer.LastName = this.txtFamilyName.Text;

            if (new CustomerLogic(customer).RegisterNewCustomer())
            {
                MessageBox.Show("Successfully Register new Customer");
                this.txtAddress.Text = "";
                this.dtBirthdate.Value = DateTime.Now.Date;
                this.txtFirstName.Text = "";
                this.txtMiddleName.Text = "";
                this.txtFamilyName.Text = "";
            }
            else
            {
                MessageBox.Show("Registration Fail");
            }
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            this.Customers = new CreateBill().getAllCustomer();
            this.gvCustomers.DataSource = this.Customers;
            this.btnRefresh.Enabled = this.Customers.Count > 0;
        }

        private void gvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtBill.Enabled = true;
            this.btnBill.Enabled = true;
            string data = this.gvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            int id = (int)this.gvCustomers.Rows[this.gvCustomers.CurrentRow.Index].Cells[0].Value;

            BillLogic bill = new BillLogic(new CustomerBillAmount { Bill = Convert.ToDecimal(this.txtBill.Text), CustomerId=id });
            if (bill.CreateCustomerBill())
            {
                MessageBox.Show("Successfully Create Bill");
            }
            else
            {
                MessageBox.Show("Failed to Create Bill");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Customers = new CreateBill().getAllCustomer();
            this.gvCustomers.DataSource = this.Customers;
        }
    }
}
