using Carribean.API.Models;
using Carribean.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carribean.API.Services
{
    public interface IMovieService : IBaseService<Movie> 
    {
        List<Movie> GetMoviesByGender(string gender);
    }

    public class MovieService : BaseServices<Movie>, IMovieService
    {
   
        public MovieService(Context context) : base(context)
        {
        }

        public List<Movie> GetMoviesByGender(string gender) 
        {
            var moviesByGender = Query()
                                .Where(movie => movie.Gender == gender).ToList();

            return moviesByGender;
        }   
    }
}
