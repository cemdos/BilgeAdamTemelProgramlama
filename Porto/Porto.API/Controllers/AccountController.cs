using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Porto.BLL;
using Porto.BLL.Common;
using Porto.MODEL.ViewModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Porto.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AccountController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("{Username}/{Password}")]
        [AllowAnonymous]
        public IActionResult Login(string Username, string Password)
        {
            BaseResponseModel<UserViewModel>? response = null;
            try
            {
                response = UnitOfWork.Instance.User.Login(Username, Password);
                if (response?.IsSuccess == true)
                {
                    var userID = response.Model?.ID ?? 0;
                    var token = CreateToken(userID);
                    return Ok(token);
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                return BadRequest(response);
            }
        }

        private string CreateToken(int UserID)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenSecretKey = _config.GetSection("Token:SecretKey").Value ?? string.Empty;
            var tokenExpireMinutes = int.Parse(_config.GetSection("Token:ExpireMinutes").Value ?? "0");

            var key = Encoding.ASCII.GetBytes(tokenSecretKey);
            var tokendecriptır = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserID", UserID.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(tokenExpireMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokendecriptır);
            string TokenString = tokenHandler.WriteToken(token);
            return TokenString;
        }
    }
}
