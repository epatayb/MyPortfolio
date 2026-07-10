using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
