using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Porto.BLL;
using Porto.MODEL;

namespace Porto.UI.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("Category/GetCategory")]
        public string GetCategory()
        {
            var result = UnitOfWork.Instance.Category.GetAll()
                .Select(x=> new {
                        ID= x.ID,
                        Name = x.Name,
                        Description = x.Description,
                        ParentID = x.ParentID
                }).ToList();
            var resultString = JsonConvert.SerializeObject(result);
            return resultString;
        }
    }
}
