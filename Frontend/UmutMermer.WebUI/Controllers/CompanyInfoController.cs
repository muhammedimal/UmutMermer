using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using UmutMermer.WebUI.Models.AdminProduct;
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

        public async Task<IActionResult> CompanyInfoPage()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:5254/api/CompanyInfo");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<UpdateCompanyInfo>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> UpdateCompanyInfo(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5254/api/CompanyInfo/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCompanyInfo>(jsonData);
                return View(values);
            }
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> UpdateCompanyInfo(UpdateCompanyInfo model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5254/api/CompanyInfo/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("CompanyInfoPage");
            }
            return View();
        }
    }
}
