using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using UmutMermer.WebUI.Models.CompanyInfo;

namespace UmutMermer.WebUI.Controllers
{
    public class CompanyInfoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CompanyInfoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

       


        [Route("firmabilgileri")]
        public async Task<IActionResult> CompanyInfoPage()
        {
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("http://localhost:5254/api/CompanyInfo");
            if (responsMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CompanyInfoViewModel>>(jsonData);
                return View(values);
            }

            
            return View();
        }
    }
}
