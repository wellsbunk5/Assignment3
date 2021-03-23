using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieListDbContext _context;

        public EFMovieRepository(MovieListDbContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }
}
