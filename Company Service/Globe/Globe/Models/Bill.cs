using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Bill : Customer
    {
        public int CustomerId { get; set; }
        public decimal BillAmount { get; set; }
    }
}
