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
        public decimal TotalPrice { get; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {

        }
    }
}
