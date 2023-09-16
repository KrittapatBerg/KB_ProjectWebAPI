using System.ComponentModel.DataAnnotations;

namespace KB_WebAPI.Models
{
    public class csRating
    {
        [Key]       //EFC code first
        public Guid RatingId { get; set; }

        [MaxLength(5)]
        public int Rating {  get; set; }

    }
}
