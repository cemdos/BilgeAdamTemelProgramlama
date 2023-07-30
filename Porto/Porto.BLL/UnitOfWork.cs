using Porto.BLL.Concrete;
using Porto.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL
{
    public class UnitOfWork
    {
        private static UnitOfWork? instance;

        public static UnitOfWork Instance
        {
            get
            {
                if (instance == null)
                    instance = new UnitOfWork();
                return instance;
            }
        }

        public ICategoryRepository Category => new CategoryRepository();
        public IProductRepository Product => new ProductRepository();
        public IPictureRepository Picture => new PictureRepository();
    }
}
