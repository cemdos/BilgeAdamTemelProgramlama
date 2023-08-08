using Porto.BLL.Common;
using Porto.BLL.Concrete;
using Porto.MODEL;
using Porto.MODEL.ViewModel;
using Porto.MODEL.ViewModel.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Interfaces
{
    public interface IInvoiceRepository:IBaseRepository<Invoice>
    {
        BaseResponse AddInvoice(InvoiceRequestModel model);
    }
}
