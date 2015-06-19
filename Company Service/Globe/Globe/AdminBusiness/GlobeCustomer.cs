using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Business
{
    public class GlobeCustomer
    {
        private Customer customer;
        public GlobeCustomer(Customer customer)
        {
            this.customer = customer;
        }

        public bool RegisterCustomer()
        {
            int rowsAffected;
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["GlobeAdmin"].ConnectionString))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO `globe`.`customer` (");
                    sql.Append("    `FirstName`, ");
                    sql.Append("    `MiddleName`, ");
                    sql.Append("    `LastName`, ");
                    sql.Append("    `BirthDate`, ");
                    sql.Append("    `Age`, ");
                    sql.Append("    `Address`) ");
                    sql.Append("VALUES (");
                    sql.Append("    @FirstName, ");
                    sql.Append("    @MiddleName, ");
                    sql.Append("    @LastName, ");
                    sql.Append("    @BirthDate, ");
                    sql.Append("    @Age, ");
                    sql.Append("    @Address);");

                    using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                    {
                        cmd.Parameters.AddWithValue("FirstName", this.customer.FirstName);
                        cmd.Parameters.AddWithValue("MiddleName", this.customer.MiddleName);
                        cmd.Parameters.AddWithValue("LastName", this.customer.LastName);
                        cmd.Parameters.AddWithValue("BirthDate", this.customer.Birthdate);
                        cmd.Parameters.AddWithValue("Age", this.customer.Age);
                        cmd.Parameters.AddWithValue("Address", this.customer.Address);
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
