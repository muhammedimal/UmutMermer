using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
 

        public IActionResult GetContentDetail([FromQuery] int categoryId)
        {
            return ViewComponent("_ProductPartial", new
            {
                categoryId = categoryId
            });
        }
    }
}
