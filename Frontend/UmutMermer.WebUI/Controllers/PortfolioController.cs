using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using UmutMermer.WebUI.Models.AdminProduct;

namespace UmutMermer.WebUI.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PortfolioController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("/calismalarimiz")]
		public async Task< IActionResult> Portfolio()
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
