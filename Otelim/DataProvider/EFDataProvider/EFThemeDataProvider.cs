using Otelim.Context;
using Otelim.Models;
using System.Text.RegularExpressions;

namespace Otelim.DataProvider.EFDataProvider
{
    public class EFThemeDataProvider : IGenericDataProvider<Theme>
    {
        public void Add(Theme theme)
        {
            using (var ctx = new HotelContext())
            {
                ctx.Themes.Add(theme);
                ctx.SaveChanges();
            }
        }

        public void Delete(Theme theme)
        {
            using (var ctx = new HotelContext())
            {
                ctx.Themes.Remove(theme);
                ctx.SaveChanges();
            }
        }

        public List<Theme> GetList()
        {
            using (var ctx = new HotelContext())
            {
                var result= ctx.Themes.ToList();
                return result;
            }
        }
    }
}
