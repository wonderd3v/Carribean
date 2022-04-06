namespace Carribean.API.Models.Entities
{
    public class Seat : BaseModel
    {
        public string? SeatCode { get; set; }
        public bool IsAvailable { get; set; } 
        public int? RoomNumber { get; set; }
    }
}
