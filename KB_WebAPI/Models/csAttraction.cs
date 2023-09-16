namespace KB_WebAPI.Models
{
    public class csAttraction
    {
        public Guid AttractionId { get; set; }
        public string AttractionName { get; set; } = string.Empty;
        public enum Category { Park, Restaurant, Café, Museum, Architecture, Waterfall, Beach, Forest };
        public string Description { get; set; } = string.Empty;

    }
}
