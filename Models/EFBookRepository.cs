namespace Mission_11_AbeLamoreaux.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext context;

        public EFBookRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}

