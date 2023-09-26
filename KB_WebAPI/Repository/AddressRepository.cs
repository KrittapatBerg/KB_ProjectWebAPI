using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;

namespace KB_WebAPI.Repository
{
    public class AddressRepository : IAddress
    {
        private readonly DataContext _context;
        public AddressRepository(DataContext context)
        {
            _context = context;
        }
        public bool AddressExists(Guid id)
        {
            return _context.Addresses.Any(a => a.AddressId == id); 
        }

        public csAddress GetAddress(Guid id)
        {
            return _context.Addresses.Where(a => a.AddressId == id).FirstOrDefault();
            
        }

        public List<csAddress> GetAddresses()
        {
            return _context.Addresses.OrderBy(a => a.AddressId).ToList();

        }
    }
}
