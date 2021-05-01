using ReadLater5.Entity;
using System.Collections.Generic;

namespace ReadLater5.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Category CreateCategory(Category category);
        List<Category> GetCategories();
        Category GetCategory(int Id);
        Category GetCategory(string Name);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
