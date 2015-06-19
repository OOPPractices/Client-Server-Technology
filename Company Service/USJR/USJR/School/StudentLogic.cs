using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using Models;
using System.Configuration;

namespace School
{
    public class StudentLogic
    {

        public Student getStudentTuition(int StudentId)
        {
            Student student = new Student();
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["USJR"].ConnectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT");
                sql.Append("    `FirstName`, ");
                sql.Append("    `MiddleName`, ");
                sql.Append("    `LastName`, ");
                sql.Append("    `Age`, ");
                sql.Append("    `Address`, ");
                sql.Append("    `BirthDate`, ");
                sql.Append("    `BillAmount` ");
                sql.Append("FROM");
                sql.Append("    `usjr`.`student` AS s ");
                sql.Append("INNER JOIN");
                sql.Append("    `usjr`.`tuitions` AS t ");
                sql.Append("ON");
                sql.Append("    t.`StudentId` = s.`StudentId` ");
                sql.Append("WHERE");
                sql.Append("    t.`StudentId` = @StudentId; ");

                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), con))
                {
                    cmd.Parameters.AddWithValue("StudentId", StudentId);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (rdr.Read())
                        {
                            student.FirstName = rdr.GetString("FirstName");
                            student.MiddleName = rdr.GetString("MiddleName");
                            student.LastName = rdr.GetString("LastName");
                            student.Age = rdr.GetInt32("Age");
                            student.Birthdate = rdr.GetDateTime("BirthDate");
                            student.Address = rdr.GetString("Address");
                            student.Bill = rdr.GetDecimal("BillAmount");
                            rdr.Close();
                        }
                    }
                }
            }
            return student;
        }
    }
}
