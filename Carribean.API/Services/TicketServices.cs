using Carribean.API.Models;
using Carribean.API.Models.Entities;

namespace Carribean.API.Services
{

    public interface ITicketService : IBaseService<Ticket>
    {
        List<Ticket>? GetUserTickets(int userId);
    }
    public class TicketServices : BaseServices<Ticket>, ITicketService
    {
        public TicketServices(Context context) : base(context)
        {
        }
        public List<Ticket>? GetUserTickets(int userId)
        {
            var ticketsByUser = Query()
                        .Where(x => x.UserId == userId).ToList();

            var ticketsByThisUserExist = ticketsByUser == null || ticketsByUser.Count == 0;

            if (ticketsByThisUserExist)
                return null;

            return ticketsByUser;
        }
    }
}
