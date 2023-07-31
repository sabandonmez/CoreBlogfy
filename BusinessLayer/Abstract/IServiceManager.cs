using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IBlogService BlogService { get; }
    }
}
