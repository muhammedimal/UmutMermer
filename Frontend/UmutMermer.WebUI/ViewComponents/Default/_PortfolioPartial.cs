using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UmutMermer.WebUI.Dtos.PortfolioDto;

namespace UmutMermer.WebUI.ViewComponents.Default
{
    public class _PortfolioPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PortfolioPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:5254/api/Portfolio");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultPortfolioDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
