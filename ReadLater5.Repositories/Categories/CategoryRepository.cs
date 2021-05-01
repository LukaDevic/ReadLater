using ReadLater5.Data;
using ReadLater5.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ReadLater5.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ReadLaterDataContext _readLaterDataContext;
        public CategoryRepository(ReadLaterDataContext readLaterDataContext) 
        {
            _readLaterDataContext = readLaterDataContext;            
        }

        public List<Category> GetCategories()
        {
            return _readLaterDataContext.Categories.ToList();
        }

        public Category GetCategory(int Id)
        {
            return _readLaterDataContext.Categories.Where(c => c.ID == Id).FirstOrDefault();
        }

        public Category GetCategory(string Name)
        {
            return _readLaterDataContext.Categories.Where(c => c.Name == Name).FirstOrDefault();
        }

        public Category CreateCategory(Category category)
        {
            _readLaterDataContext.Add(category);
            _readLaterDataContext.SaveChanges();
            return category;
        }

        public void UpdateCategory(Category category)
        {
            _readLaterDataContext.Update(category);
            _readLaterDataContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _readLaterDataContext.Categories.Remove(category);
            _readLaterDataContext.SaveChanges();
        }
    }
}
