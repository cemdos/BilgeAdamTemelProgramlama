using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS10Lib.Models.ResponseModel
{
    public class ResponseListModel<TModel> : ResponseModel where TModel :  class
    {
        public List<TModel> ListModel { get; set; }
    }
}
