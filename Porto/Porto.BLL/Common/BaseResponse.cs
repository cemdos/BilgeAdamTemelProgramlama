using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Common
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string ResponseMessage { get; set; }
        public ResponseType ResponseType { get; set; }

        public BaseResponse()
        {
            IsSuccess = true;
            ResponseMessage = string.Empty;
            ResponseType = ResponseType.None;
        }
    }

    public class BaseResponseModel<T> : BaseResponse where T:class
    {
        public T? Model { get; set; }
        public BaseResponseModel()
        {
            Model = null;
        }
    }

    public class BaseResponseList<T> : BaseResponse where T : class
    {
        public IEnumerable<T>? ModelList { get; set; }
        public BaseResponseList()
        {
            ModelList = null;
        }
    }
}
