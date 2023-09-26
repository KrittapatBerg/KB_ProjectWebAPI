using System.ComponentModel.DataAnnotations;

namespace KB_WebAPI.DTO
{
    public class ReviewDto
    {
        public Guid ReviewId { get; set; }
        public string Review { get; set; } = string.Empty;
    }
}
