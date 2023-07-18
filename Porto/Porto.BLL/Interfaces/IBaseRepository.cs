using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        List<T> GetAll();
        T? Get(int Id);
        int Add(T model);
        int Remove(int Id);
        int Update(T model);
    }
}
