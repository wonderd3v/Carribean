namespace Carribean.API.Models
{
    public interface IBaseModel
    {
        public int Id { get; set; }
        public string Hola { get; set; }
    }
    public class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public string? Hola { get; set; }
    }
}
