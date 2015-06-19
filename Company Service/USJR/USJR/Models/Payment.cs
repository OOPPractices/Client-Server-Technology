using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Payment : Student
    {
        [DataMember]
        public decimal PaymentAmount { get; set; }
        [DataMember]
        public int StudentId { get; set; }
    }
}
