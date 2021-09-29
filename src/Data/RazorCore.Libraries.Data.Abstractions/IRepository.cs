namespace RazorCore.Libraries.Data.Abstractions
{
    public interface IRepository<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey> { }

}
