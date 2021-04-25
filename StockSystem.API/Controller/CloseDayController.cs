using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using Swashbuckle.AspNetCore.Annotations;

namespace StockSystem.API.Controller
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [Authorize]
    [ApiController]
    public class CloseDayController : ControllerBase
    {
        /// <summary>
        /// Post a close day.
        /// </summary>
        /// <param name="_closeDayService"></param>
        /// <param name="closeDayRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(201, "A new close day created", typeof(CloseDayResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult PostCloseDay([FromServices]ICloseDayService _closeDayService, [FromBody, SwaggerParameter("Close day payload", Required = true)]CloseDayRequest closeDayRequest)
        {
            var newPostCloseDay = _closeDayService.PostCloseDay(closeDayRequest);

            if (newPostCloseDay != null)
                return Created("", newPostCloseDay);
            return BadRequest();
        }
    }
}