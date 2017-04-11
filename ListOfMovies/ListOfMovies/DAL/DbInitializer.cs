using ListOfMovies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ListOfMovies.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Movies.Any())
            {
                return;   
            }

            int countRecords = 1000;
            var listOfMovies = DataGeneric<Movie>.CreateArr(countRecords);
            RandomData generic = new RandomData();
            for (int i = 0; i < listOfMovies.Length; i++)
            {
                listOfMovies[i] = new Movie
                {
                    ID = Guid.NewGuid(),
                    Title = generic.RandomString(),
                    ReleaseDate = generic.RandomDay(),
                    Price = generic.RandomPrice(),
                    Genre = generic.RandomString()
                };
            }

            foreach(Movie movie in listOfMovies)
            {
                context.Movies.Add(movie);
            }
            context.SaveChanges();

        }
    }
}
