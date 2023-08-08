using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Porto.BLL.Interfaces;
using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoredProcedureEFCore;
using Porto.MODEL.ViewModel;
using Porto.BLL.Common;
using Porto.MODEL.ViewModel.RequestModel;
using System.Net;
using System.Numerics;

namespace Porto.BLL.Concrete
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public BaseResponse AddInvoice(InvoiceRequestModel model)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("Name", model.Customer.Name);
            parameters.Add("Email", model.Customer.Email);
            parameters.Add("Address", model.Customer.Address);
            parameters.Add("Phone", model.Customer.Phone);
            var response = ExecProcModel<BaseResponse>("sp_AddInvoice", parameters);
            return response;
        }
    }
}
