using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _AboutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
