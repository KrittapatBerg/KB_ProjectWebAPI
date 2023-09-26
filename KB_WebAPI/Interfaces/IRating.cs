using KB_WebAPI.Models;

namespace KB_WebAPI.Interfaces
{
    public interface IRating
    {
        List<csRating> GetRatings(); 
        csRating GetRatingById(Guid id);
        csRating GetRatingByUser(Guid userId);
        csRating GetRatingByAttraction(string attraction);
        bool RatingExists(Guid id);


    }
}
