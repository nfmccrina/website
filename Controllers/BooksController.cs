using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class BooksController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new LayoutModel("Nathan McCrina | Books"));
        }
    }
}