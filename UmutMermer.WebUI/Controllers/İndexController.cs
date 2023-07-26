using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class İndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
