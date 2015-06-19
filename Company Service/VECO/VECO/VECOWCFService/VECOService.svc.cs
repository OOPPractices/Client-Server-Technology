using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using VecoModels;
using VecoBusiness;

namespace VECOWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class VECOService : IVECOService
    {

        public CustomerBill getCustomerBill(string PaymentId)
        {
            return new CustomerBillLogic().getCustomerPayments(PaymentId);
        }

        public bool CustomerPaymentSave(Customer bill, int PaymentsId, decimal Amount)
        {
            
            return new PaymentsLogic(bill).ProcessPayment(PaymentsId, Amount);
        }
    }
}
