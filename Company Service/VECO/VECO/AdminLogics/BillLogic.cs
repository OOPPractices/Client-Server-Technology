using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using CustomerBillModel;
using System.Configuration;

namespace AdminLogics
{
    public class BillLogic
    {
        private CustomerBillAmount customerBill;

        public BillLogic(CustomerBillAmount customerBill)
        {
            this.customerBill = customerBill;
        }

        public bool CreateCustomerBill()
        {
            int rowsAffected;

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO veco.customersbill ( ");
            sql.Append("    CustomerID, ");
            sql.Append("    CurrentBill)");
            sql.Append("VALUES ( ");
            sql.Append("    @CustomerId, ");
            sql.Append("    @Bill);");
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["VECO"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                {
                    cmd.Parameters.AddWithValue("CustomerId", this.customerBill.CustomerId);
                    cmd.Parameters.AddWithValue("Bill", this.customerBill.Bill);
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return rowsAffected == 1;
        }

    }
}
