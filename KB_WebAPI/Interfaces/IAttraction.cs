using KB_WebAPI.Models;

namespace KB_WebAPI.Interfaces
{
    public interface IAttraction
    {
        List<csAttraction> GetAttractions(); 
        csAttraction GetAttractionById(Guid id);
        csAttraction GetAttraction(string name);
        csAttraction GetAttractionByCategory (string category);
        decimal GetAttractionRating(Guid ratingId);
        bool AttractionExists(Guid attractionid);
        //List<csAttraction> GetAttractionReview(Guid id);
        //get a list of Reviews of one Attraction 

    }
}
