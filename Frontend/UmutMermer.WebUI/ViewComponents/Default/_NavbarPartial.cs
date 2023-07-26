using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke () 
        { 
            return View(); 
        }    
    }
}
