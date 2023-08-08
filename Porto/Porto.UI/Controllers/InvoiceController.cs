using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Porto.BLL;
using Porto.MODEL;
using Porto.MODEL.ViewModel.RequestModel;

namespace Porto.UI.Controllers
{
    public class InvoiceController : Controller
    {
        [HttpPost]
        [Route("/Invoice/SaveInvoice")]
        public string SaveInvoice([FromBody]InvoiceRequestModel model)
        {
            var result = UnitOfWork.Instance.Invoice.AddInvoice(model);
            var resultString = JsonConvert.SerializeObject(result);
            return resultString;
        }
    }
}
