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
            Track tr1 = new Track("Jacques In The Box", "Laurent Garnier", new TimeSpan(0,4, 56));
            Track tr2 = new Track("Our Futur (Loud Disco Mix", "Laurent Garnier", new TimeSpan(0,7, 16));
            Track tr3 = new Track("Positif (Midfield General Re-Edit", "Laurent Garnier", new TimeSpan(0,5, 29));
            //List<Tracks> tracksList1 = new List<Tracks>();
            //tracksList1.Add(tr1);
            //tracksList1.Add(tr2);
            //tracksList1.Add(tr3);
            musicCd.AddTrack(tr1);
            musicCd.AddTrack(tr2);
            musicCd.AddTrack(tr3);
            musicCdList.Add(musicCd);

            MusicCd musicCdTwo = new MusicCd("Middlemist Red", "Supersonic Overdrive", 23, 2014);
            Track cDTwoTrack1 = new Track("Age Of The Avalon", "Middlemist Red", new TimeSpan(0, 3, 59));
            Track cDTwoTrack2 = new Track("Multicolored Drive", "Middlemist Red", new TimeSpan(0, 4, 11));
            Track cDTwoTrack3 = new Track("Alas", "Middlemist Red", new TimeSpan(0, 4, 25));
            Track cDTwoTrack4 = new Track("Sundowner", "Middlemist Red", new TimeSpan(0, 2, 55));
            Track cDTwoTrack5 = new Track("Overseas", "Middlemist Red", new TimeSpan(0, 4, 35));
            Track cDTwoTrack6 = new Track("Black Lips", "Middlemist Red", new TimeSpan(0, 6, 11));
            Track cDTwoTrack7 = new Track("Fever In Your Eyes", "Middlemist Red", new TimeSpan(0, 5, 01));
            Track cDTwoTrack8 = new Track("Single switcheroo", "Middlemist Red", new TimeSpan(0, 2, 51));
            Track cDTwoTrack9 = new Track("Winter Enclose Me", "Middlemist Red", new TimeSpan(0, 3, 16));
            Track cDTwoTrack10 = new Track("Animal", "Middlemist Red", new TimeSpan(0, 4, 03));
            musicCdTwo.AddTrack(cDTwoTrack1);
            musicCdTwo.AddTrack(cDTwoTrack2);
            musicCdTwo.AddTrack(cDTwoTrack3);
            musicCdTwo.AddTrack(cDTwoTrack4);
            musicCdTwo.AddTrack(cDTwoTrack5);
            musicCdTwo.AddTrack(cDTwoTrack6);
            musicCdTwo.AddTrack(cDTwoTrack7);
            musicCdTwo.AddTrack(cDTwoTrack8);
            musicCdTwo.AddTrack(cDTwoTrack9);
            musicCdTwo.AddTrack(cDTwoTrack10);
            musicCdList.Add(musicCdTwo);

            MusicCd musicCdThree = new MusicCd("Coldplay", "Ghost Stories", 17, 2014);
            Track cDThreeTrack1 = new Track("Always in My Head", "Coldplay", new TimeSpan(0, 3, 59));
            Track cDThreeTrack2 = new Track("Magic", "Coldplay", new TimeSpan(0, 3, 59));
            Track cDThreeTrack3 = new Track("Ink", "Coldplay", new TimeSpan(0, 3, 59));
            Track cDThreeTrack4 = new Track("True Love", "Coldplay", new TimeSpan(0, 3, 59));
            Track cDThreeTrack5 = new Track("Another's Arms", "Coldplay", new TimeSpan(0, 3, 59));
            Track cDThreeTrack6 = new Track("Midnight", "Coldplay", new TimeSpan(0, 3, 59));
            musicCdThree.AddTrack(cDThreeTrack1);
            musicCdThree.AddTrack(cDThreeTrack2);
            musicCdThree.AddTrack(cDThreeTrack3);
            musicCdThree.AddTrack(cDThreeTrack4);
            musicCdThree.AddTrack(cDThreeTrack5);
            musicCdThree.AddTrack(cDThreeTrack6);
            musicCdList.Add(musicCdThree);

            ViewBag.BookList = bookList;
            ViewBag.MusicCD = musicCdList;

            return View();
        }
    }
}
