using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB_WebAPI.Models
{
    public class csAttraction
    {
        [Key]       //EFC code first 
        public Guid AttractionId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string AttractionName { get; set; } = string.Empty;
        public enum Category { Park, Restaurant, Café, Museum, Architecture, Waterfall, Beach, Forest };
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;
        
        public csAddress Address { get; set; } = null;         //One Attraction has one Address 
        public List<csReview> Review { get; set; } = null;     //One Attraction has a list of Review 0-20 reviews
        public List<csRating> Rating { get; set; } = null;     //One Attraction has a list of Rating 0-20 ratings
        
    }
}
