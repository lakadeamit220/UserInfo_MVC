using Microsoft.AspNetCore.Mvc;
using UserInformation.Models;

namespace UserInformation.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                // Save user data and redirect to a success page.
                return RedirectToAction("Success");
            }

            return View(user);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
