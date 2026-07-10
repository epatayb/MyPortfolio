using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _FeatureViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var features = _context.Features.ToList();
            return View(features);
        }
    }
}
