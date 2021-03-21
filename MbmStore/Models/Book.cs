using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public int ISBN { get; set; }
        
        public Book(){}

        public Book(string author, string title, decimal price, short published, int isbn, string imageFileName,
            int productID) : base(productID, title, price)
        {
            Author = author;
            ISBN = isbn;
            Published = published;
            ImageFileName = imageFileName;
        }
    }
}
