using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            // Book
            Book book = new Book("J.K.Rowling","Harry Potter",11, 2001, 0005125126);
            Book book2 = new Book("James Clavel", "Shogun", 6, 1975, 546883256);
            Book book3 = new Book("Jon Skeet", "C# in Depth", 12, 2008, 12579893);
            List<Book> bookList = new List<Book>();
            bookList.Add(book);
            bookList.Add(book2);
            bookList.Add(book3);

            // MusicCD
            MusicCd musicCd = new MusicCd("Laurent Garnier", "Timeless EP", 9, 2019);
            List<MusicCd> musicCdList = new List<MusicCd>();
            musicCd.AddTrack("Jacques In The Box");
            musicCd.AddTrack("Our Futur (Loud Disco Mix)");
            musicCd.AddTrack("Positif (Midfield General Re-Edit)");
            musicCdList.Add(musicCd);

            MusicCd musicCdTwo = new MusicCd("Middlemist Red", "Supersonic Overdrive", 23, 2014);
            musicCdTwo.AddTrack("Age Of The Avalon");
            musicCdTwo.AddTrack("Multicolored Drive");
            musicCdTwo.AddTrack("Alas");
            musicCdTwo.AddTrack("Sundowner");
            musicCdTwo.AddTrack("Overseas");
            musicCdTwo.AddTrack("Black Lips");
            musicCdTwo.AddTrack("Fever In Your Eyes");
            musicCdTwo.AddTrack("Single switcheroo");
            musicCdTwo.AddTrack("Winter Enclose Me");
            musicCdTwo.AddTrack("Animal");
            musicCdList.Add(musicCdTwo);

            MusicCd musicCdThree = new MusicCd("Coldplay", "Ghost Stories", 17, 2014);
            musicCdThree.AddTrack("Always in My Head");
            musicCdThree.AddTrack("Magic");
            musicCdThree.AddTrack("Ink");
            musicCdThree.AddTrack("True Love");
            musicCdThree.AddTrack("Midnight");
            musicCdThree.AddTrack("Another's Arms");
            musicCdList.Add(musicCdThree);

            ViewBag.BookList = bookList;
            ViewBag.MusicCD = musicCdList;

            return View();
        }
    }
}
