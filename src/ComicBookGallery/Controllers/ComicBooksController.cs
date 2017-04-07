using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);

        }
    }
}