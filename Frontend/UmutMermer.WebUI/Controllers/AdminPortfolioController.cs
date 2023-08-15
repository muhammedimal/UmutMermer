using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UmutMermer.WebUI.Models.AdminProduct;

namespace UmutMermer.WebUI.Controllers
{
	public class AdminPortfolioController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminPortfolioController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ActionResult> AdminPortfolioPage()
		{
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("http://localhost:5254/api/Portfolio");
            if (responsMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminProductViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        
    }
}
