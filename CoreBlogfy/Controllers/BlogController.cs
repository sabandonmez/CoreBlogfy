using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogfy.Controllers
{
    public class BlogController:Controller
    {
        private readonly IServiceManager serviceManager;
		public BlogController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		public IActionResult Index()
        {
			var blogs = serviceManager.BlogService.GetListWithCategory();
			
			return View(blogs);
        }

		public IActionResult BlogDetails(int id)
		{
			return View();
		}
    }
}
