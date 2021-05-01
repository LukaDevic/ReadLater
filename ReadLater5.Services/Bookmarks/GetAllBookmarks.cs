using MediatR;
using ReadLater5.Entity;
using ReadLater5.Repositories.Bookmarks;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ReadLater5.Services.Bookmarks
{
    public static class GetAllBookmarks
    {
        public class Handler : IRequestHandler<Query, Result>
        {
            private readonly IBookmarksRepository _bookmarksRepository;
            public Handler(IBookmarksRepository bookmarksRepository)
            {
                _bookmarksRepository = bookmarksRepository;
            }

            public async Task<Result> Handle(Query request, CancellationToken cancellationToken)
            {
                var bookmarks = await _bookmarksRepository.GetBookmarksAsync();
                return new Result(bookmarks);
            }
        }

        public class Query : IRequest<Result> { }

        public class Result
        {
            public Result(IList<Bookmark> bookmark)
            {
                Bookmarks = bookmark;
            }

            public IList<Bookmark> Bookmarks { get; }
        }
    }
}
