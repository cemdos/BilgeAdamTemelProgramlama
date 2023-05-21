using HS10Lib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS10Lib.Models.ResponseModel
{
    public class ResponseModel
    {
        public ResponseCodes ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string Stack { get; set; }
        public int affectedRows { get; set; }

        public ResponseModel()
        {
            ResponseCode = ResponseCodes.Successfull;
            ResponseMessage= string.Empty;
            Stack = string.Empty;
            affectedRows = 0;
        }
    }
}
