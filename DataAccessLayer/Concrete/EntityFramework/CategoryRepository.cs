using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogfyContext context) : base(context)
        {
        }

        public void CreateCategory(Category category) => Create(category);


        public void DeleteOneCategory(Category category) => Remove(category);


        public Category GetOneCategory(int id)
        {
            return FindByCondition(c => c.CategoryId.Equals(id));
        }

        public List<Category> ListCategories() => GetAll();


        public void UpdateOneCategory(Category category) => Update(category);

    }
}
