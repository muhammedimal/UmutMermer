using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _BannerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
