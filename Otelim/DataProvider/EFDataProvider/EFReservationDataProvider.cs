using Otelim.Context;
using Otelim.Models;
using System.Text.RegularExpressions;

namespace Otelim.DataProvider.EFDataProvider
{
    public class EFReservationDataProvider : IGenericDataProvider<Reservation>
    {
        public void Add(Reservation reservation)
        {
            using (var ctx = new HotelContext())
            {
                ctx.Reservations.Add(reservation);
                ctx.SaveChanges();
            }
        }

        public void Delete(Reservation reservation)
        {
            using (var ctx = new HotelContext())
            {
                ctx.Reservations.Remove(reservation);
                ctx.SaveChanges();
            }
        }

        public List<Reservation> GetList()
        {
            using (var ctx = new HotelContext())
            {
               var result = ctx.Reservations.ToList();
                return result;
            }
        }
    }
}
