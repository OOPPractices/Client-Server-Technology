using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using AdminModels;
using System.Data;
using System.Configuration;

namespace AdminBusiness
{
    public class GlobeCustomers
    {
        public List<CustomerDetail> getAllCustomer()
        {
            List<CustomerDetail> customers = new List<CustomerDetail>();
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["GlobeAdmin"].ConnectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT");
                sql.Append("    `CustomerId`, ");
                sql.Append("    `FirstName`, ");
                sql.Append("    `MiddleName`, ");
                sql.Append("    `LastName`, ");
                sql.Append("    `Address`, ");
                sql.Append("    `BirthDate`, ");
                sql.Append("    `Age` ");
                sql.Append("FROM");
                sql.Append("    `globe`.`customer` ");
                sql.Append("WHERE");
                sql.Append("    `CustomerId` NOT IN (");
                sql.Append("        SELECT");
                sql.Append("            `CustomerID` ");
                sql.Append("        FROM");
                sql.Append("            `globe`.`bill` ");
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
                                CustomerId = rdr.GetInt32("CustomerId"),
                                Address = rdr.GetString("Address"),
                                Age = rdr.GetInt32("Age"),
                                Birthdate = rdr.GetDateTime("BirthDate"),
                                FirstName = rdr.GetString("FirstName"),
                                LastName = rdr.GetString("LastName"),
                                MiddleName = rdr.GetString("MiddleName")
                            };
                            customers.Add(customer);
                        }
                        rdr.Close();
                    }
                }
            }
            return customers;
        }
    }

}
