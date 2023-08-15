﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyİnfoController : ControllerBase
    {
        private readonly ICompanyİnfoService _companyİnfo;

        public CompanyİnfoController(ICompanyİnfoService companyİnfo)
        {
            _companyİnfo = companyİnfo;
        }

        [HttpGet]
        public IActionResult CompanyİnfoList()
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult AddCompanyİnfo()
        {

            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteCompanyİnfo()
        {

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCompanyİnfo(Companyİnfo companyİnfo)
        {
            companyİnfo.Id = 1;
            _companyİnfo.TUpdate(companyİnfo);
            
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCompanyİnfo(int id)
        {
            id = 1; 
            var values = _companyİnfo.TGetById(id);
            return Ok(values);

        }
    }
}

