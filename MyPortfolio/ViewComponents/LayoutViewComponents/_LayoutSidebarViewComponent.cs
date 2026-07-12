using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
