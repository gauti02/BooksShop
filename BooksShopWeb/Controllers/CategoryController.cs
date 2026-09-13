using BooksShopWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BooksShopWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View("Index", categories);
        }
    }
}
