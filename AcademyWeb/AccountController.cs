using Microsoft.AspNetCore.Mvc;

namespace AcademyWeb
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View("Logon");
        }

        public IActionResult SubmitLogon()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
