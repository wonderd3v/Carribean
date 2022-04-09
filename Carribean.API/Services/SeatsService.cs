using Carribean.API.Models;
using Carribean.API.Models.Entities;

namespace Carribean.API.Services
{
    public interface ISeatsService : IBaseService<Seat> 
    {
        List<Seat>? AvailableSeats();
    }
    public class SeatsService : BaseServices<Seat>, ISeatsService
    {
        public SeatsService(Context context) : base(context) { }

        public List<Seat>? AvailableSeats()
        {
            var availableSeats = Query()
                            .Where(seats => seats.IsAvailable == true)
                            .ToList();

            var existAvailableSeats = availableSeats == null || availableSeats.Count == 0;

            if (existAvailableSeats)
                return null;

            return availableSeats;
        }
    }
}
