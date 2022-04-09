namespace Carribean.API.Models.Entities
{
    public class Ticket : BaseModel
    {
        public string? TicketCode { get; set; }
        public bool IsAlreadyPrinted { get; set; }
        public string? MovieName { get; set; }
        public string? Seat { get; set; }
        public string? Schedule { get; set; }
        public decimal? TicketPrice { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
