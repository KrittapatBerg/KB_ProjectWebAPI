using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB_WebAPI.Models
{
    public class csAttraction : ISeed<csAttraction>
    {
        [Key]       //EFC code first 
        public Guid AttractionId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string AttractionName { get; set; } = string.Empty;
        //public enum Category { Park, Restaurant, Café, Museum, Architecture, Waterfall, Beach, Forest };
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;
        
        public csAddress Address { get; set; } = null;         //One Attraction has one Address 
        public bool Seeded { get; set; }
        public csAttraction() { } 
        public csAttraction Seed(SeedGenerator seedGen)
        {
            Seeded = true;
            AttractionId = Guid.NewGuid();
            AttractionName = seedGen.Attraction;
            Description = seedGen.Description;
            return this;
        }
        public List<csReview> Review { get; set; } = null;     //One Attraction has a list of Review 0-20 reviews
        public List<csRating> Rating { get; set; } = null;     //One Attraction has a list of Rating 0-20 ratings
        
    }
}
