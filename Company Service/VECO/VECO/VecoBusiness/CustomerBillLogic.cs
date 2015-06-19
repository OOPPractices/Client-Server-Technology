using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using VecoModels;
using System.Configuration;

namespace VecoBusiness
{
    public class CustomerBillLogic
    {
        public CustomerBill getCustomerPayments(string customerID)
        {
            CustomerBill customer = new CustomerBill();            
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["VECO"].ConnectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT `FirstName`,`MiddleName`,`FamilyName`,`Address`,`CurrentBill` FROM `veco`.`customer` AS c ");
                sql.Append("INNER JOIN `veco`.`customersbill` AS b ON c.`CustomerID` = b.CustomerID WHERE b.`CustomerID` = @Reference;");
                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                {
                    cmd.Parameters.AddWithValue("Reference", customerID);
                    con.Open();
                    using (MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (rdr.Read())
                        {
                            customer.Address = rdr.GetString("Address");
                            customer.FirstName = rdr.GetString("FirstName");
                            customer.MiddleName = rdr.GetString("MiddleName");
                            customer.LastName = rdr.GetString("FamilyName");
                            customer.CurrentBill = rdr.GetDecimal("CurrentBill");
                            rdr.Close();
                        }
                    }
                }
                return customer;
            }            
        }
    }
}
