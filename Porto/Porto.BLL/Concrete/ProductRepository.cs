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

namespace Porto.BLL.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public IList<ProductViewModel> GetProductOfCategory(int CategoryId)
        {
            var parameters = new SqlParameter("@CategoryId", CategoryId);
            //var productList = Database.Context.Database.SqlQueryRaw<ProductViewModel>("sp_ProductWithCategory", parameters, CommandType.StoredProcedure).ToList();
            var productList = Database.Context.Product.FromSqlRaw<Product>($"exec sp_ProductWithCategory {CategoryId}")
                .AsEnumerable()
                .Select(x => new ProductViewModel
                {
                    Name = x.Name,
                    Description = x.Description,
                }).ToList();


            return productList;
        }

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string? Description { get; set; }
        }
    }
}
