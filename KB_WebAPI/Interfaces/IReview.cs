using KB_WebAPI.Models;

namespace KB_WebAPI.Interfaces
{
    public interface IReview
    {
        List<csReview> GetReviews();
        csReview GetReview(Guid id);
        csReview GetReviewByUser(Guid userid);
        csReview GetReviewByAttraction(Guid attractionid);
        bool ReviewExists(Guid id);
    }
}
