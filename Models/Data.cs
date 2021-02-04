using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Data
    {
        // Create a list of movies 
        private static List<Movie> movies = new List<Movie>();

        // Not 100% sure about this Ienumberable stuff yet
        public static IEnumerable<Movie> Movies => movies;

        // method to add a movie to the list
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
    }
}
