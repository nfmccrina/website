using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class BeerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["IsAuthenticated"] = User.Identity.IsAuthenticated;
            ViewData["Title"] = "Nathan McCrina | Beer";
            return View();
        }
    }
}