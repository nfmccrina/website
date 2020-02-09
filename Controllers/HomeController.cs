using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet()]
        public IActionResult Index()
        {
            return View(new LayoutModel("Nathan McCrina | Home"));
        }
    }
}