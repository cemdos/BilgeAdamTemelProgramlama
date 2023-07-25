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
        public BaseResponseList<ProductViewModel>? GetProductOfCategory(int CategoryId)
        {
            var result = new BaseResponseList<ProductViewModel>();
            try
            {
                Database.Context.LoadStoredProc("sp_ProductWithCategory")
                    .AddParam("CategoryId", CategoryId)
                    .Exec(r => result.ModelList = r.ToList<ProductViewModel>());
                throw new Exception("Database tarafoında hata aldı");
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ResponseType = ResponseType.DbError;
                result.ResponseMessage = ex.Message;
            }
            
            return result;
        }
    }
}
