using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["IsAuthenticated"] = User.Identity.IsAuthenticated;
            ViewData["Title"] = "Nathan McCrina | Admin";
            return View();
        }
    }
}