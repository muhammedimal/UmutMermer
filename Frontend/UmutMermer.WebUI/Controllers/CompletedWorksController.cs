using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class CompletedWorksController : Controller
    {
		[Route("/calismalarimiz")]
		public IActionResult CompletedWorks()
        {
            return View();
        }
    }
}
