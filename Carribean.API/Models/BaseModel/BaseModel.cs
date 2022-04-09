using System.ComponentModel.DataAnnotations;

namespace Carribean.API.Models
{
    public interface IBaseModel
    {
        public int Id { get; set; }
        public string Hola { get; set; }
    }
    public class BaseModel : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string? Hola { get; set; }
    }
}
