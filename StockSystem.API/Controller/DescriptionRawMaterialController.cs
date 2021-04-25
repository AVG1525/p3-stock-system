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
    public class DescriptionRawMaterialController : ControllerBase
    {
        /// <summary>
        /// Get all descriptions raw material.
        /// </summary>
        /// <param name="_descriptionRawMaterialService"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, "Get all description raw material", typeof(IEnumerable<DescriptionRawMaterialResponse>))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetAllDescriptionRawMaterial([FromServices]IDescriptionRawMaterialService _descriptionRawMaterialService)
        {
            var getAllDescriptionRawMaterial = _descriptionRawMaterialService.GetAllDescriptionRawMaterial();

            if (getAllDescriptionRawMaterial != null)
                return Ok(getAllDescriptionRawMaterial);
            return BadRequest();
        }

        /// <summary>
        /// Get description raw material by id.
        /// </summary>
        /// <param name="_descriptionRawMaterialService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ById")]
        [SwaggerResponse(200, "Get description raw material by id", typeof(DescriptionRawMaterialResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetDescriptionRawMaterialById([FromServices]IDescriptionRawMaterialService _descriptionRawMaterialService,
            [FromQuery, SwaggerParameter("DescriptionRawMaterial id", Required = true)]int id)
        {
            var getDescriptionRawMaterialById = _descriptionRawMaterialService.GetDescriptionRawMaterialById(id);

            if (getDescriptionRawMaterialById != null)
                return Ok(getDescriptionRawMaterialById);
            return BadRequest();
        }

        /// <summary>
        /// Post a description raw material.
        /// </summary>
        /// <param name="_descriptionRawMaterialService"></param>
        /// <param name="descriptionRawMaterialRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(201, "A new description raw material created", typeof(DescriptionRawMaterialResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult PostDescriptionRawMaterial([FromServices]IDescriptionRawMaterialService _descriptionRawMaterialService,
            [FromBody, SwaggerParameter("DescriptionRawMaterial payload", Required = true)]DescriptionRawMaterialRequest descriptionRawMaterialRequest)
        {
            var postDescriptionRawMaterial = _descriptionRawMaterialService.PostDescriptionRawMaterial(descriptionRawMaterialRequest);

            if (postDescriptionRawMaterial != null)
                return Created("", postDescriptionRawMaterial);
            return BadRequest();
        }
    }
}