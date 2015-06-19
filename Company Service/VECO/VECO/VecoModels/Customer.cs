using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VecoModels
{
    public class Customer
    {        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }        
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
