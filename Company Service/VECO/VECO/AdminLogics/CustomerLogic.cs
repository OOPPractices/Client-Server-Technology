using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VecoModels;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AdminLogics
{
    public class CustomerLogic
    {
        private Customer customer = new Customer();
        public CustomerLogic(Customer customer)
        {
            this.customer = customer;
        }
        public bool RegisterNewCustomer()
        {
            int rowsAffected;
            try
            {


                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["VECO"].ConnectionString))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO `veco`.`customer` (");
                    sql.Append("    `FirstName`, ");
                    sql.Append("    `MiddleName`, ");
                    sql.Append("    `FamilyName`, ");
                    sql.Append("    `Address`, ");
                    sql.Append("    `Birthdate`) ");
                    sql.Append("VALUES (");
                    sql.Append("    @FirstName, ");
                    sql.Append("    @MiddleName, ");
                    sql.Append("    @FamilyName, ");
                    sql.Append("    @Address, ");
                    sql.Append("    @Birthdate);");
                    using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                    {
                        cmd.Parameters.AddWithValue("FirstName", this.customer.FirstName);
                        cmd.Parameters.AddWithValue("MiddleName", this.customer.MiddleName);
                        cmd.Parameters.AddWithValue("FamilyName", this.customer.LastName);
                        cmd.Parameters.AddWithValue("Address", this.customer.Address);
                        cmd.Parameters.AddWithValue("Birthdate", this.customer.Birthdate);
                        con.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        return rowsAffected == 1;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
