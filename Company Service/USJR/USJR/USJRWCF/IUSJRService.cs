using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;

namespace USJRWCF
{
    [ServiceContract]
    public interface IUSJRService
    {
        [OperationContract]
        Student SearchStudentTuition(int studentID);

        [OperationContract]
        bool SaveStudentPayments(Payment payment);
    }
}
