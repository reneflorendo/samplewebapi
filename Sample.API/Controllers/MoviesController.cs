using Microsoft.AspNetCore.Mvc;

using Sample.Application;
using Sample.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
           _movieService = movieService;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var newmovie = _movieService.CreateMovie(movie);
            return Ok(newmovie);
        }
           }
}
