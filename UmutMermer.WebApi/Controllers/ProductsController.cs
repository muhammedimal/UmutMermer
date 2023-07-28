using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public IActionResult ProductsList()
        {
            var values = _productsService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProducts(Products products)
        {
            _productsService.TInsert(products);
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
        public IActionResult UpdateProducts(Products products)
        {
            _productsService.TUpdate(products);
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

