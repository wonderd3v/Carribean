using Carribean.API.Models;
using Carribean.API.Models.Entities;

namespace Carribean.API.Services
{
    public interface IMovieService : IBaseService<Movie> { }

    public class MovieService : BaseServices<Movie>, IMovieService
    {
        public MovieService(Context context) : base(context)
        {
        }
    }
}
