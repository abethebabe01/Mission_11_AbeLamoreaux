namespace Mission_11_AbeLamoreaux.Models
{
    public interface IBookRepository
    {
        IQueryable<Book>? Books { get; }
    }
}
