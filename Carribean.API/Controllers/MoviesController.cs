
using Carribean.API.Models.Entities;
using Carribean.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carribean.API.Controllers
{
    public class MoviesController : BaseController<Movie>
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService) : base(movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("{gender}/gender")]
        public IActionResult GetMoviesByGender(string gender)
        {
            var moviesByGender = _movieService.GetMoviesByGender(gender);

            if (moviesByGender.Any() is false)
                return NoContent();

            return Ok(moviesByGender);
        }
    }
}
