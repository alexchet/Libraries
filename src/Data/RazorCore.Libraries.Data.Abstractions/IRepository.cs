namespace RazorCore.Libraries.Data.Abstractions
{
    public interface IRepository<TEntity> : IRepositoryOfT<TEntity, long> where TEntity : class IEntity<long>
    {
    }
}
