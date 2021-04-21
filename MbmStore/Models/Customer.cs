using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        private DateTime birthDate;
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate
        {

            set
            {
                if (Age! <= 120 && Age! >= 0)
                {
                    throw new Exception("Age is not accepted");
                }
                else
                {

                    birthDate = value;
                }
            }
            get { return birthDate; }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }

        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Phone> PhoneNumbers { get; set; } = new List<Phone>();

        public Customer() { }
        public Customer(int customerId, string firstName, string lastName, string address, string city, string zip, DateTime birthDate)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            Zip = zip;

            BirthDate = birthDate;
        }

        public void AddPhone(Phone phone)
        {
            PhoneNumbers.Add(phone);
        }
    }
}
