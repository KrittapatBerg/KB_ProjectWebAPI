using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;

namespace KB_WebAPI.Repository
{
    public class RatingRepository : IRating
    {
        private readonly DataContext _context;
        public RatingRepository(DataContext context)
        {
            _context = context;
        }
        public List<csRating> GetRatings()
        {
            return _context.Ratings.OrderBy(r => r.RatingId).ToList();
        }
        public csRating GetRatingById(Guid id)
        {
            return _context.Ratings.Where(r => r.RatingId == id).FirstOrDefault();
        }
        public csRating GetRatingByAttraction(string attraction)
        {
            return _context.Ratings.Where(a => a.Attraction.AttractionName == attraction).FirstOrDefault();
        }
        public csRating GetRatingByUser(Guid userId)
        {
            return _context.Ratings.Where(u => u.User.UserId == userId).FirstOrDefault();
        }

        public bool RatingExists(Guid id)
        {
            return _context.Ratings.Any(r => r.RatingId == id); 
        }
    }
}
