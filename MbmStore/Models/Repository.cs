//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MbmStore.Models
//{
//    public static class Repository
//    {
//        public static List<Product> Products = new List<Product>();
//        public static List<Invoice> Invoices = new List<Invoice>();

//        static Repository()
//        {
//            //Books
//            Book book = new Book("J.K.Rowling", "Harry Potter", 11, 2001, 0005125126, "harry.jpg", 1001);
//            book.Category = "Book";
//            Book book2 = new Book("James Clavel", "Shogun", 6, 1975, 546883256, "shogun.jpg", 1002);
//            book2.Category = "Book";
//            Book book3 = new Book("Jon Skeet", "C# in Depth", 12, 2008, 12579893, "c#.jpg", 1003);
//            book3.Category = "Book";
//            Products.Add(book);
//            Products.Add(book2);
//            Products.Add(book3);

//            //Music Cd
//            MusicCD musicCd = new MusicCD("Laurent Garnier", "Timeless EP", 9, 2019, "time.jpg", 2001);
//            Track tr1 = new Track("Jacques In The Box", "Laurent Garnier", new TimeSpan(0, 4, 56));
//            Track tr2 = new Track("Our Futur (Loud Disco Mix", "Laurent Garnier", new TimeSpan(0, 7, 16));
//            Track tr3 = new Track("Positif (Midfield General Re-Edit", "Laurent Garnier", new TimeSpan(0, 5, 29));
//            musicCd.AddTrack(tr1);
//            musicCd.AddTrack(tr2);
//            musicCd.AddTrack(tr3);
//            musicCd.Category = "Music";
//            Products.Add(musicCd);

//            MusicCD musicCdTwo = new MusicCD("Middlemist Red", "Supersonic Overdrive", 23, 2014, "super.jpg", 2002);
//            musicCdTwo.Category = "Music";
//            Track cDTwoTrack1 = new Track("Age Of The Avalon", "Middlemist Red", new TimeSpan(0, 3, 59));
//            Track cDTwoTrack2 = new Track("Multicolored Drive", "Middlemist Red", new TimeSpan(0, 4, 11));
//            Track cDTwoTrack3 = new Track("Alas", "Middlemist Red", new TimeSpan(0, 4, 25));
//            Track cDTwoTrack4 = new Track("Sundowner", "Middlemist Red", new TimeSpan(0, 2, 55));
//            Track cDTwoTrack5 = new Track("Overseas", "Middlemist Red", new TimeSpan(0, 4, 35));
//            Track cDTwoTrack6 = new Track("Black Lips", "Middlemist Red", new TimeSpan(0, 6, 11));
//            Track cDTwoTrack7 = new Track("Fever In Your Eyes", "Middlemist Red", new TimeSpan(0, 5, 01));
//            Track cDTwoTrack8 = new Track("Single switcheroo", "Middlemist Red", new TimeSpan(0, 2, 51));
//            Track cDTwoTrack9 = new Track("Winter Enclose Me", "Middlemist Red", new TimeSpan(0, 3, 16));
//            Track cDTwoTrack10 = new Track("Animal", "Middlemist Red", new TimeSpan(0, 4, 03));
//            musicCdTwo.AddTrack(cDTwoTrack1);
//            musicCdTwo.AddTrack(cDTwoTrack2);
//            musicCdTwo.AddTrack(cDTwoTrack3);
//            musicCdTwo.AddTrack(cDTwoTrack4);
//            musicCdTwo.AddTrack(cDTwoTrack5);
//            musicCdTwo.AddTrack(cDTwoTrack6);
//            musicCdTwo.AddTrack(cDTwoTrack7);
//            musicCdTwo.AddTrack(cDTwoTrack8);
//            musicCdTwo.AddTrack(cDTwoTrack9);
//            musicCdTwo.AddTrack(cDTwoTrack10);
//            Products.Add(musicCdTwo);

//            MusicCD musicCdThree = new MusicCD("Coldplay", "Ghost Stories", 17, 2014, "ghost.png",2003);
//            musicCdThree.Category = "Music";
//            Track cDThreeTrack1 = new Track("Always in My Head", "Coldplay", new TimeSpan(0, 3, 59));
//            Track cDThreeTrack2 = new Track("Magic", "Coldplay", new TimeSpan(0, 3, 59));
//            Track cDThreeTrack3 = new Track("Ink", "Coldplay", new TimeSpan(0, 3, 59));
//            Track cDThreeTrack4 = new Track("True Love", "Coldplay", new TimeSpan(0, 3, 59));
//            Track cDThreeTrack5 = new Track("Another's Arms", "Coldplay", new TimeSpan(0, 3, 59));
//            Track cDThreeTrack6 = new Track("Midnight", "Coldplay", new TimeSpan(0, 3, 59));
//            musicCdThree.AddTrack(cDThreeTrack1);
//            musicCdThree.AddTrack(cDThreeTrack2);
//            musicCdThree.AddTrack(cDThreeTrack3);
//            musicCdThree.AddTrack(cDThreeTrack4);
//            musicCdThree.AddTrack(cDThreeTrack5);
//            musicCdThree.AddTrack(cDThreeTrack6);
//            Products.Add(musicCdThree);

//            //Movies
//            Movie movie1 = new Movie("Joker", "Todd Phillips", 16, "joker.jfif" ,3001);
//            movie1.Category = "Movie";
//            Movie movie2 = new Movie("Split", "M. Night Shyamalan", 11, "split.jfif", 3002);
//            movie2.Category = "Movie";
//            Products.Add(movie1);
//            Products.Add(movie2);

//            // Customers
//            Customer c1 = new Customer("John", "Wick", "Sindicat", "New York", "666", new DateTime(1966, 12, 12));
//            Customer c2 = new Customer("Arnold", "schwarzenegger", "California", "Los Angeles", "5846", new DateTime(1947, 07, 30));
//            c1.AddPhone(new Phone(1, "+491502366", 1,"mobile"));
//            c2.AddPhone(new Phone(2, "+362097856", 2,"mobile"));
//            // Invoices
//            Invoice i1 = new Invoice(25975, new DateTime(2021, 02, 26), c1);
//            Invoice i2 = new Invoice(63579, new DateTime(2021, 01, 11), c2);

            
//            //Adding two OrderItem objects to the first Invoice object
//            i1.AddOrderItem(movie1, 1);
//            i1.AddOrderItem(book, 2);
//            i2.AddOrderItem(musicCdTwo, 5);
//            i2.AddOrderItem(musicCdThree, 2);

//            // Adding each Invoice object to the Invoices list.
            
//            Invoices.Add(i1);
//            Invoices.Add(i2);

//        }
//    }
//}
