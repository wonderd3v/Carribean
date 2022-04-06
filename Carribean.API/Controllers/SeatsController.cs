using Carribean.API.Models.Entities;
using Carribean.API.Services;

namespace Carribean.API.Controllers
{
    public class SeatsController : BaseController<Seat>
    {
        public SeatsController(ISeatsService service) : base(service)
        {
        }
    }
}
