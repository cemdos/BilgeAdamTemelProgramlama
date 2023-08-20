using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Porto.API.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("api/base/apihealthcheck")]
        public IActionResult ApiHealthCheck()
        {
            return Ok();
        }

        [HttpGet]
        [Authorize]
        [Route("api/base/GetRole")]
        public IActionResult GetRole()
        {
            try
            {
                string jwtToken = Request.Headers["Authorization"].ToString().Remove(0,7);
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken decodedToken = tokenHandler.ReadJwtToken(jwtToken);
                string? Role = decodedToken.Payload["Role"].ToString();
                return Ok(Role);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }


    }
}
