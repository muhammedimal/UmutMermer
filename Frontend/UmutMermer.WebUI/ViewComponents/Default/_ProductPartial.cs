using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.WebUI.Dtos.PortfolioDto;
using UmutMermer.WebUI.Dtos.ProductsDto;
using UmutMermer.WebUI.Models.ProductImage;
using UmutMermer.WebUI.Models.ProductVM;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    [AllowAnonymous]
    public class _ProductPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
          
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync($"http://localhost:5254/api/Category/product{categoryId}");
            var responserMessage2 = await client.GetAsync($"http://localhost:5254/api/ProductImage");
            if (responserMessage.IsSuccessStatusCode && responserMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var productValues = JsonConvert.DeserializeObject<List<ResultProductVM>>(jsonData);
                var imageJsonData = await responserMessage2.Content.ReadAsStringAsync();
                var imageValues = JsonConvert.DeserializeObject<List<ResultProductImageDto>>(imageJsonData);
                foreach (var product in productValues)
                {
                    product.ProductImage = imageValues
                        .Where(img => img.ProductId == product.ProductId)
                        .ToList();
                }
                return View(productValues);
            }
            return View();
        }
    }
}

