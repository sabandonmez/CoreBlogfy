using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager repositoryManager;

        public CategoryManager(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }
        public void CreateCategory(Category category)
        {
            repositoryManager.Category.Create(category);
        }

        public void DeleteOneCategory(Category category)
        {
            repositoryManager.Category.Remove(category);
        }

        public Category GetOneCategory(int id)
        {
           return repositoryManager.Category.GetOneCategory(id);
        }

        public List<Category> ListCategories()
        {
          return repositoryManager.Category.ListCategories();
        }

        public void UpdateOneCategory(Category category)
        {
            repositoryManager.Category.Update(category);
        }
    }
}
