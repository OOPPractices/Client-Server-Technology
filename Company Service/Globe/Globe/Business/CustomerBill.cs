using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Models;
using System.Data;
using System.Configuration;

namespace Business
{
    public class CustomerBill
    {
        public Bill getCustomerBill(string customerID)
        {
            Bill customerBill = new Bill();
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["Globe"].ConnectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT");
                sql.Append("    `FirstName`, ");
                sql.Append("    `MiddleName`, ");
                sql.Append("    `LastName`, ");
                sql.Append("    `BirthDate`, ");
                sql.Append("    `Age`, ");
                sql.Append("    `Address`, ");
                sql.Append("    `BillAmount` ");
                sql.Append("FROM");
                sql.Append("    `globe`.`customer` AS c ");
                sql.Append("INNER JOIN");
                sql.Append("    `globe`.`bill` AS b ");
                sql.Append("ON");
                sql.Append("     c.`CustomerID` = b.`CustomerID` ");
                sql.Append("WHERE");
                sql.Append("    b.`CustomerID` = @customerID;");
                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                {
                    cmd.Parameters.AddWithValue("customerID", customerID);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (rdr.Read())
                        {
                            customerBill.FirstName = rdr.GetString("FirstName");
                            customerBill.MiddleName = rdr.GetString("MiddleName");
                            customerBill.LastName = rdr.GetString("LastName");
                            customerBill.Birthdate = rdr.GetDateTime("BirthDate");
                            customerBill.Age = rdr.GetInt32("Age");
                            customerBill.Address = rdr.GetString("Address");
                            customerBill.BillAmount = rdr.GetDecimal("BillAmount");
                            rdr.Close();
                        }
                    }
                }
            }
            return customerBill;
        }
    }
}
