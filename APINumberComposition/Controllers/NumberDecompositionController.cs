using Microsoft.AspNetCore.Mvc;

using NumberDecomposition.Application.DTOs;
using NumberDecomposition.Domain.Core.Interfaces;
using NumberDecomposition.Domain.Models;

namespace APINumberComposition.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberDecompositionController : ControllerBase
    {

        private readonly INumberDecompositionService _compositionService;

        public NumberDecompositionController(INumberDecompositionService service)
        {
            _compositionService = service;
        }

        [HttpGet]
        public ActionResult<NumberDTO> Get(int number) {

            Number numberDecompose = new Number(number);

            var result = _compositionService.RetornarDivisores(numberDecompose);

            if (result.Error == null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Error);
            }

                
         }
    }
}
