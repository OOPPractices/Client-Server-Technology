using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AdminBusiness
{
    public class CustomerBill
    {
        private Bill bill;
        public CustomerBill(Bill bill)
        {
            this.bill = bill;
        }

        public bool CreateBill()
        {
            try
            {
                int rowsAffected;
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["GlobeAdmin"].ConnectionString))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO `globe`.`bill` ( ");
                    sql.Append("    `CustomerID`, ");
                    sql.Append("    `BillAmount` )");
                    sql.Append("VALUES ( ");
                    sql.Append("    @CustomerId, ");
                    sql.Append("    @Bill);");
                    using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                    {
                        cmd.Parameters.AddWithValue("CustomerId", this.bill.CustomerId);
                        cmd.Parameters.AddWithValue("Bill", this.bill.BillAmount);
                        cmd.CommandType = System.Data.CommandType.Text;
                        con.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return rowsAffected == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
