using Microsoft.EntityFrameworkCore;
using ReadLater5.Data;
using ReadLater5.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReadLater5.Repositories.Bookmarks
{
    public class BookmarksRepository : IBookmarksRepository
    {
        private ReadLaterDataContext _readLaterDataContext;
        public BookmarksRepository(ReadLaterDataContext readLaterDataContext)
        {
            _readLaterDataContext = readLaterDataContext;
        }

        public async Task<IList<Bookmark>> GetBookmarksAsync()
        {
            var bookmarks = await _readLaterDataContext.Bookmark.ToListAsync();
            return bookmarks;
        }
        public Task<Bookmark> GetBookmarkAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CrateBookmarkAsync(Bookmark bookmark)
        {
            await _readLaterDataContext.AddAsync(bookmark);
            await _readLaterDataContext.SaveChangesAsync();
        }
        public Task UpdateBookmarkAsync(Bookmark bookmark)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookmarkAsync(Bookmark bookmark)
        {
            throw new NotImplementedException();
        }
    }
}
