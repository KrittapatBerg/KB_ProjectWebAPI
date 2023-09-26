using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;

namespace KB_WebAPI.Repository
{
    public class ReviewRepository : IReview
    {
        private readonly DataContext _context;
        public ReviewRepository(DataContext context)
        {
            _context = context;
        }
        public List<csReview> GetReviews()
        {
            return _context.Reviews.OrderBy(r => r.ReviewId).ToList();
        }

        public csReview GetReview(Guid id)
        {
            return _context.Reviews.Where(r => r.ReviewId == id).FirstOrDefault();
        }

        public csReview GetReviewByAttraction(Guid attractionid)
        {
            return _context.Reviews.Where(r => r.Attraction.AttractionId == attractionid).FirstOrDefault();
        }

        public csReview GetReviewByUser(Guid id)
        {
            return _context.Reviews.Where(r => r.User.UserId == id).FirstOrDefault();
        }

        public bool ReviewExists(Guid id)
        {
            return _context.Reviews.Any(r => r.ReviewId == id);
        }
    }
}
