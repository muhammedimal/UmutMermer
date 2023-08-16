using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.WebUI.Dtos.PortfolioDto;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _ProductPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:5254/api/Products");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProductGetDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

