using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Payment : Bill
    {
        public decimal PaymentAmount { get; set; }
    }
}
