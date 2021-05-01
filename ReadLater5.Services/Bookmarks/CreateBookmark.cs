using MediatR;
using ReadLater5.Entity;
using ReadLater5.Repositories.Bookmarks;
using System.Threading;
using System.Threading.Tasks;

namespace ReadLater5.Services.Bookmarks
{
    public static class CreateBookmark
    {
        public class Handler : IRequestHandler<Command, Unit> 
        {
            private readonly IBookmarksRepository _bookmarksRepository;
            public Handler(IBookmarksRepository bookmarksRepository)
            {
                _bookmarksRepository = bookmarksRepository;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
               await _bookmarksRepository.CrateBookmarkAsync(request.Bookmark);
               return Unit.Value;
            }
        }

        public class Command : IRequest<Unit>
        {
            public Command(Bookmark bookmark)
            {
                Bookmark = bookmark;
            }

            public Bookmark Bookmark { get; }
        }
    }
}
