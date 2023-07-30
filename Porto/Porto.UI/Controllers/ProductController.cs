using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Porto.BLL;
using Porto.MODEL;

namespace Porto.UI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("/Product/GetProductOfCategory/{CategoryId}")]
        public string GetProductOfCategory(int CategoryId)
        {
            var result = UnitOfWork.Instance.Product.GetProductOfCategory(CategoryId);
            if (result == null)
                return "";
            var resultString = JsonConvert.SerializeObject(result);
            return resultString;
        }

        [HttpGet]
        [Route("/Product/GetProduct/{ProductId}")]
        public string GetProduct(int ProductId)
        {
            var result = UnitOfWork.Instance.Product.GetProductDetail(ProductId);
            var resultString = JsonConvert.SerializeObject(result) ?? string.Empty;
            return resultString;
        }
    }
}
