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
           var values = _companyInfo.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCompanyInfo(CompanyInfo companyinfo)
        {
           _companyInfo.TInsert(companyinfo);
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

            _companyInfo.TUpdate(companyInfo);
            
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCompanyInfo(int id)
        {

            var values = _companyInfo.TGetById(id);
            return Ok(values);

        }
    }
}

