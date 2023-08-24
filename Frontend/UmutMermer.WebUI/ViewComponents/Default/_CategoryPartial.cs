using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UmutMermer.DtoLAyer.Dtos.CategoryDto;
using UmutMermer.WebUI.Dtos.PortfolioDto;
using UmutMermer.WebUI.Models.CategoryDto;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _CategoryPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CategoryPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:5254/api/Category");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
