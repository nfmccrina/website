using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View(new LayoutModel("Nathan McCrina | Admin"));
        }
    }
}