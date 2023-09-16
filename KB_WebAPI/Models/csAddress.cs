using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB_WebAPI.Models
{
    public class csAddress
    {
        [Key]       //EFC Code first
        public Guid AddressId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string StreetName { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public int Zipcode { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Country { get; set; } = string.Empty; 
        public Guid AttractionId { get; set; }
        public csAttraction Attraction { get; set; }
    }
}
