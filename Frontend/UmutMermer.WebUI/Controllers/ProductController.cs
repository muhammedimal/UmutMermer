using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class ProductController : Controller
    {
        [Route("urunler")]
        public IActionResult AdminProductPage()
        {
            return View();
        }
    }
}
