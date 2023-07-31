using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly BlogfyContext context;
        private readonly IBlogRepository blogRepository;
        private readonly ICategoryRepository categoryRepository;

        public RepositoryManager(BlogfyContext context, IBlogRepository blogRepository, ICategoryRepository categoryRepository)
        {
            this.context = context;
            this.blogRepository = blogRepository;
            this.categoryRepository = categoryRepository;
        }

        public IBlogRepository Blog => blogRepository;

        public ICategoryRepository Category => categoryRepository;

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
