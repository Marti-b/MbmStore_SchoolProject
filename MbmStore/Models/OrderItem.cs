using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {

        
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int InvoiceId { get; set; }

        public decimal TotalPrice => Product.Price * Quantity;

        public OrderItem() { }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public OrderItem(int orderItemId, Product product, int quantity)
        {
            OrderItemId = orderItemId;
            Product = product;
            Quantity = quantity;

        }

    }
}
