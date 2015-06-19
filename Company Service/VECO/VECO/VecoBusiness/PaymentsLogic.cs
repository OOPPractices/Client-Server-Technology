using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VecoModels;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace VecoBusiness
{
    public class PaymentsLogic
    {
        private PaymentDetails payments = new PaymentDetails();

        public PaymentsLogic(Customer customer)
        {
            this.payments.customer = customer;
        }

        public bool ProcessPayment(int customerId, decimal PaymentAmount)
        {   
            this.payments.PaymentAmount = PaymentAmount;
            int rowsAffected;
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["VECO"].ConnectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE customerbill SET Payments = @PaymentAmount , PaymentsDate = NOW() WHERE CustomerId = @customerId;");
                MySqlTransaction trans = null;
                con.Open();
                trans = con.BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con, trans))
                {
                    cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected != 1)
                    {
                        trans.Rollback();
                        return false;
                    }
                    sql.Length = 0;
                    sql.Append("INSERT INTO history(CustomerId,Logs)");
                    sql.Append("    VALUES (@CustomerId,@Logs);");
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@Logs", JsonConvert.SerializeObject(payments));
                    rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected != 1)
                        trans.Rollback();
                    trans.Commit();
                }
            }
            return true;
        }

    }
}
