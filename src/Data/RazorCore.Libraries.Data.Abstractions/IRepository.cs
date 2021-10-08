namespace RazorCore.Libraries.Data.Abstractions
{
    public interface IRepository<TEntity> : IRepository<TEntity, long> where TEntity : class, IEntity
    {
    }
}
