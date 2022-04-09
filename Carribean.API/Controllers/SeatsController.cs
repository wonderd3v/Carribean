using Carribean.API.Models.Entities;
using Carribean.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carribean.API.Controllers
{
    public class SeatsController : BaseController<Seat>
    {
        private readonly ISeatsService _seatsServices;
        public SeatsController(ISeatsService seatsServices) : base(seatsServices)
        {
            _seatsServices = seatsServices;
        }

        [HttpGet("availableSeats")]
        public IActionResult AvailableSeats()
        {
            var availableSeats = _seatsServices.AvailableSeats();

            if (availableSeats == null)
                return NoContent();

            return Ok(availableSeats);
        }

        [HttpPut("{seatCode}/availability")]
        public async Task<IActionResult> UpdateSeatavAilability(string seatCode)
        {
            await _seatsServices.UpdateAvailabilityBySeatCode(seatCode);

            return Ok();
        }
    }
}
