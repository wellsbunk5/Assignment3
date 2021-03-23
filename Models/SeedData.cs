using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            // set up the context variable
            MovieListDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MovieListDbContext>();

            // if there is a knew migration then run it
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            // if there is no data in the database then put this in
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {
                        Category = "Action",
                        Title = "Warrior",
                        Director = "Wells",
                        Year = "2017",
                        Edited = false,
                        LentTo = null,
                        Rating = "PG-13",
                        Notes = null
                    });
                context.SaveChanges();
            }
        }
    }
    
}
