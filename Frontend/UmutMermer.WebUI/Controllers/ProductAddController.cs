using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class ProductAddController : Controller
    {
        [Route("urunekle")]
        public IActionResult ProductAddPage()
        {
            return View();
        }
    }
}
