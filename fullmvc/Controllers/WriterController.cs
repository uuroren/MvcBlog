using Microsoft.AspNetCore.Mvc;

namespace fullmvc.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
