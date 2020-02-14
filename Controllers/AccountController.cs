using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["IsAuthenticated"] = User.Identity.IsAuthenticated;
            ViewData["Title"] = "Nathan McCrina | Login";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new UserRegistrationFormModel();
            ViewData["IsAuthenticated"] = User.Identity.IsAuthenticated;
            ViewData["Title"] = "Nathan McCrina | Register";

            return View(model);
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult SwitchToRegister()
        {
            return RedirectToAction("Register");
        }

        [HttpPost]
        public IActionResult SwitchToLogin()
        {
            return RedirectToAction("Login");
        }


        [HttpPost]
        public IActionResult Register([FromForm] UserRegistrationFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}