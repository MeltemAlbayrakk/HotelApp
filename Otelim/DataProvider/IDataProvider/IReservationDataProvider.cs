using Otelim.Models;

namespace Otelim.DataProvider.IDataProvider
{
    public interface IReservationDataProvider
    {
        string Add(Reservation reservation);
        List<Reservation> GetAll();
        string Update(Reservation reservation);
        string Delete(Reservation reservation);
    }
}
