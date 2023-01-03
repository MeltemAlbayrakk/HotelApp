using Otelim.Context;
using Otelim.Models;

namespace Otelim.DataProvider.EFDataProvider
{
    public class EFUserDataProvider : IGenericDataProvider<User>
    {
        public void Add(User user)
        {
            using (var ctx = new HotelContext())
            {
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (var ctx= new HotelContext())
            {
                ctx.Users.Remove(user);
                ctx.SaveChanges();
            }
                
        }

        public List<User> GetList()
        {
            using (var ctx = new HotelContext())
            {
                var result = ctx.Users.ToList();
                return result;

            } 
                
        }
    }
}
