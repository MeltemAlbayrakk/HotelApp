using Otelim.Context;
using Otelim.Models;

namespace Otelim.DataProvider.EFDataProvider
{
    public class EFHotelDataProvider : IGenericDataProvider<Hotel>
    {
        public EFHotelDataProvider() 
        { 

        }
        public void Add(Hotel hotel)
        {
            using (var ctx=new HotelContext())
            {
                ctx.Hotels.Add(hotel);
                ctx.SaveChanges();
            }

        }

        public void Delete(Hotel hotel)
        {
            using (var ctx=new HotelContext())
            {
                ctx.Hotels.Remove(hotel);
                ctx.SaveChanges();

            }
        }

        public List<Hotel> GetList()
        {
            using (var ctx = new HotelContext())
            {
                var result = ctx.Hotels.ToList();
                return result;
            }
        }
    }
}
