using ReadLater5.Entity;
using System.Collections.Generic;

namespace ReadLater5.Models.Bookmark
{
    public class BookmarkViewModel
    {
        public string URL { get; set; }

        public string ShortDescription { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
