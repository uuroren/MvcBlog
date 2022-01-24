using Microsoft.AspNetCore.Mvc;

namespace fullmvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
