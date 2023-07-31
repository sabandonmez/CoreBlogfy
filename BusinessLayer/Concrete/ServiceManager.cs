using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceManager
    {
       private readonly ICategoryService categoryService;
        private readonly IBlogService blogService; 
      

        public ServiceManager( IBlogService blogService, ICategoryService categoryService)
        {
           this.blogService = blogService;
           this.categoryService = categoryService;
        }
        public ICategoryService CategoryService => categoryService;

        public IBlogService BlogService => blogService;
    }
}
