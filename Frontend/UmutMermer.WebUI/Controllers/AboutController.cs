using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using UmutMermer.WebUI.Models.AdminProduct;
using UmutMermer.WebUI.Models.CompanyInfo;

namespace UmutMermer.WebUI.Controllers
{
	public class AboutController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("/hakkimizda")]
		public async Task<ActionResult> AboutPage(int id)
            
		{
            id = 3;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5254/api/CompanyInfo/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<CompanyInfoViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        

        }
    }

