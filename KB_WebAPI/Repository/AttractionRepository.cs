using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace KB_WebAPI.Repository
{ 
    public class AttractionRepository : IAttraction
    {
        private readonly DataContext _context;
        public AttractionRepository(DataContext context) 
        { 
            _context = context; 
        }
        public List<csAttraction> GetAttractions()
        {
            return _context.Attractions.OrderBy(a => a.AttractionId).ToList();
        }
        public csAttraction GetAttractionById(Guid id)
        {
            return _context.Attractions.Where(a => a.AttractionId == id).FirstOrDefault();
        }

        public csAttraction GetAttraction(string name)
        {
            return _context.Attractions.Where(a => a.AttractionName == name).FirstOrDefault();
        }

        public csAttraction GetAttractionByCategory(string category)
        {
            return _context.Attractions.Where(a => a.Category == category).FirstOrDefault(); 
        }
        public decimal GetAttractionRating(Guid ratingId)
        {
            var rating = _context.Ratings.Where(a => a.RatingId == ratingId);

            if (rating.Count() <= 0) return 0;
            return ((decimal)rating.Sum(r => r.Rating));
        }
        public bool AttractionExists(Guid attractionid)
        {
            return _context.Attractions.Any(a => a.AttractionId == attractionid);
        }

       //public List<csAttraction> GetAttractionReview(Guid id) => _context.Reviews.Where(r => r.ReviewId == id).ToList();
    }
}
