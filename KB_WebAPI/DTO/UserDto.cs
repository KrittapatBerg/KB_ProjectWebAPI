using System.ComponentModel.DataAnnotations;

namespace KB_WebAPI.DTO
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; }
    }
}
