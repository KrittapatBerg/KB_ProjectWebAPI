using KB_WebAPI.Models;

namespace KB_WebAPI.Interfaces
{
    public interface IAttraction
    {
        List<csAttraction> getAttractions(); 
        csAttraction getAttractionById(Guid id);
        csAttraction getAttraction(string name);
        csAttraction GetAttractionByCategory (string category);
        decimal getAttractionRating(Guid ratingId);
        bool attractionExists(Guid attractionid);

    }
}
