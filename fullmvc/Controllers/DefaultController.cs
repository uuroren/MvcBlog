using Microsoft.AspNetCore.Mvc;

namespace fullmvc.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
