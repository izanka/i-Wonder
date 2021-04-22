using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MoviesWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieApiService _movieApiService;

        public HomeController(IMovieApiService movieApiService)
        {
            _movieApiService = movieApiService;
        }

        public async Task<IActionResult> Index(string title, string type)
        {
            List<MovieModel> movies = new List<MovieModel>();
            movies = await _movieApiService.GetMovies(title, type);

            return View(movies);
        }
    }
}