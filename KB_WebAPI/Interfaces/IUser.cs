using KB_WebAPI.Models;

namespace KB_WebAPI.Interfaces
{
    public interface IUser
    {
        List<csUser> GetUsers();
        csUser GetUserById(Guid id);
        bool UserExists(Guid userId);
    }
}
