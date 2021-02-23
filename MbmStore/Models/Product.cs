using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public Product() { }
        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

    }
}
