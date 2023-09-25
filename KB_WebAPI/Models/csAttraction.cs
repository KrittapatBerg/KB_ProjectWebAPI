using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace KB_WebAPI.Models
{
    public class csAttraction //: IAttraction
    {
        //public enum Category { Park, Restaurant, Café, Museum, Architecture, Waterfall, Beach, Forest, Hotel };
        [Key]       //EFC code first 
        public Guid AttractionId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string AttractionName { get; set; } = string.Empty;
        public string Category { get; set; }
        /*public Category AttractionCategory { get; set; }
        public string strCategory
        {
            get => AttractionCategory.ToString();
            set { }
        }*/ 

        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;
        
        public Guid? AddressId { get; set; }
        public csAddress Address { get; set; } = null;         //One Attraction has one Address 


        //public bool Seeded { get; set; }
        //public csAttraction() { } 
        /*public csAttraction Seed(SeedGenerator seedGen)
        {
            Seeded = true;
            AttractionId = Guid.NewGuid();
            AttractionName = seedGen.Attraction;
            //AttractionCategory = 
            Description = seedGen.Description;
            return this;
        }*/

        public List<csReview> Review { get; set; } = null;     //One Attraction has a list of Review 0-20 reviews
        public List<csRating> Rating { get; set; } = null;     //One Attraction has a list of Rating 0-20 ratings
        
    }
}
