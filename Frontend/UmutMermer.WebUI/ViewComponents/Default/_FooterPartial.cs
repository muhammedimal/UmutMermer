﻿using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _FooterPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
