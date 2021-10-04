namespace RazorCore.Libraries.Data.Abstractions
{
    public interface IRepositoryOfT<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey> { }
}
