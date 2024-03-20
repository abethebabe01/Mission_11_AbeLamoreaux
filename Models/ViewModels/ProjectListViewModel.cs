namespace Mission_11_AbeLamoreaux.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IQueryable<Book>? Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
