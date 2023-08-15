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
        private readonly ICompanyInfoService _companyInfo;

        public CompanyInfoController(ICompanyInfoService companyInfo)
        {
            _companyInfo = companyInfo;
        }

        [HttpGet]
        public IActionResult CompanyInfoList()
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult AddCompanyInfo()
        {

            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteCompanyInfo()
        {

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCompanyInfo(CompanyInfo companyInfo)
        {
            companyInfo.Id = 1;
            _companyInfo.TUpdate(companyInfo);
            
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCompanyInfo(int id)
        {
            id = 1; 
            var values = _companyInfo.TGetById(id);
            return Ok(values);

        }
    }
}

