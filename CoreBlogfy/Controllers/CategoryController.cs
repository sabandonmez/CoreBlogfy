using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogfy.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IServiceManager serviceManager;

        public CategoryController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var values = serviceManager.CategoryService.ListCategories();
            return View(values);
        }
    }
}
