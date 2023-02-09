using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set;  }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Action",
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Action",
                    Title = "Avatar",
                    Year = 2009,
                    Director = "James Cameron",
                    Rating = "PG-13"
                },

                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Action",
                    Title = "The Avengers",
                    Year = 2012,
                    Director = "Anthony Russo",
                    Rating = "PG-13"
                }

             );
        }
    }
}
