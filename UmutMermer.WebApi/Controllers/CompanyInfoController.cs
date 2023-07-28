using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfoController : ControllerBase
    {
        private readonly ICompanyİnfoService _companyİnfo;

        public CompanyInfoController(ICompanyİnfoService companyİnfo)
        {
            _companyİnfo = companyİnfo;
        }

        [HttpGet]
        public IActionResult CompanyİnfoList()
        {
            var value =_companyİnfo.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddCompanyİnfo(CompanyInfo companyInfo)
        {
            _companyİnfo.TInsert(companyInfo);
            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteCompanyİnfo()
        {

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCompanyİnfo(CompanyInfo companyİnfo)
        {
 
            _companyİnfo.TUpdate(companyİnfo);
            
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCompanyİnfo(int id)
        {
            var values = _companyİnfo.TGetById(id);
            return Ok(values);

        }
    }
}

