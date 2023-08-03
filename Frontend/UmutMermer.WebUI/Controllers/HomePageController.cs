using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using UmutMermer.WebUI.Models.AdminProduct;

namespace UmutMermer.WebUI.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomePageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("")]
        public async Task<ActionResult> Index()
        {
            return View();
        }
        public async Task<PartialViewResult>  HomePortfolio()
        {
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("http://localhost:5254/api/Products");
            if (responsMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminProductViewModel>>(jsonData);
                return PartialView(values);
            }


            return PartialView();

        }
        public async Task<PartialViewResult>  HomeCompletedWorks()
        {
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("http://localhost:5254/api/Portfolio");
            if (responsMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminProductViewModel>>(jsonData);
                return PartialView(values);
            }
            return PartialView();

        }
    }
}


