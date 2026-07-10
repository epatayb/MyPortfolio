using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
