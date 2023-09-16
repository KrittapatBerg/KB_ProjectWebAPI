using System.ComponentModel.DataAnnotations;

namespace KB_WebAPI.Models
{
    public class csReview
    {
        [Key]       //EFC code first
        public Guid ReviewId {  get; set; }

        [MaxLength(200)]
        public string Review { get; set; } = string.Empty; 
    }
}
