using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.DtoLAyer.Dtos.ProductImageDto;
using UmutMermer.EntityLayer.Concrate;
using UmutMermer.WebUI.Models.ProductImage;

namespace UmutMermer.WebUI.Controllers
{
    public class AdminProductImageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
        private readonly IProductImageService _productImageService;

        public AdminProductImageController(IHttpClientFactory httpClientFactory, IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment, IProductImageService productImageService)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _environment = environment;
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateProductImage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5254/api/Products/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<AddProductImageVM>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(AddProductImageVM model)
        {

            if (ModelState.IsValid)
            {
                var date = DateTime.Now;
                var extension = Path.GetExtension(model.FileImage.FileName);
                var fileName = $"{date.Day}_{date.Month}_{date.Year}_{date.Hour}_{date.Minute}_{date.Second}_{date.Millisecond}{extension}";
                var filePath = Path.Combine(_environment.WebRootPath, _configuration["Paths:ProductImages"], fileName);

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    model.FileImage.CopyTo(fs);
                    fs.Close();
                }

                var productImage = new ProductImage()
                {
                    Path = Path.Combine(_configuration["Paths:ProductImages"], fileName),
                    ProductId = model.ProductId,
                };




                _productImageService.TInsert(productImage);



                return View();
            }
            return View();

        }

    }
}
