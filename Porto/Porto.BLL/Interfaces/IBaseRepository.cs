using Porto.BLL.Common;
using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        BaseResponseList<T> GetAll();
        BaseResponseModel<T>? Get(int Id);
        BaseResponse Add(T model);
        BaseResponse Remove(int Id);
        BaseResponse Update(T model);
        BaseResponseList<TViewModel> ExecProc<TViewModel>(string procName, Dictionary<string, dynamic> parameters)
            where TViewModel : class, new();
        BaseResponseModel<TViewModel> ExecProcModel<TViewModel>(string procName, Dictionary<string, dynamic> parameters)
           where TViewModel : class, new();
    }
}
