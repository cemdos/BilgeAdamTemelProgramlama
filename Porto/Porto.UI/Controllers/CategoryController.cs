using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Porto.BLL;
using Porto.BLL.Common;
using Porto.MODEL;
using Porto.MODEL.ViewModel;

namespace Porto.UI.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("Category/GetCategory")]
        public string GetCategory()
        {
            var result = new BaseResponseList<CategoryViewModel>();
            try
            {
                result.ModelList = UnitOfWork.Instance.Category.GetAll().ModelList?
                    .Select(x => new CategoryViewModel
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Description = x.Description,
                        ParentID = x.ParentID
                    }).ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseMessage = ex.Message;
                result.ResponseType = ResponseType.ServiceError;
            }

            var resultString = JsonConvert.SerializeObject(result);
            return resultString;
        }
    }
}
