using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public string PhoneType { get; set; }

        public Customer Customer { get; set; }
        public Phone() { }
        public Phone(int phoneId, string number, int customerId, string type)
        {
            PhoneId = phoneId;
            Number = number;
            CustomerId = customerId;
            PhoneType = type;
        }
    }
}
