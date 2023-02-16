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
        public MovieContext (DbContextOptions<MovieContext>options) : base(options)
        {
            // Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Action/Adventure"},
                    new Category { CategoryId = 2, CategoryName = "Comedy"},
                    new Category { CategoryId = 3, CategoryName = "Romance"},
                    new Category { CategoryId = 4, CategoryName = "Horror"},
                    new Category { CategoryId = 5, CategoryName = "Holiday"},
                    new Category { CategoryId = 6, CategoryName = "None"}
                );

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 1,
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                },

                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryId = 3,
                    Title = "Avatar",
                    Year = 2009,
                    Director = "James Cameron",
                    Rating = "PG-13",
                },

                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryId = 6,
                    Title = "The Avengers",
                    Year = 2012,
                    Director = "Anthony Russo",
                    Rating = "PG-13",
                }

             );
        }
    }
}
