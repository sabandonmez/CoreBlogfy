using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Extensions
{
	public static class BlogRepositoryExtension
	{
		public static List<Blog> GetBlogListWithCategory(this IQueryable<Blog> blog)
		{
			return blog.Include(b => b.Category).ToList();
		}
	}
}
