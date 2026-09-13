using BooksShopWeb.Data;
using BooksShopWeb.Models;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]              
        public IActionResult CreatePOST(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
