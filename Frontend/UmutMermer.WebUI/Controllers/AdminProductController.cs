using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.WebUI.Dtos.CompanyInfoDto;
using UmutMermer.WebUI.Dtos.ProductsDto;
using UmutMermer.WebUI.Models.AdminProduct;
using UmutMermer.WebUI.Models.CompanyInfo;


namespace UmutMermer.WebUI.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Context _context;
        public AdminProductController(IHttpClientFactory httpClientFactory, Context context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }


        public async Task<ActionResult> AdminProductPage()
        {
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("http://localhost:5254/api/Products");
            if (responsMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProductGetDto>>(jsonData);
                return View(values);
            }


            return View();

        }




        public async Task<IActionResult> DeleteProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5254/api/Products/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminProductPage");
            }
            return View();


        }




        [HttpGet]
        public IActionResult AddProduct()
        {

            List<SelectListItem> values = (from x in _context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }
                                           ).ToList();


            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(AdminProductAdd model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("http://localhost:5254/api/Products", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("AdminProductPage");
                }
                return View();
            }
            else
            {
                return View();
            }
        }



       


        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5254/api/Products/{id}");
            List<SelectListItem> value = (from x in _context.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.Id.ToString()
                                          }
                               ).ToList();
            ViewBag.v1 = value;
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ProductUpdateDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5254/api/Products/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("AdminProductPage");
            }
            return View();
        }


    }
}
