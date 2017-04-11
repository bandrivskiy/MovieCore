using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListOfMovies.Entities;
using ListOfMovies.Models;

namespace ListOfMovies.DAL
{
    public class MovieDbContext: DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
           
        }
        

       
    }
}
