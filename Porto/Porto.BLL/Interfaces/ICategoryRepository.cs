using Porto.BLL.Common;
using Porto.MODEL;
using Porto.MODEL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Interfaces
{
    public interface ICategoryRepository:IBaseRepository<Category>
    {
        BaseResponseList<CategoryViewModel> GetCategoryList();
    }
}
