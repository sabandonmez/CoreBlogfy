using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryRepository: IRepositoryBase<Category>
    {
        List<Category> ListCategories();
        Category GetOneCategory(int id);
        void CreateCategory(Category category);
        void DeleteOneCategory(Category category);
        void UpdateOneCategory(Category category);

    }
}
