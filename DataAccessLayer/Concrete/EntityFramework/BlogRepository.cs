using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(BlogfyContext context) : base(context)
        {
        }

        public void CreateBlog(Blog blog) => Create(blog);


        public void DeleteOneBlog(Blog blog) => Remove(blog);


        public Blog GetOneBlog(int id)
        {
            return FindByCondition(b => b.BlogId.Equals(id));
        }

        public List<Blog> ListAllBlog() => GetAll();


        public void UpdateOneBlog(Blog blog) => Update(blog);

    }
}
