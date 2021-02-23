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
            List<Book> bookList = new List<Book>();
            bookList.Add(book);

            // MusicCD
            MusicCd musicCd = new MusicCd("Laurent Garnier", "Timeless EP", 9, 2019);
            List<MusicCd> musicCdList = new List<MusicCd>();
            musicCd.AddTrack("Jacques In The Box");
            musicCd.AddTrack("Our Futur (Loud Disco Mix)");
            musicCd.AddTrack("Positif (Midfield General Re-Edit)");
            musicCdList.Add(musicCd);

            ViewBag.BookList = bookList;
            ViewBag.MusicCD = musicCdList;

            return View();
        }
    }
}
