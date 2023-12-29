using Microsoft.AspNetCore.Mvc;

namespace Masters2.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
