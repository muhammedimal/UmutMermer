using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.DtoLAyer.Dtos.ProductImageDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService _productImageService;
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;

        public ProductImageController(IProductImageService productImageService, Context context, IConfiguration configuration, IMapper mapper, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _productImageService = productImageService;
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult ImageList()
        {
            var values = _productImageService.TGetList();
            return Ok (values);
        }
 
        [HttpPost]
        public IActionResult AddProductImage([FromForm] AddProductImage addProductImage)
        {
            var productId = _context.Products.Any(x => x.ProductId == addProductImage.ProductId);

            if (!productId)
            {
                var error = $"{addProductImage.ProductId} Id'li Ürün Bulunamadı.";
                return BadRequest(error);
            }
            var date = DateTime.Now;
            var extension = Path.GetExtension(addProductImage.UploadFile.FileName);
            var fileName = $"{date.Day}_{date.Month}_{date.Year}_{date.Hour}_{date.Minute}_{date.Second}_{date.Millisecond}{extension}";
            var filePath = Path.Combine(_environment.WebRootPath, _configuration["Paths:ProductImages"], fileName);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                addProductImage.UploadFile.CopyTo(fs);
                fs.Close();
            }

           

            var productImageEntity = _mapper.Map<ProductImage>(addProductImage);
           
            productImageEntity.Path = $"{_configuration["Paths:ProductImages"]}/{fileName}";
            _productImageService.TInsert(productImageEntity);
            return Ok();
        }

    }
}
