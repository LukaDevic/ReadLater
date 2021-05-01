using ReadLater5.Entity;
using System.Collections.Generic;

namespace ReadLater5.Repositories.Bookmarks
{
    public interface IBookmarksRepository
    {
        IList<Bookmark> GetBookmarks();
        Bookmark GetBookmark(int id);
        Bookmark CrateBookmark(Bookmark bookmark);
        void UpdateBookmark(Bookmark bookmark);
        void DeleteBookmark(Bookmark bookmark);
    }
}
