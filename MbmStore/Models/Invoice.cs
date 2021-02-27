using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice 
    {
        private decimal totalPrice;

        public int InvoiceId { get; set; }
        public decimal TotalPrice {
            get
            {
                totalPrice = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    totalPrice += orderItem.TotalPrice;
                }

                return totalPrice;


            }
            


        }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
