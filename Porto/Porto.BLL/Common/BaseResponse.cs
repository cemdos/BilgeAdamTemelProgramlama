using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Porto.BLL.Common
{
    public class BaseResponse
    {
        [JsonPropertyName("IsSuccess")]
        public bool IsSuccess { get; set; }
        [JsonPropertyName("ResponseMessage")]
        public string ResponseMessage { get; set; }
        [JsonPropertyName("ResponseType")]
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
        [JsonPropertyName("Model")]
        public T? Model { get; set; }
        public BaseResponseModel()
        {
            Model = null;
        }
    }

    public class BaseResponseList<T> : BaseResponse where T : class
    {
        [JsonPropertyName("ModelList")]
        public IEnumerable<T>? ModelList { get; set; }
        public BaseResponseList()
        {
            ModelList = null;
        }
    }
}
