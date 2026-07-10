using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _SkillViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }    
    }
}
