using Microsoft.EntityFrameworkCore;
using Porto.BLL.Interfaces;
using Porto.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public int Add(T model)
        {
            Database.Context.Set<T>().Add(model);
            return Database.Save();
        }

        public T? Get(int Id)
        {
            var result = GetAll().Where(x => x.ID == Id).FirstOrDefault();
            return result;
        }

        public List<T> GetAll()
        {
            var result = Database.Context.Set<T>().Where(x => x.Deleted == false).ToList();
            return result;
        }

        public int Remove(int Id)
        {
            var removingData = Get(Id);
            if (removingData == null)
                throw new Exception("Silinecek kayıt bulunamadı");

            removingData.DelDate = DateTime.Now;
            removingData.Deleted = true;
            Database.Context.Entry<T>(removingData).State = EntityState.Modified;
            Database.Context.Set<T>().Update(removingData);
            return Database.Save();
        }

        public int Update(T model)
        {
            model.ModDate = DateTime.Now;
            Database.Context.Entry(model).State = EntityState.Modified;
            Database.Context.Set<T>().Update(model);
            return Database.Save();
        }
    }
}
