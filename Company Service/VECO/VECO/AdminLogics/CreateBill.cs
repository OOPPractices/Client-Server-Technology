using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomerBillModel;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace AdminLogics
{
    public class CreateBill
    {
        public List<CustomerDetail> getAllCustomer()
        {
            List<CustomerDetail> Customers = new List<CustomerDetail>();
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["VECO"].ConnectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT");
                sql.Append("    `CustomerId`, ");
                sql.Append("    `FirstName`, ");
                sql.Append("    `MiddleName`, ");
                sql.Append("    `FamilyName`, ");
                sql.Append("    `Address`, ");
                sql.Append("    `BirthDate` ");
                sql.Append("FROM");
                sql.Append("    `veco`.`customer` ");
                sql.Append("WHERE");
                sql.Append("    `CustomerId` NOT IN (");
                sql.Append("        SELECT");
                sql.Append("            `CustomerID` ");
                sql.Append("        FROM");
                sql.Append("            `veco`.`customersbill` ");
                sql.Append("        WHERE");
                sql.Append("            MONTH(`SysCreated`) = MONTH(NOW()) AND ");
                sql.Append("            YEAR(`SysCreated`) = YEAR(NOW()));");                
                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (rdr.Read())
                        {
                            CustomerDetail customer = new CustomerDetail
                            {
                                Address = rdr.GetString("Address"),
                                Birthdate = rdr.GetDateTime("BirthDate"),
                                CustomerId = rdr.GetInt32("CustomerId"),
                                FirstName = rdr.GetString("FirstName"),
                                LastName = rdr.GetString("FamilyName"),
                                MiddleName = rdr.GetString("MiddleName")                                 

                            };
                            Customers.Add(customer);
                        }
                        rdr.Close();
                    }
                }
            }
            return Customers;
        }
    }
}
