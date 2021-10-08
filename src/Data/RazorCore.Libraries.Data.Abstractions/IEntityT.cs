namespace RazorCore.Libraries.Data.Abstractions
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
