using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
	public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
		private readonly DbSet<Blog> _dbSet;


		public BlogRepository(BlogfyContext context) : base(context)
        {
			_dbSet = context.Set<Blog>();
		}

        public void CreateBlog(Blog blog) => Create(blog);


        public void DeleteOneBlog(Blog blog) => Remove(blog);

		

		public Blog GetOneBlog(int id)
        {
            return FindByCondition(b => b.BlogId.Equals(id));
        }


		public List<Blog> ListAllBlog() => GetAll();


        public void UpdateOneBlog(Blog blog) => Update(blog);
		public IQueryable<Blog> GetByCategoryWithBlogs(params Expression<Func<Blog, object>>[] includes)
		{
			IQueryable<Blog> query = _dbSet;

			foreach (var includeExpression in includes)
			{
				query = query.Include(includeExpression);
			}

			return query;
		}

	}
}
