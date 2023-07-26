using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
