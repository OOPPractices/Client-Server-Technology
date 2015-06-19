using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Business;
using Models;

namespace GlobeService
{
    /// <summary>
    /// Summary description for GlobeService
    /// </summary>
    [WebService(Namespace = "http://globe.com.ph")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GlobeService : System.Web.Services.WebService
    {

        [WebMethod(Description = "Get Customer Bill")]
        public Bill getCustomerBill(string customerID)
        {
            return new CustomerBill().getCustomerBill(customerID);
        }

        [WebMethod(Description = "Pay Customer Bill")]
        public bool SaveCustomerPayments(Payment payment)
        {
            return new PaymentLogic(payment).SavePayments();
        }
    }
}
