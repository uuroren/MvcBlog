using Microsoft.AspNetCore.Mvc;

namespace fullmvc.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
