using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.WebUI.Dtos.ProductsDto;
using UmutMermer.WebUI.Models.AdminProduct;
using UmutMermer.WebUI.Models.CompanyInfo;
using ProductGetDto = UmutMermer.WebUI.Dtos.ProductsDto.ProductGetDto;

namespace UmutMermer.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ProductController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		[Route("/urunler")]
		public async Task<IActionResult> ProductsPage()
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
		public async Task<IActionResult> ProductPage(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:5254/api/Products/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateCompanyInfo>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
