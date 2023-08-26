using Porto.BLL.Common;
using Porto.BLL.Interfaces;
using Porto.MODEL;
using Porto.MODEL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public BaseResponse AddCategory(CategoryViewModel model)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("Name", model.Name);
            parameters.Add("Description", model.Description ?? string.Empty);
            parameters.Add("ParentId", model.ParentID);
            var response = ExecProc<CategoryViewModel>("sp_CategoryCtrl_AddCategory", parameters);
            return response;
        }

        public BaseResponseList<CategoryViewModel> GetCategoryList()
        {
            var parameters = new Dictionary<string, object>();
            var response = ExecProc<CategoryViewModel>("sp_CategoryCtrl_GetCategory", parameters);
            return response;
        }
    }
}
