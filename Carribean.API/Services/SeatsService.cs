using Carribean.API.Models;
using Carribean.API.Models.Entities;

namespace Carribean.API.Services
{
    public interface ISeatsService : IBaseService<Seat> 
    {
        List<Seat>? AvailableSeats();
        Task UpdateAvailabilityBySeatCode(string seatCode);
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

        public async Task UpdateAvailabilityBySeatCode(string seatCode)
        {
            var seat = Query()
                      .Where(s => s.SeatCode == seatCode)
                      .FirstOrDefault();

            seat.IsAvailable = true;
            _context.Update(seat);

            await _context.SaveChangesAsync();
        }
    }
}
