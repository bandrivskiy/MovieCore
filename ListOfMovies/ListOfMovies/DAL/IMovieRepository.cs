using ListOfMovies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfMovies.DAL
{
   public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
    }
}
