namespace KB_WebAPI.Models
{
    public class csAddress
    {
        public Guid AddressId { get; set; }
        public string StreetName { get; set; } = string.Empty;
        public int Zipcode {  get; set; } 
    }
}
