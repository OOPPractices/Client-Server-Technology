using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;
using School;

namespace USJRWCF
{    
    public class USJRService : IUSJRService
    {
        public Student SearchStudentTuition(int studentID)
        {
            return new StudentLogic().getStudentTuition(studentID);
        }

        public bool SaveStudentPayments(Payment payment)
        {
            return new PaymentLogic(payment).ProcessStudentPayment();
        }
    }
}
