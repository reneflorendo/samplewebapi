using Sample.Application;
using Sample.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>() { new Movie {Id=1,Name="Rene Movie", Cost=2} ,

        new Movie{Id=2, Name="Xan Movie", Cost=5 } };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
