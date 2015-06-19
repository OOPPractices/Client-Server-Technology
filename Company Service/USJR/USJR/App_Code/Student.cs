using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Student
/// </summary>
public class Student
{
	public Student()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string StudentId { get; set; }
    public string FirstName { get; set; }    
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public decimal Payments { get; set; }
}