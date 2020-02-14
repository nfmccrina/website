using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class BooksController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["IsAuthenticated"] = User.Identity.IsAuthenticated;
            ViewData["Title"] = "Nathan McCrina | Books";
            return View();
        }
    }
}