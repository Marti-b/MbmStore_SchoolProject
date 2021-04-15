using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace MbmStore.Models.ViewModels
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public decimal TotalPrice { get; set; }

        public List<CartLine> Lines => lineCollection;
        public virtual void AddItem(Product product, int quantity)
        {
            // Checking to see if the product is already in the cart
            CartLine item = lineCollection
                .FirstOrDefault(p => p.Product.ProductID == product.ProductID);

            // Add product or update quantity
            if (item == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(item => item.Product.ProductID == product.ProductID);
        }
        //Linq sytanx, return total price for all products in the cart
        public decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Quantity * e.Product.Price);

        public virtual void Clear() => lineCollection.Clear();

    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        
    }
}
