using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryManager
    {
        IBlogRepository Blog { get; }
        ICategoryRepository Category { get; }
        void Save();


    }
}
