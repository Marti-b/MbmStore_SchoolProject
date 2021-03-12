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
            //List<Book> books = Repository.Products.OfType<Book>().ToList();
            //List<MusicCd> musicCds = Repository.Products.OfType<MusicCd>().ToList();
            //List<Movie> movies = Repository.Products.OfType<Movie>().ToList();

            //ViewBag.Books = books;
            //ViewBag.MusicCds = musicCds;
            //ViewBag.Movies = movies;

            return View(Repository.Products);
        }
    }
}