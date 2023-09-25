using System.ComponentModel.DataAnnotations;

namespace KB_WebAPI.DTO
{
    public class AttractionDto
    {
        public Guid AttractionId { get; set; }
        public string AttractionName { get; set; } = string.Empty;
        public string Category { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
