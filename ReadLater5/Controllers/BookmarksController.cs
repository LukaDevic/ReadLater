using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ReadLater5.Controllers
{
    public class BookmarksController : Controller
    {
        private readonly IMediator _mediator;

        public BookmarksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
