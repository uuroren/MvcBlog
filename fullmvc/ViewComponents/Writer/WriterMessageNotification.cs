using Microsoft.AspNetCore.Mvc;

namespace fullmvc.ViewComponents.Writer
{
    public class WriterMessageNotification :ViewComponent
    {
            public IViewComponentResult Invoke ()
            {
                return View();
            }
    }
}
