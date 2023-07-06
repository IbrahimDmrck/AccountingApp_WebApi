using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalTaxsController : ControllerBase
    {
        private readonly IAdditionalTaxService _additionalTaxService;

        public AdditionalTaxsController(IAdditionalTaxService additionalTaxService)
        {
            _additionalTaxService = additionalTaxService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _additionalTaxService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _additionalTaxService.GetEntityById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(AdditionalTax additionalTax)
        {
            var result = _additionalTaxService.Add(additionalTax);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(AdditionalTax additionalTax)
        {
            var result = _additionalTaxService.Delete(additionalTax);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(AdditionalTax additionalTax)
        {
            var result = _additionalTaxService.Update(additionalTax);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
