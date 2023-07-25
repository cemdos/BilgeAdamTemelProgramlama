using Porto.BLL.Common;
using Porto.BLL.Concrete;
using Porto.MODEL;
using Porto.MODEL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Porto.BLL.Concrete.ProductRepository;

namespace Porto.BLL.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        BaseResponseList<ProductViewModel> GetProductOfCategory(int Category);
    }
}
