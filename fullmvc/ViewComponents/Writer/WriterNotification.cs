using Microsoft.AspNetCore.Mvc;

namespace fullmvc.ViewComponents.Writer
{
    public class WriterNotification :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
