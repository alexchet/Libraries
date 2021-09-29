namespace RazorCore.Libraries.Data.Abstractions
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
