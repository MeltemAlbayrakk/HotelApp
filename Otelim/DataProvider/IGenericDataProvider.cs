namespace Otelim.DataProvider
{
    public interface IGenericDataProvider<T> where T : class
    {
        public void Add(T t);
        List<T> GetList();
        public void Delete(T t);
    }
}
