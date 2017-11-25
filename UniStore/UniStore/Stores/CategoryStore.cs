using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniStore.Models.EntityModels;
using UniStore.Models.Repositories;

namespace UniStore.Stores
{
    public interface ICategoryStore
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Category CreateCategory(Category category);
        Category UpdateCategory(Category category);
        bool DeleteCategory(int id);
    }

    public class CategoryStore : ICategoryStore
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Category> categoryRepo;

        public CategoryStore(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            categoryRepo = unitOfWork.Get<Category>();
        }

        public Category CreateCategory(Category category)
        {
            categoryRepo.Create(category);
            unitOfWork.SaveChanges();

            return category;
        }

        public bool DeleteCategory(int id)
        {
            categoryRepo.Delete(id);
            return unitOfWork.SaveChanges() > 0;
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepo.GetAll(null);
        }

        public Category GetCategoryById(int id)
        {
            return categoryRepo.Get(id);
        }

        public Category UpdateCategory(Category category)
        {
            categoryRepo.Update(category);
            unitOfWork.SaveChanges();

            return category;
        }
    }
}