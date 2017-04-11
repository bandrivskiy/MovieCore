using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListOfMovies.DAL;
using ListOfMovies.Models;

namespace ListOfMovies.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;
        
        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<MovieViewModel> model = new List<MovieViewModel>();
            var moviesList  = _repository.GetMovies();
            foreach(var movie in moviesList)
            {
                model.Add(new MovieViewModel {
                    ID = movie.ID,
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    Price = movie.Price,
                    Genre = movie.Genre });
            }
            return View(model);
        }
    }
}