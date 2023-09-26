using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;

namespace KB_WebAPI.Repository
{
    public class UserRepository : IUser
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context; 
        }
        public List<csUser> GetUsers()
        {
            return _context.Users.OrderBy(u => u.UserId).ToList();
        }
        public csUser GetUserById(Guid id)
        {
            return _context.Users.Where(u => u.UserId == id).FirstOrDefault();
        }

        public bool UserExists(Guid userId)
        {
            return _context.Users.Any(u => u.UserId == userId);
        }
    }
}
