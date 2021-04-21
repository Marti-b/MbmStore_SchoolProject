using System;
using Microsoft.EntityFrameworkCore;
using MbmStore.Models;
namespace MbmStore.Data
{
    public class MbmStoreContext : DbContext
    {
        public MbmStoreContext(DbContextOptions<MbmStoreContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MusicCD> MusicCDs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Phone>().ToTable("Phone");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<Product>().ToTable("Product");

            modelBuilder.Entity<Book>().HasData(
        new Book
        {
            ProductId = 1,
            Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ",
            Author = "Steve Turner",
            Price = 150.00M,
            Publisher = "It Books",
            Published = 2005,
            ISBN = "978-0060844097",
            ImageUrl = "A_Hard_Days_Write.jpg",
            Category = "Book"
        },
        new Book
        {
            ProductId = 2,
            Title = "With a Little Help from My Friends: The Making of Sgt.Pepper",
            Author = "Georg Martin",
            Price = 180.00M,
            Publisher = "Little Brown &Co",
            Published = 1995,
            ISBN = "0316547832",
            ImageUrl = "The Making of Sgt.Pepper.jpg",
            Category
= "Book"
        }
 );
            modelBuilder.Entity<MusicCD>().HasData(
            new MusicCD
            {
                ProductId = 3,
                Title = "Abbey Road (Remastered)",
                Artist = "Beatles",
                Price = 128.00M,
                Released = 2009,
                Label = "EMI",
                ImageUrl = "abbey_road.jpg",
                Category = "MusicCD"
            },
            new MusicCD
            {
                ProductId = 4,
                Title = "Revolver (Remastered)",
                Artist = "The Beatles",
                Price = 128.00M,
                Released = 2009,
                Label = "EMI",
                ImageUrl = "revolver.jpg",
                Category = "MusicCD"
            }
            );
            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                ProductId = 5,
                Title = "Jungle Book",
                Price = 160.50M,
                ImageUrl =
           "junglebook.jpg",
                Director = "Jon Favreau",
                Category = "Movie"
            },
            new Movie
            {
                ProductId = 6,
                Title = "Gladiator",
                Price = 49.95M,
                ImageUrl =
           "gladiator.jpg",
                Director = "Ridley Scott",
                Category = "Movie"
            },
            new Movie
            {
                ProductId = 7,
                Title = "Forrest Gump",
                Price = 160.50M,
                ImageUrl =
           "forrest-gump.jpg",
                Director = "Robert Zemeckis",
                Category = "Movie"
            }
            );
            modelBuilder.Entity<Track>().HasData(
            new Track
            {
                TrackId = 1,
                Title = "Come Together",
                Length = new TimeSpan(0, 4,
           20),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 2,
                Title = "Something",
                Length = new TimeSpan(0, 3, 03),
                Composer = "Harrison"
            },
            new Track
            {
                TrackId = 3,
                Title = "Maxwell's Silver Hammer",
                Length = new
           TimeSpan(0, 3, 29),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 4,
                Title = "Oh! Darling",
                Length = new TimeSpan(0, 3,
           26),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 5,
                Title = "Octopus's Garden",
                Length = new TimeSpan(0,
           2, 51),
                Composer = "Starkey"
            },
            new Track
            {
                TrackId = 6,
                Title = "I Want You (She's So Heavy)",
                Length = new
           TimeSpan(0, 7, 47),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 7,
                Title = "Here Comes The Sun",
                Length = new
           TimeSpan(0, 3, 05),
                Composer = "Harrison"
            },
            new Track
            {
                TrackId = 8,
                Title = "Because",
                Length = new TimeSpan(0, 2, 45),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 9,
                Title = "You Never Give Me Your Money",
                Length = new
           TimeSpan(0, 4, 02),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 10,
                Title = "Sun King",
                Length = new TimeSpan(0, 2, 26),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 11,
                Title = "Mean Mr. Mustard",
                Length = new TimeSpan(0,
           1, 6),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 12,
                Title = "Polythene Pam",
                Length = new TimeSpan(0, 1,
           12),
                Composer = "Lennon, McCartney"
            },


            new Track
            {
                TrackId = 13,
                Title = "She Came In Through The Bathroom Window",
                Length = new TimeSpan(0, 1, 57),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 14,
                Title = "Golden Slumbers",
                Length = new TimeSpan(0,
           1, 31),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 15,
                Title = "Carry That Weight",
                Length = new
           TimeSpan(0, 1, 36),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 16,
                Title = "The End",
                Length = new TimeSpan(0, 2, 19),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 17,
                Title = "Her Majesty",
                Length = new TimeSpan(0, 0,
           23),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 18,
                Title = "Taxman",
                Length = new TimeSpan(0, 2, 28),
                Composer = "Harrison"
            },
            new Track
            {
                TrackId = 19,
                Title = "Eleanor Rigby",
                Length = new TimeSpan(0, 2,
           6),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 20,
                Title = "I'm Only Sleeping",
                Length = new
           TimeSpan(0, 3, 0),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 21,
                Title = "Love You To",
                Length = new TimeSpan(0, 2,
           59),
                Composer = "Harrison"
            },
            new Track
            {
                TrackId = 22,
                Title = "Here, There And Everywhere",
                Length = new
           TimeSpan(0, 2, 23),
                Composer = "Harrison"
            },
            new Track
            {
                TrackId = 23,
                Title = "Yellow Submarine",
                Length = new TimeSpan(0,
           2, 38),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 24,
                Title = "She Said She Said",
                Length = new
           TimeSpan(0, 2, 36),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 25,
                Title = "Good Day Sunshine",
                Length = new
           TimeSpan(0, 2, 9),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 26,
                Title = "And Your Bird Can Sing",
                Length = new
           TimeSpan(0, 2, 0),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 27,
                Title = "For No One",
                Length = new TimeSpan(0, 1,
           59),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 28,
                Title = "Doctor Robert",
                Length = new TimeSpan(0, 1,
           14),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 29,
                Title = "I Want To Tell You",
                Length = new
           TimeSpan(0, 2, 27),
                Composer = "Harrison"
            },
            new Track
            {
                TrackId = 30,
                Title = "Got To Get You Into My Life",
                Length = new
           TimeSpan(0, 2, 29),
                Composer = "Lennon, McCartney"
            },
            new Track
            {
                TrackId = 31,
                Title = "Tomorrow Newer Knows",
                Length = new
           TimeSpan(0, 3, 01),
                Composer = "Lennon, McCartney"
            });
            modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                CustomerId = 1,
                FirstName = "Tina",
                LastName = "Petterson",
                Address = "Irisdahlsvej 32",
                Zip = "8200",
                City = "Århus N"
            },
            new Customer
            {
                CustomerId = 2,
                FirstName = "Thomas",
                LastName = "Larsson",
                Address = "Solsikkevej 32",
                Zip = "8000",
                City = "Århus C"
            }
            );
            modelBuilder.Entity<Invoice>().HasData(
            new Invoice
            {
                InvoiceId = 1,
                OrderDate = new DateTime(2018, 09, 12),
                CustomerId = 1
            },
            new Invoice
            {
                InvoiceId = 2,
                OrderDate = new DateTime(2018, 09, 18),
                CustomerId = 2
            }
            );
            modelBuilder.Entity<OrderItem>().HasData(
            new OrderItem { OrderItemId = 1, ProductId = 7, Quantity = 1, InvoiceId = 1 },
            new OrderItem { OrderItemId = 2, ProductId = 2, Quantity = 1, InvoiceId = 1 },
            new OrderItem { OrderItemId = 3, ProductId = 1, Quantity = 1, InvoiceId = 2 },
            new OrderItem { OrderItemId = 4, ProductId = 3, Quantity = 1, InvoiceId = 2 }
            );

        }
    }
}