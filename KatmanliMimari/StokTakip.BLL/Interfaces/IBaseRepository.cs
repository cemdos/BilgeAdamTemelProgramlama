using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseModel
    {
        List<TEntity> GetAll();
        TEntity Get(int Id);
        int Add(TEntity entity);
        int Remove(int Id);
        int Update(TEntity entity);
    }
}
