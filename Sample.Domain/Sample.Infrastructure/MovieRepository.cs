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
        public static List<Movie> movies = new List<Movie>(){
        new Movie{Id=1, Name="Who I am", Cost=2 },
        new Movie{ Id=4, Name="What the ...", Cost=5 }
        };
        private readonly MovieDBContext _movieDBContext;

        public MovieRepository(MovieDBContext movieDBContext)
        {
            _movieDBContext = movieDBContext;
        }
        public Movie CreateMovie(Movie movie)
        {
            _movieDBContext.Movies.Add(movie);
            _movieDBContext.SaveChangesAsync();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDBContext.Movies.ToList();
        }
    }
}
