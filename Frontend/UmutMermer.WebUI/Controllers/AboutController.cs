using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
	public class AboutController : Controller
	{
		[Route("/hakkimizda")]
		public IActionResult AboutPage()
		{
			return View();
		}
	}
}
