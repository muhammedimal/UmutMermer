using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpGet]
        public IActionResult PortfolioList()
        {
            var values = _portfolioService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            _portfolioService.TInsert(portfolio);
            return Ok();
        }


        [HttpDelete]
        public IActionResult DeletePortfolio(int id)
        {
            var values = _portfolioService.TGetById(id);
            _portfolioService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioService.TUpdate(portfolio);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPortfolio(int id)
        {
            var values = _portfolioService.TGetById(id);
            return Ok(values);

        }
    }
}

