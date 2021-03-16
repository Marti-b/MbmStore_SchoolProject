using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public decimal TotalPrice { get; set; }
        public List<CartLine> LineCollection { get; }

        public virtual void AddItem(Product product, int quantity)
        {
            // Checking to see if the product is already in the cart
            CartLine item = lineCollection
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();

            // Add product or update quantity
            if (item == null)
            {
                lineCollection.Add(new CartLine(item.Product = product, item.Quantity = quantity));
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public virtual void RemoveItem(Product product)
        {
            lineCollection.RemoveAll(item => item.Product.ProductID == product.ProductID);
        }

        public decimal  ComputeTotalValue() =>
        
            lineCollection.Sum(e => e.Quantity * e.Product.Price);
    
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public CartLine(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
