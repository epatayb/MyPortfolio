using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
