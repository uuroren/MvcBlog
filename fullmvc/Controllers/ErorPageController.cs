using Microsoft.AspNetCore.Mvc;

namespace fullmvc.Controllers
{
    public class ErorPageController : Controller
    {
        public IActionResult Eror1(int code)
        {
            return View();
        }
    }
}
