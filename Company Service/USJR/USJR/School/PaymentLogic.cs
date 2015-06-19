using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace School
{
    public class PaymentLogic
    {
        private Payment payment;

        public PaymentLogic(Payment payment)
        {
            this.payment = payment;
        }

        public bool ProcessStudentPayment()
        {
            try
            {
                int rowsAffected;
                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["USJR"].ConnectionString))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE");
                    sql.Append("    `usjr`.`tuitions` ");
                    sql.Append("SET");
                    sql.Append("    `PaymentAmount` = @PaymentAmount AND ");
                    sql.Append("    `` = NOW() ");
                    sql.Append("WHERE");
                    sql.Append("    `` = @StudentId;");

                    con.Open();
                    MySqlTransaction trans = con.BeginTransaction();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Parameters.AddWithValue("PaymentAmount", this.payment.PaymentAmount);
                        cmd.Parameters.AddWithValue("StudentId", this.payment.StudentId);
                        rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected != 1)
                        {
                            trans.Rollback();
                            return false;
                        }

                        sql.Length = 0;
                        sql.Append("INSERT INTO");
                        sql.Append("    `usjr`.`logs` ");
                        sql.Append("    (`StudentId`,`history`)");
                        sql.Append("VALUES");
                        sql.Append("    (@StudentId,@details);");

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@StudentId", this.payment.StudentId);
                        cmd.Parameters.AddWithValue("@details", JsonConvert.SerializeObject(this.payment));

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
