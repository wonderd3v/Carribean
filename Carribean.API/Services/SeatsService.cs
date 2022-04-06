using Carribean.API.Models;
using Carribean.API.Models.Entities;

namespace Carribean.API.Services
{
    public interface ISeatsService : IBaseService<Seat> { }
    public class SeatsService : BaseServices<Seat>, ISeatsService
    {
        public SeatsService(Context context) : base(context) { }
    }
}
