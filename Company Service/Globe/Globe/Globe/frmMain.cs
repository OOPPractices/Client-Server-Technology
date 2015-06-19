using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using Business;
using AdminModels;

namespace Globe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Address = this.txtAddress.Text;
            customer.Age = Convert.ToInt32(this.txtAge.Text);
            customer.Birthdate = this.dtBirthDate.Value;
            customer.FirstName = this.txtFirstName.Text;
            customer.MiddleName = this.txtMiddleName.Text;
            customer.LastName = this.txtLastName.Text;

            if (new GlobeCustomer(customer).RegisterCustomer())
            {
                MessageBox.Show("Successfully Register new customer");
                this.txtAddress.Text = "";
                this.txtAge.Text = "";
                this.dtBirthDate.Value = DateTime.Now.Date;
                this.txtFirstName.Text = "";
                this.txtMiddleName.Text = "";
                this.txtLastName.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to Register new customer");
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.gvCustomer.DataSource = new AdminBusiness.GlobeCustomers().getAllCustomer();
        }
    }
}
