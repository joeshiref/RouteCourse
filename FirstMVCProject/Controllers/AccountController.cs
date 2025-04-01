using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}