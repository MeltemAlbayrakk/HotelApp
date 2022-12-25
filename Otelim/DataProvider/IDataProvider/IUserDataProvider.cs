using Otelim.Models;

namespace Otelim.DataProvider.IDataProvider
{
    public interface IUserDataProvider
    {
        string Add(User user);
        List<User> GetAll();
        string Update(User user);
        string Delete(User user);   
    }
}
