using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
    public class CompanyInfoController : Controller
    {
        [Route("firmabilgileri")]
        public IActionResult CompanyInfoPage()
        {
            return View();
        }
    }
}
