using EntityLayer.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogRepository:IRepositoryBase<Blog>
    {
        List<Blog> ListAllBlog();
        Blog GetOneBlog(int id);
        void CreateBlog(Blog blog);
        void DeleteOneBlog(Blog blog);
        void UpdateOneBlog(Blog blog);      
        List<Blog> GetListWithCategory();


	}
}
