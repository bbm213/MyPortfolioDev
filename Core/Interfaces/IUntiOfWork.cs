namespace Core.Interfaces //the interface contain just a concret operations
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenericRepository<T> Entity {get;}
        void Save();
    }
}
