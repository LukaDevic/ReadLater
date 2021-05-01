using ReadLater5.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReadLater5.Repositories.Bookmarks
{
    public interface IBookmarksRepository
    {
        Task<IList<Bookmark>> GetBookmarksAsync();
        Task<Bookmark> GetBookmarkAsync(int id);
        Task CrateBookmarkAsync(Bookmark bookmark);
        Task UpdateBookmarkAsync(Bookmark bookmark);
        Task DeleteBookmarkAsync(Bookmark bookmark);
    }
}
