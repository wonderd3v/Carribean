namespace Carribean.API.Models.Entities
{
    public class Movie : BaseModel
    { 
        public string? Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Gender { get; set; }
        public decimal? TicketPrice { get; set; }
        public string? Duration { get; set; }
        public string? Photo { get; set; }
        public string? Sinopsis{ get; set; }
    }
}
