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
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <param name="_userService"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, "Get all users", typeof(IEnumerable<UserResponse>))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetAll([FromServices]IUserService _userService)
        {
            var getUserById = _userService.GetAll();

            if (getUserById != null)
                return Ok(getUserById);
            return BadRequest();
        }

        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <param name="_userService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ById")]
        [SwaggerResponse(200, "User by id", typeof(UserResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult GetUserById([FromServices]IUserService _userService, [FromQuery, SwaggerParameter("User id", Required = true)]string id)
        {
            var getUserById = _userService.GetUserById(id);
            
            if(getUserById != null)
                return Ok(getUserById);
            return BadRequest();
        }

        /// <summary>
        /// Post an user.
        /// </summary>
        /// <param name="_userService"></param>
        /// <param name="userResquest"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(201, "A new user created", typeof(UserResponse))]
        [SwaggerResponse(401, "Unauthorized")]
        public IActionResult PostUser([FromServices]IUserService _userService, [FromBody, SwaggerParameter("User payload", Required = true)]UserRequest userResquest)
        {
            var postUser = _userService.PostUser(userResquest);

            if (postUser != null)
                return Created("", postUser);
            return BadRequest();
        }
    }
}