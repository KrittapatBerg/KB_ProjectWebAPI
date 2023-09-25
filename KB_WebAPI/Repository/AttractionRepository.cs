using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;

namespace KB_WebAPI.Repository
{
    public class AttractionRepository : IAttraction
    {
        private readonly DataContext _context;
        public AttractionRepository(DataContext context) 
        { 
            _context = context; 
        }

        public List<csAttraction> getAttractions()
        {
            return _context.Attractions.OrderBy(a => a.AttractionId).ToList();
        }
    }
}
