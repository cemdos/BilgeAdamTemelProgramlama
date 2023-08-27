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
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProductList()
        {
            BaseResponseList<ProductViewModel>? response = null;
            try
            {
                response = UnitOfWork.Instance.Product.GetAllProduct();
                #region Uzun Yol
                //bool state;
                //if (response == null)
                //    state = false;
                //else
                //    state = response.IsSuccess;
                //if (state == false)
                #endregion

                var state = response?.IsSuccess ?? false;
                if (!state)
                    throw new Exception();
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest(response);
            }
        }
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product model)
        {
            var result = UnitOfWork.Instance.Product.Add(model);
            if (result.IsSuccess)
            {
                result.ResponseMessage = "Başarılı";
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
