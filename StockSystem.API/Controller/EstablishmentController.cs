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
    [AllowAnonymous]
    [ApiController]
    public class EstablishmentController : ControllerBase
    {
        /// <summary>
        /// Get all establishments.
        /// </summary>
        /// <param name="_establishmentService"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, "Get all establishments", typeof(IEnumerable<EstablishmentResponse>))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetAll([FromServices]IEstablishmentService _establishmentService)
        {
            var getestablishmentById = _establishmentService.GetAll();

            if (getestablishmentById != null)
                return Ok(getestablishmentById);
            return BadRequest();
        }

        /// <summary>
        /// Get establishment by id.
        /// </summary>
        /// <param name="_establishmentService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ById")]
        [SwaggerResponse(200, "Get establishment by id", typeof(EstablishmentResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetEstablishmentById([FromServices]IEstablishmentService _establishmentService, [FromQuery, SwaggerParameter("Establishment id", Required = true)]string id)
        {
            var getEstablishmentById = _establishmentService.GetEstablishmentById(id);

            if (getEstablishmentById != null)
                return Ok(getEstablishmentById);
            return BadRequest();
        }

        /// <summary>
        /// Post an establishment.
        /// </summary>
        /// <param name="_establishmentService"></param>
        /// <param name="establishmentRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(201, "A new establishment created", typeof(EstablishmentResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult PostEstablishment([FromServices]IEstablishmentService _establishmentService, [FromBody, 
            SwaggerParameter("Establishment payload", Required = true)]EstablishmentRequest establishmentRequest)
        {
            var postEstablishment = _establishmentService.PostEstablishment(establishmentRequest);

            if (postEstablishment != null)
                return Created("", postEstablishment);
            return BadRequest();
        }
    }
}