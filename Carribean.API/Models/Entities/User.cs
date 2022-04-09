using Carribean.API.Models.Enums;

namespace Carribean.API.Models.Entities
{
    public class User : BaseModel
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public Roles Role { get; set; }
        
        public ICollection<Ticket>? Tickets { get; set; }
    }
}
