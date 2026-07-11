using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        
        public _ExperienceViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var experiences = _context.Experiences.OrderByDescending(e => e.StartDate).ToList();
            return View(experiences);
        }
    }
}
