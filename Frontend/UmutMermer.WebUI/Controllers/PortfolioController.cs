﻿using Microsoft.AspNetCore.Mvc;

namespace UmutMermer.WebUI.Controllers
{
	public class PortfolioController : Controller
	{
		[Route("/urunler")]
		public IActionResult PortfolioPage()
		{
			return View();
		}
	}
}
