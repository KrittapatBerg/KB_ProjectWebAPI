using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace KB_WebAPI.Models
{
    public class csAddress //: ISeed<csAddress>
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
        public Guid AttractionId { get; set; } //FK
        public csAttraction Attraction { get; set; }
        public bool Seeded { get; set; }
        public csAddress() { } 

        public csAddress Seed(SeedGenerator seedGen)
        {
            Seeded = true;
            AddressId = Guid.NewGuid();
            Country = seedGen.Country;
            City = seedGen.City;
            StreetName = seedGen.StreetName;
            Zipcode = seedGen.Zipcode; 
            
            return this;
        }
    }

    /*public interface ISeed<T>
    {
    }*/
}
