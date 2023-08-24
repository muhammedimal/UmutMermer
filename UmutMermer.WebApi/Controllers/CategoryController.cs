using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.DtoLAyer.Dtos.CategoryDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly Context _context;
        public CategoryController(ICategoryService categoryService, IMapper mapper, Context context)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryGetDto category)
        {
            var values = _mapper.Map<Category>(category);
            _categoryService.TInsert(values);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory(CategoryGetDto category)
        {
            var values = _mapper.Map<Category>(category);
            _categoryService.TUpdate(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            return Ok(values);
        }

            [HttpGet("product{categoryId}")]
        public IActionResult GetProductsByCategoryId(int categoryId)
        {
            var products = _context.Products.Where(p => p.CategoryId == categoryId).ToList();
            return Ok(products);
        }
    }
}
