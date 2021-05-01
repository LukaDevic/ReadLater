using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReadLater5.Entity;
using ReadLater5.Models.Bookmark;
using ReadLater5.Repositories.Categories;
using ReadLater5.Services.Bookmarks;
using System;
using System.Threading.Tasks;

namespace ReadLater5.Controllers
{
    public class BookmarksController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ICategoryRepository _categoryService;

        public BookmarksController(IMediator mediator, ICategoryRepository categoryService)
        {
            _mediator = mediator;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _mediator.Send(new GetAllBookmarks.Query());
            return View(result.Bookmarks);
        }

        public IActionResult Create()
        {
            var viewModel = new BookmarkViewModel
            {
                Categories = _categoryService.GetCategories()
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Crate(BookmarkViewModel viewModel)
        {
            var bookmark = new Bookmark
            {
                URL = viewModel.URL,
                ShortDescription = viewModel.ShortDescription,
                CategoryId = viewModel.CategoryId,
                CreateDate = DateTime.Now
            };
            await _mediator.Send(new CreateBookmark.Command(bookmark));

            return View("Index");
        }
    }
}
