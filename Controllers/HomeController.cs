using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_11_AbeLamoreaux.Models;
using Mission_11_AbeLamoreaux.Models.ViewModels;

namespace Mission_11_AbeLamoreaux.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookRepository _repo;

        public HomeController(ILogger<HomeController> logger, IBookRepository temp)
        {
            _logger = logger;
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var Combo = new ProjectListViewModel
            {
                Books = _repo.Books.OrderBy(x => x.BookId)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()

                }

            };

            return View(Combo);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
