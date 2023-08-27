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

namespace Porto.BLL.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public BaseResponseList<ProductViewModel>? GetAllProduct()
        {
            var parameters = new Dictionary<string, object>();
            var response = ExecProc<ProductViewModel>("sp_ProductCtrl_GetProductList", parameters);
            return response;
        }

        public BaseResponseList<ProductViewModel>? GetProductOfCategory(int CategoryId)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("CategoryId", CategoryId);
            var response = ExecProc<ProductViewModel>("sp_ProductWithCategory", parameters);

            return response;
        }

        public BaseResponseModel<ProductDetailViewModel>? GetProductDetail(int ProductId)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("ProductId", ProductId);
            var response = ExecProcModel<ProductDetailViewModel>("sp_GetProductDetail", parameters);
            if (response.Model != null)
                response.Model.Images = UnitOfWork.Instance.Picture.GetAll().ModelList?.Where(x => x.ID_Product == ProductId).ToList();
            return response;
        }
    }
}
