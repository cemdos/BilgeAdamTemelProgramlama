using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Porto.API.Helper;
using Porto.BLL;
using Porto.BLL.Common;
using Porto.MODEL;
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
        public IActionResult AddCategory([FromBody] CategoryViewModel model)
        {
            var result = UnitOfWork.Instance.Category.AddCategory(model);
            if (result.IsSuccess)
            {
                result.ResponseMessage = "Başarılı";
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{Id}")]
        public IActionResult RemoveCategory(int Id)
        {
            var userInfo = AccountHelper.GetUserInfo(Request);
            var result = UnitOfWork.Instance.Category.Remove(Id,userInfo.ID);
            if (result.IsSuccess)
            {
                result.ResponseMessage = "Başarılı";
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        public IActionResult EditCategory([FromBody] Category model)
        {
            var userInfo = AccountHelper.GetUserInfo(Request);
            model.ModUser = userInfo.ID;
            var result = UnitOfWork.Instance.Category.Update(model);
            if (result.IsSuccess)
            {
                result.ResponseMessage = "Başarılı";
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}
