using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VecoModels
{
    public class PaymentDetails
    {
        public Customer customer { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
