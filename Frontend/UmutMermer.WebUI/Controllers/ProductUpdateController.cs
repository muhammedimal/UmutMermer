using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class ProductUpdateController : Controller
    {
        [Route("urunguncelle")]
        public IActionResult ProductUpdatePage()
        {
            return View();
        }
    }
}
