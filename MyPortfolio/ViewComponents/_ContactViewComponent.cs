using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }    
    }
}
