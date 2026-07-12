using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;

        public _LayoutNavbarViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
