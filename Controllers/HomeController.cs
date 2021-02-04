using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Home View
        public IActionResult Index()
        {
            return View();
        }

        // Take them to the Podcast page
        public IActionResult Podcasts()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AddMovie()
        {
            // Get method, just show them the add movie page
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            //post method
            // if the model is valid, add it to the list and then take them to the home page
            if (ModelState.IsValid)
            {
                Data.AddMovie(movie);
                return View("Index");
            }
            else
            {
                // if it isn't valid keep them on the page
                return View();
            }  
        }

        public IActionResult MovieList()
        {
            // take them to the Movie list page and pass the list of movies but only if
            // the movies name is not Independence Day
            return View(Data.Movies.Where(x => x.Title != "Independence Day"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
