using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public Product() { }
        public Product(int productID ,string title, decimal price)
        {
            ProductId = productID;
            Title = title;
            Price = price;
        }

    }
}
