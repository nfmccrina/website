using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignOut([FromQuery] string page)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}