using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _SkillViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var skills = _context.Skills.ToList();
            return View(skills);
        }    
    }
}
