using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> ListAllBlog();
        Blog GetOneBlog(int id);
        void CreateBlog(Blog blog);
        void DeleteOneBlog(Blog blog);
        void UpdateOneBlog(Blog blog);

    }
}
