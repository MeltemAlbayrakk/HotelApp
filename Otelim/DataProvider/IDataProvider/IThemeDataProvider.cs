using Otelim.Models;

namespace Otelim.DataProvider.IDataProvider
{
    public interface IThemeDataProvider
    {
        string Add(Theme theme); 
        string Delete(Theme theme);
    }
}
