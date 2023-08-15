using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.DtoLAyer.Dtos.CompanyInfoDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfoController : ControllerBase
    {
        private readonly ICompanyİnfoService _companyİnfo;
        private readonly IMapper _mapper;

        public CompanyInfoController(ICompanyİnfoService companyİnfo,Mapper mapper)
        {
            _companyİnfo = companyİnfo;
            _mapper = mapper;
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
        public IActionResult UpdateCompanyİnfo(CompanyInfoUpdateDto companyInfoUpdateDto)
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest();
            }
            var values = _mapper.Map<CompanyInfo>(companyInfoUpdateDto);
            _companyİnfo.TUpdate(values);           
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

