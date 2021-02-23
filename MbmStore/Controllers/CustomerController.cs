using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();

            
            Customer c1 = new Customer("John", "Malkovic", "whatever", "New York", "6666", new DateTime(1965, 12, 12));
            c1.AddPhone("+495694428");
            customers.Add(c1);

            Customer c2 = new Customer(firstName:"Kevin", lastName:"Forest", address:"whatever", city:"Los Angeles", zip:"6666", new DateTime(1978, 11, 29));
            c2.AddPhone("+3620978456");
            customers.Add(c2);

            // List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer(firstName: "John", lastName: "Malkovic", address: "Bilbo Avenue", city: "New York", zip: "6578", 
            //    phoneNumber:AddPhoneNumber("+495694428"),
            //    birthDate:new DateTime(1965, 12,12)
            //    ));

            //customers.Add(new Customer(firstName: "Kevin", lastName: "Forest", address: "Whatever street", city: "Los Angeles", zip: "8315",
            //  phoneNumber: AddPhoneNumber("+3620978456"),
            //  birthDate: new DateTime(1978,11,29)
            //  ));

            ViewBag.Customers = customers; 
            
            return View();
        }
        
        //public List<string> AddPhoneNumber(string phone)
        //{
        //    List<string> newNumber = new List<string>();
        //    newNumber.Add(phone);

        //    return newNumber;
            
        //}

    }
}
