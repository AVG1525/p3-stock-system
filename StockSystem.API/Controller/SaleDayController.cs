using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace StockSystem.API.Controller
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [Authorize]
    [ApiController]
    public class SaleDayController : ControllerBase
    {
        /// <summary>
        /// Get All sale days.
        /// </summary>
        /// <param name="_saleDayService"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, "Get all sale days", typeof(IEnumerable<SaleDayResponse>))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetAll([FromServices]ISaleDayService _saleDayService)
        {
            var getAllSaleDays = _saleDayService.GetAllSaleDay();

            if (getAllSaleDays != null)
                return Ok(getAllSaleDays);
            return BadRequest();
        }

        /// <summary>
        /// Get sale day by id.
        /// </summary>
        /// <param name="_saleDayService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ById")]
        [SwaggerResponse(200, "Get sale day by id", typeof(SaleDayResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetSaleDayById([FromServices]ISaleDayService _saleDayService
            , [FromQuery, SwaggerParameter("SaleDay id", Required = true)]int id)
        {
            var getSaleDayById = _saleDayService.GetSaleDayById(id);

            if (getSaleDayById != null)
                return Ok(getSaleDayById);
            return BadRequest();
        }

        /// <summary>
        /// Post a sale day.
        /// </summary>
        /// <param name="_saleDayService"></param>
        /// <param name="saleDayRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(201, "A new sale day created", typeof(SaleDayResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult PostSaleDay([FromServices]ISaleDayService _saleDayService, 
            [FromBody, SwaggerParameter("SaleDay payload", Required = true)]SaleDayRequest saleDayRequest)
        {
            var postSaleDay = _saleDayService.PostSaleDay(saleDayRequest);

            if (postSaleDay != null)
                return Created("", postSaleDay);
            return BadRequest();
        }
    }
}