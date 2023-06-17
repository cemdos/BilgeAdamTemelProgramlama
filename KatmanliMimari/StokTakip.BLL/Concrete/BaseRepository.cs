using StokTakip.BLL.Interfaces;
using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public int Add(T entity)
        {
            Database.Context.Set<T>().Add(entity);
            return Database.Save();
        }

        public T Get(int Id)
        {
            return Database.Context.Set<T>().Where(x => x.ID == Id && x.Deleted == false).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return Database.Context.Set<T>().Where(x => x.Deleted == false).ToList();
        }

        public int Remove(int Id)
        {
            var removingData = Get(Id);
            removingData.DelDate = DateTime.Now;
            removingData.Deleted = true;
            Database.Context.Entry<T>(removingData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Database.Context.Set<T>().Update(removingData);
            return Database.Save();
        }

        public int Update(T entity)
        {
            entity.ModDate = DateTime.Now;
            Database.Context.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Database.Context.Set<T>().Update(entity);
            return Database.Save();
        }
    }
}
