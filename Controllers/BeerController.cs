using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class BeerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new LayoutModel("Nathan McCrina | Beer"));
        }
    }
}