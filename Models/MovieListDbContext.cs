using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class MovieListDbContext : DbContext
    {
        public MovieListDbContext(DbContextOptions<MovieListDbContext> options) : base (options) { }

        public DbSet<Movie> Movies { get; set; }

    }
}
