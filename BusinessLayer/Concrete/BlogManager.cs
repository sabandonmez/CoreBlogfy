using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IRepositoryManager repositoryManager;

        public BlogManager(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public void CreateBlog(Blog blog)
        {
           repositoryManager.Blog.Create(blog);
        }

        public void DeleteOneBlog(Blog blog)
        {
            repositoryManager.Blog.Remove(blog);
        }

		public List<Blog> GetListWithCategory()
		{
			return repositoryManager.Blog.GetListWithCategory();
		}

		public Blog GetOneBlog(int id)
        {
            return repositoryManager.Blog.GetOneBlog(id);
        }

        

        public List<Blog> ListAllBlog()
        {
            return repositoryManager.Blog.ListAllBlog();
        }

        public void UpdateOneBlog(Blog blog)
        {
            repositoryManager.Blog.Update(blog);
        }
    }
}
