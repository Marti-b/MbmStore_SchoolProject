using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie("Jungle Book", "Jon Favreau", 160.50m, "junglebook.jpg");
            var theDarkKnight = new Movie("The Dark Knight", "Christopher Nolan", 180.99m, "dark-knight.jpg");
            var forestGump = new Movie("Forrest Gump", "Robert Zemeckis", 155.70m, "forrest-gump.jpg");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.TheDarkKnight = theDarkKnight;
            ViewBag.ForrestGump = forestGump;

            // return the default view
            return View();
        }
    }
}