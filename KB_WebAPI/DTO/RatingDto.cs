using System.ComponentModel.DataAnnotations;

namespace KB_WebAPI.DTO
{
    public class RatingDto
    {
        public Guid RatingId { get; set; }
        public int Rating { get; set; }
    }
}
