using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesDBContext _context;

        public MoviesController(MoviesDBContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            List<Movie> listMovies =  _context.Movies.ToList();
            return View(listMovies);
        }

        public IActionResult Details(int id)
        {
            Movie movie = _context.Movies
                .Include(x=> x.Rating)
                .Where(x => x.MovieId == id).SingleOrDefault();
            return View(movie);
        }
    }
}