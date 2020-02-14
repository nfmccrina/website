using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class SoftwareController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["IsAuthenticated"] = User.Identity.IsAuthenticated;
            ViewData["Title"] = "Nathan McCrina | Software";
            return View();
        }
    }
}