using ReadLater5.Data;
using ReadLater5.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ReadLater5.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ReadLaterDataContext _ReadLaterDataContext;
        public CategoryRepository(ReadLaterDataContext readLaterDataContext) 
        {
            _ReadLaterDataContext = readLaterDataContext;            
        }

        public Category CreateCategory(Category category)
        {
            _ReadLaterDataContext.Add(category);
            _ReadLaterDataContext.SaveChanges();
            return category;
        }

        public void UpdateCategory(Category category)
        {
            _ReadLaterDataContext.Update(category);
            _ReadLaterDataContext.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _ReadLaterDataContext.Categories.ToList();
        }

        public Category GetCategory(int Id)
        {
            return _ReadLaterDataContext.Categories.Where(c => c.ID == Id).FirstOrDefault();
        }

        public Category GetCategory(string Name)
        {
            return _ReadLaterDataContext.Categories.Where(c => c.Name == Name).FirstOrDefault();
        }

        public void DeleteCategory(Category category)
        {
            _ReadLaterDataContext.Categories.Remove(category);
            _ReadLaterDataContext.SaveChanges();
        }
    }
}
