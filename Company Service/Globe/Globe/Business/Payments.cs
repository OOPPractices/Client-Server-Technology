using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace Business
{
    public class PaymentLogic
    {
        private Payment payment;

        public PaymentLogic(Payment payment)
        {
            this.payment = payment;
        }

        public bool SavePayments()
        {

            int rowsAffected;
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["Globe"].ConnectionString))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE `globe`.`bill` SET `Payments` = @PaymentAmount , `PaymentsDate` = NOW() WHERE CustomerId = @customerId;");

                    con.Open();
                    MySqlTransaction trans = con.BeginTransaction();

                    using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("PaymentAmount", this.payment.PaymentAmount);
                        cmd.Parameters.AddWithValue("customerId",this.payment.CustomerId);
                        rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected != 1)
                        {
                            trans.Rollback();
                            return false;
                        }

                        sql.Length = 0;
                        sql.Append("INSERT INTO");
                        sql.Append("    `globe`.`billslog`");
                        sql.Append("    (`CustomerId`,`TransactionDetails`) ");
                        sql.Append("VALUES (@CustomerId,@Details); ");
                        
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CustomerId", this.payment.CustomerId);
                        cmd.Parameters.AddWithValue("@Details",JsonConvert.SerializeObject(this.payment));
                        rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected != 1)
                        {
                            trans.Rollback();
                            return false;
                        }
                        else
                        {
                            trans.Commit();
                            return true;
                        }
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
