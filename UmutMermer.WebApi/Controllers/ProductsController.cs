using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;
        private readonly IMapper _mapper;

        public ProductsController(IProductsService productsService,IMapper mapper)
        {
            _productsService = productsService;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult ProductsList()
        {
            var values = _productsService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProducts(ProductAddDto productAddDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Product>(productAddDto);
            _productsService.TInsert(values);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteProducts(int id)
        {
            var values = _productsService.TGetById(id);
            _productsService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProducts(ProductUpdateDto productUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Product>(productUpdateDto);
            _productsService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProducts(int id)
        {
            var values = _productsService.TGetById(id);
            return Ok(values);

        }
    }
}

