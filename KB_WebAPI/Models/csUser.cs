using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB_WebAPI.Models
{
    public class csUser
    {
        [Key]       //EFC code first 
        public Guid UserId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = string.Empty;
        
        [EmailAddress]
        [MaxLength(100)]
        public string UserEmail { get; set; }

        public List<csReview> Reviews { get; set; } = null;    //one User has a list of reviews 
        public List<csRating> Ratings { get; set; } = null;       //one User has a list of ratings 
    }
}
