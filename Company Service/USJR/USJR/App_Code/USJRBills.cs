using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for USJRBills
/// </summary>
[WebService(Namespace = "http://usjr.edu.ph/",Description="University of San Jose Recoletos",Name="USJR Payments")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class USJRBills : System.Web.Services.WebService {

    public USJRBills () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    
    [WebMethod]
    public Student getStudentBill(string refno)
    {
        return new Student();
    }
    [WebMethod]
    public Boolean PayStudentsBill(Student student, decimal payments)
    {
        return true;
    }
    [WebMethod]
    public string getStudentPaymentHistory(string studentID)
    {
        return "";
    }

}
