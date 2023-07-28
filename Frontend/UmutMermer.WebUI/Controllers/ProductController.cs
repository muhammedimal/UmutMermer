using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using UmutMermer.WebUI.Models.AdminProduct;
using UmutMermer.WebUI.Models.CompanyInfo;

namespace UmutMermer.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<ActionResult> AdminProductPage()
        {
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("http://localhost:5254/api/Products");
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
