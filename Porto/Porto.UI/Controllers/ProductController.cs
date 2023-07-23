using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Porto.BLL;
using Porto.MODEL;

namespace Porto.UI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("Product/GetProductOfCategory/{CategoryId}")]
        public string GetProductOfCategory(int CategoryId)
        {
            var result = UnitOfWork.Instance.Product.GetProductOfCategory(CategoryId).ToList();
            var resultString = JsonConvert.SerializeObject(result);
            return resultString;
        }
    }
}
