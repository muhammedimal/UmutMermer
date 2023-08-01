using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
	public class PortfolioController : Controller
	{
		public IActionResult PortfolioPage()
		{
			return View();
		}
	}
}
