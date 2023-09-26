using KB_WebAPI.Models;

namespace KB_WebAPI.Interfaces
{
    public interface IAddress
    {
        List<csAddress> GetAddresses();
        csAddress GetAddress(Guid id);
        bool AddressExists(Guid id);
    }
}
