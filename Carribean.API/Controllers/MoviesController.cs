
using Carribean.API.Models.Entities;
using Carribean.API.Services;

namespace Carribean.API.Controllers
{
    public class MoviesController : BaseController<Movie>
    {
        public MoviesController(IMovieService service) : base(service)
        {

        }
    }
}
