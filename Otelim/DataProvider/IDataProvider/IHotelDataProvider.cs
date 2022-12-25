using Otelim.Models;

namespace Otelim.DataProvider.IDataProvider
{
    public interface IHotelDataProvider 
    {
        string Add(Hotel hotel);
        List<Hotel> GetAll();
        string Update(Hotel hotel);
        string Delete(Hotel hotel);
    }
}
