using ListOfMovies.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfMovies.DAL
{
    public class MovieRepository : IMovieRepository
    {

        private readonly MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.AsNoTracking().ToList();
        }

    }
}
