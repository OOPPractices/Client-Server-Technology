using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public DateTime Birthdate { get; set; }
        [DataMember]
        public decimal Bill { get; set; }
    }
}
