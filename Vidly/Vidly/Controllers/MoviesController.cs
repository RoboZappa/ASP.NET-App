using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Submarine"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Oliver Tate"},
                new Customer {Name = "Jordana Bevan"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
               
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
//            if (!pageIndex.HasValue)
//                pageIndex = 1;
//
//            if (String.IsNullOrWhiteSpace(sortBy))
//                sortBy = "Name";
//
//            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");


            var movies = GetMovies();
            return View(movies);
        }

        [Route("movies/release/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Submarine"},
                new Movie {Name = "Better Living Through Chemistry"}
            };
        }
    }
    
   
}