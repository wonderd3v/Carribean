using Carribean.API.Models.Entities;
using Carribean.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carribean.API.Controllers
{
    public class TicketController : BaseController<Ticket>
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketServices) : base(ticketServices)
        {
            _ticketService = ticketServices;
        }

        [HttpGet("{userId}/user")]
        public IActionResult GetUserTickets(int userId) 
        {
            var userTickets = _ticketService.GetUserTickets(userId);

            if (userTickets == null)
                return NoContent();

            return Ok(userTickets);
        }
    }
}
