using ReadLater5.Data;
using ReadLater5.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadLater5.Repositories.Bookmarks
{
    public class BookmarksRepository : IBookmarksRepository
    {
        private ReadLaterDataContext _readLaterDataContext;
        public BookmarksRepository(ReadLaterDataContext readLaterDataContext)
        {
            _readLaterDataContext = readLaterDataContext;
        }

        public IList<Bookmark> GetBookmarks()
        {
            return _readLaterDataContext.Bookmark.ToList();
        }

        public Bookmark GetBookmark(int id)
        {
            throw new NotImplementedException();
        }

        public Bookmark CrateBookmark(Bookmark bookmark)
        {
            throw new NotImplementedException();
        }

        public void UpdateBookmark(Bookmark bookmark)
        {
            throw new NotImplementedException();
        }

        public void DeleteBookmark(Bookmark bookmark)
        {
            throw new NotImplementedException();
        }
    }
}
