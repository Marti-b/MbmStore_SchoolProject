using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        private decimal price;
        private string imageFileName;
        

        // properties
        //public string Title { get; }
        public string Director { get; set; }

        public string ImageFileName {

            set { imageFileName = value; }
            get { return imageFileName; }
        }

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }


        // constructors
        public Movie() { }

        public Movie(string title, decimal price)
        {
            Title = title;
            this.price = price;
           
        }

        public Movie(string title, string director, decimal price, string imageFileName, int productID): base(productID, title, price)
        {
        
            Title = title;
            Director = director;
            this.price = price;
            this.imageFileName = imageFileName;
        }
    }
}