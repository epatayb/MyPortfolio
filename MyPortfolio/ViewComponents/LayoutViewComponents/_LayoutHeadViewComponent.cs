using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
