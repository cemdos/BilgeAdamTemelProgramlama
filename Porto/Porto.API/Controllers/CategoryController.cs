using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Porto.BLL;
using Porto.BLL.Common;
using Porto.MODEL.Enums;
using Porto.MODEL.ViewModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Porto.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            BaseResponseList<CategoryViewModel>? response = null;
            try
            {
                response = UnitOfWork.Instance.Category.GetCategoryList();
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody]CategoryViewModel model)
        {
            return Ok();
        }
    }
}
